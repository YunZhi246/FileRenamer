using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MangaRenamer.Objects;

namespace MangaRenamer
{
    public partial class RenamerForm : Form
    {
        /// <summary>
        /// Key is name of file
        /// Value is path of file
        /// </summary>
        private SortedList<string, string> masterFileNames;
        private Dictionary<TabPage, Tab> tabsList;
        Tab currentTab;


        public RenamerForm()
        {
            InitializeComponent();                

            this.SetVariables();
        }

        public SortedList<string, string> RenumIssues { get; set; }

        public SortedList<string, string> TitleIssues { get; set; }

        public SortedList<string, string> ChapterIssues { get; set; }

        public SortedList<string, string> VolumeIssues { get; set; }

        public SortedList<string, string> NewFiles { get; set; }

        public SortedList<string, string> DeleteFiles { get; set; }

        public string Directory { get; private set; }

        private string ChooseFolder()
        {
            string path = string.Empty;
            FolderBrowserDialog chooseFolder = new FolderBrowserDialog();
            chooseFolder.ShowNewFolderButton = false;
            chooseFolder.RootFolder = Environment.SpecialFolder.MyComputer;
            chooseFolder.SelectedPath = @"Z:\new";
            DialogResult result = chooseFolder.ShowDialog();                        
            if(result == DialogResult.OK)
            {
                path = chooseFolder.SelectedPath;
            }

            return path;
        }

        private void SetVariables()
        {
            List<string> fileNames = new List<string>();
            this.Directory = ChooseFolder();

            if (this.Directory != string.Empty)
            {
                string[] files = System.IO.Directory.GetFiles(this.Directory, "*.jpg");
                fileNames = files.ToList<string>();
            }
                            
            masterFileNames = new SortedList<string, string>();
            foreach (string fileName in fileNames)
            {
                int lastIndex = fileName.LastIndexOf(@"\");
                masterFileNames.Add(fileName.Substring(lastIndex + 1), fileName);
            }

            tabsList = new Dictionary<TabPage, Tab>();
            Tab numbering = new Tab("Numbering", null, this.numberingTabPage, this.masterFileNames, this.numberingPanel);
            Tab title = new Tab("Title", new PropertyTag("title", 0x9C9B, 1), this.titleTabPage, this.masterFileNames, this.titlePanel);
            Tab chapter = new Tab("Chapter", new PropertyTag("subject", 0x9C9F, 1), this.chapterTabPage, this.masterFileNames, this.chapterPanel);
            Tab volume = new Tab("Volume", new PropertyTag("comment", 0x9C9C, 1), this.volumeTabPage, this.masterFileNames, this.volumePanel);
            tabsList.Add(this.numberingTabPage, numbering);
            tabsList.Add(this.titleTabPage, title);
            tabsList.Add(this.chapterTabPage, chapter);
            tabsList.Add(this.volumeTabPage, volume);

            RenumIssues = new SortedList<string, string>();
            TitleIssues = new SortedList<string, string>();
            ChapterIssues = new SortedList<string, string>();
            VolumeIssues = new SortedList<string, string>();
            NewFiles = new SortedList<string, string>();
            DeleteFiles = new SortedList<string, string>();

            this.currentTab = numbering;
            this.RefreshListBoxes();
            this.RefreshEnabled();
        }

        private void RefreshListBoxes()
        {
            this.includeListBox.DataSource = this.currentTab.IncludedFiles.Keys.ToList<string>();
            this.excludeListBox.DataSource = this.currentTab.ExcludedFiles.Keys.ToList<string>();
        }

        private void RefreshEnabled()
        {
            if (this.currentTab.Enabled)
            {
                this.currentTab.Panel.Enabled = true;
                this.includeExcludePanel.Enabled = true;
                this.enabledCheckBox.CheckState = CheckState.Checked;
            }
            else
            {
                this.currentTab.Panel.Enabled = false;
                this.includeExcludePanel.Enabled = false;
                this.enabledCheckBox.CheckState = CheckState.Unchecked;
            }
        }

        private void EnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.currentTab.Enabled = this.enabledCheckBox.CheckState == CheckState.Checked;
            this.RefreshEnabled();
        }

        private void OptionsTabPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.optionsTabPanel.SelectedTab == this.submitTabPage)
            {
                this.enabledCheckBox.Visible = false;
                this.includeExcludePanel.Visible = false;
                this.issuesListBox.Enabled = false;                                      
            }
            else
            {
                this.enabledCheckBox.Visible = true;
                this.includeExcludePanel.Visible = true;
                tabsList.TryGetValue(this.optionsTabPanel.SelectedTab, out this.currentTab);
                this.RefreshListBoxes();
                this.RefreshEnabled();
            }
        }

        private void OneExclude_Click(object sender, EventArgs e)
        {
            foreach(object select in this.includeListBox.SelectedItems)
            {
                string key = (string)select;
                string value;
                bool foundValue = this.currentTab.IncludedFiles.TryGetValue(key, out value);
                if (foundValue)
                {
                    this.currentTab.ExcludedFiles.Add(key, value);
                    this.currentTab.IncludedFiles.Remove(key);
                    this.RefreshListBoxes();
                }
            }
        }

        private void OneInclude_Click(object sender, EventArgs e)
        {
            foreach (object select in this.excludeListBox.SelectedItems)
            {
                string key = (string)select;
                string value;
                bool foundValue = this.currentTab.ExcludedFiles.TryGetValue(key, out value);
                if (foundValue)
                {
                    this.currentTab.IncludedFiles.Add(key, value);
                    this.currentTab.ExcludedFiles.Remove(key);
                    this.RefreshListBoxes();
                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool somethingHappened = false;
            foreach(KeyValuePair<TabPage, Tab> tab in this.tabsList)
            {
                if (tab.Value.Enabled)
                {
                    somethingHappened = true;
                    this.UpdateIncludeList(tab.Value.IncludedFiles);

                    if (tab.Value.Name == "Numbering")
                    {
                        Program.Renumbering(this, tab.Value.IncludedFiles, (int)this.numberingDigitsNumericUpDown.Value);
                    }
                    else if(tab.Value.Name == "Title")
                    {
                        this.SetProperty(this.TitleIssues, tab.Value.IncludedFiles, Program.titleID, 1, this.titleTextBox.Text); 
                    }
                    else if(tab.Value.Name == "Chapter")
                    {
                        this.SetProperty(this.ChapterIssues, tab.Value.IncludedFiles, Program.chapterID, 1, this.chapterTextBox.Text);
                    }
                    else if(tab.Value.Name == "Volume")
                    {
                        this.SetProperty(this.VolumeIssues, tab.Value.IncludedFiles, Program.volumeID, 1, this.volumeTextBox.Text);
                    }
                }
            }

            if (somethingHappened)
            {                                           
                foreach(KeyValuePair<TabPage, Tab> tab in this.tabsList)
                {
                    this.UpdateIncludeList(tab.Value.IncludedFiles);
                }

                foreach (KeyValuePair<string, string> file in this.DeleteFiles)
                {
                    File.Delete(file.Value);
                }

                List<string> issuesList = new List<string>();
                issuesList.AddRange(this.RenumIssues.Keys.ToList<string>());
                issuesList.AddRange(this.TitleIssues.Keys.ToList<string>());
                issuesList.AddRange(this.ChapterIssues.Keys.ToList<string>());
                issuesList.AddRange(this.VolumeIssues.Keys.ToList<string>());

                this.issuesListBox.Enabled = true;
                this.issuesListBox.DataSource = issuesList;
                this.submitButton.Enabled = false;
                this.resubmitButton.Enabled = true;

                MessageBox.Show($"Process complete with {issuesList.Count} issues encountered.");
            }
        }

        private void ResubmitButton_Click(object sender, EventArgs e)
        {
            this.RenumIssues = new SortedList<string, string>();
            this.TitleIssues = new SortedList<string, string>();
            this.ChapterIssues = new SortedList<string, string>();
            this.VolumeIssues = new SortedList<string, string>();

            this.SubmitButton_Click(sender, e);
        }

        private void UpdateIncludeList(SortedList<string, string> includeList)
        {
            foreach(KeyValuePair<string, string> file in this.DeleteFiles)
            {
                includeList.Remove(file.Key);
            }

            foreach(KeyValuePair<string, string> file in this.NewFiles)
            {
                includeList.Add(file.Key, file.Value);
            }
        }

        private void SetProperty(SortedList<string, string> issues, SortedList<string, string> files, int propID, short propType, string value)
        {
            foreach (KeyValuePair<string, string> file in files)
            {
                bool isSet = Program.ImageSetProperty(file.Value, this.Directory, propID, propType, value);
                if (!isSet)
                {
                    issues.Add(file.Key, file.Value);
                }
            }
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            this.SetVariables();
        }
    }
}
