namespace MangaRenamer
{
    partial class RenamerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.includeExcludePanel = new System.Windows.Forms.Panel();
            this.allInclude = new System.Windows.Forms.Button();
            this.allExclude = new System.Windows.Forms.Button();
            this.oneInclude = new System.Windows.Forms.Button();
            this.oneExclude = new System.Windows.Forms.Button();
            this.excludeLabel = new System.Windows.Forms.Label();
            this.excludeListBox = new System.Windows.Forms.ListBox();
            this.includeLabel = new System.Windows.Forms.Label();
            this.includeListBox = new System.Windows.Forms.ListBox();
            this.enabledCheckBox = new System.Windows.Forms.CheckBox();
            this.optionsTabPanel = new System.Windows.Forms.TabControl();
            this.numberingTabPage = new System.Windows.Forms.TabPage();
            this.numberingPanel = new System.Windows.Forms.Panel();
            this.numberingDigitsLabel = new System.Windows.Forms.Label();
            this.numberingDigitsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.titleTabPage = new System.Windows.Forms.TabPage();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleTextLabel = new System.Windows.Forms.Label();
            this.chapterTabPage = new System.Windows.Forms.TabPage();
            this.chapterPanel = new System.Windows.Forms.Panel();
            this.chapterTextBox = new System.Windows.Forms.TextBox();
            this.chapterTextLabel = new System.Windows.Forms.Label();
            this.volumeTabPage = new System.Windows.Forms.TabPage();
            this.volumePanel = new System.Windows.Forms.Panel();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.volumeTextLabel = new System.Windows.Forms.Label();
            this.submitTabPage = new System.Windows.Forms.TabPage();
            this.submitPanel = new System.Windows.Forms.Panel();
            this.resubmitButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.issuesListBox = new System.Windows.Forms.ListBox();
            this.issuesLabel = new System.Windows.Forms.Label();
            this.folderButton = new System.Windows.Forms.Button();
            this.optionsPanel.SuspendLayout();
            this.includeExcludePanel.SuspendLayout();
            this.optionsTabPanel.SuspendLayout();
            this.numberingTabPage.SuspendLayout();
            this.numberingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberingDigitsNumericUpDown)).BeginInit();
            this.titleTabPage.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.chapterTabPage.SuspendLayout();
            this.chapterPanel.SuspendLayout();
            this.volumeTabPage.SuspendLayout();
            this.volumePanel.SuspendLayout();
            this.submitTabPage.SuspendLayout();
            this.submitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.includeExcludePanel);
            this.optionsPanel.Controls.Add(this.enabledCheckBox);
            this.optionsPanel.Controls.Add(this.optionsTabPanel);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsPanel.Location = new System.Drawing.Point(0, 0);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(784, 451);
            this.optionsPanel.TabIndex = 3;
            // 
            // includeExcludePanel
            // 
            this.includeExcludePanel.Controls.Add(this.allInclude);
            this.includeExcludePanel.Controls.Add(this.allExclude);
            this.includeExcludePanel.Controls.Add(this.oneInclude);
            this.includeExcludePanel.Controls.Add(this.oneExclude);
            this.includeExcludePanel.Controls.Add(this.excludeLabel);
            this.includeExcludePanel.Controls.Add(this.excludeListBox);
            this.includeExcludePanel.Controls.Add(this.includeLabel);
            this.includeExcludePanel.Controls.Add(this.includeListBox);
            this.includeExcludePanel.Location = new System.Drawing.Point(52, 93);
            this.includeExcludePanel.Name = "includeExcludePanel";
            this.includeExcludePanel.Size = new System.Drawing.Size(671, 290);
            this.includeExcludePanel.TabIndex = 12;
            // 
            // allInclude
            // 
            this.allInclude.Location = new System.Drawing.Point(298, 211);
            this.allInclude.Name = "allInclude";
            this.allInclude.Size = new System.Drawing.Size(75, 23);
            this.allInclude.TabIndex = 17;
            this.allInclude.Text = "<<";
            this.allInclude.UseVisualStyleBackColor = true;
            // 
            // allExclude
            // 
            this.allExclude.Location = new System.Drawing.Point(298, 182);
            this.allExclude.Name = "allExclude";
            this.allExclude.Size = new System.Drawing.Size(75, 23);
            this.allExclude.TabIndex = 16;
            this.allExclude.Text = ">>";
            this.allExclude.UseVisualStyleBackColor = true;
            // 
            // oneInclude
            // 
            this.oneInclude.Location = new System.Drawing.Point(298, 105);
            this.oneInclude.Name = "oneInclude";
            this.oneInclude.Size = new System.Drawing.Size(75, 23);
            this.oneInclude.TabIndex = 15;
            this.oneInclude.Text = "<";
            this.oneInclude.UseVisualStyleBackColor = true;
            this.oneInclude.Click += new System.EventHandler(this.OneInclude_Click);
            // 
            // oneExclude
            // 
            this.oneExclude.Location = new System.Drawing.Point(298, 76);
            this.oneExclude.Name = "oneExclude";
            this.oneExclude.Size = new System.Drawing.Size(75, 23);
            this.oneExclude.TabIndex = 14;
            this.oneExclude.Text = ">";
            this.oneExclude.UseVisualStyleBackColor = true;
            this.oneExclude.Click += new System.EventHandler(this.OneExclude_Click);
            // 
            // excludeLabel
            // 
            this.excludeLabel.AutoSize = true;
            this.excludeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excludeLabel.Location = new System.Drawing.Point(393, 0);
            this.excludeLabel.Name = "excludeLabel";
            this.excludeLabel.Size = new System.Drawing.Size(67, 18);
            this.excludeLabel.TabIndex = 13;
            this.excludeLabel.Text = "Exclude";
            // 
            // excludeListBox
            // 
            this.excludeListBox.FormattingEnabled = true;
            this.excludeListBox.Location = new System.Drawing.Point(398, 21);
            this.excludeListBox.Name = "excludeListBox";
            this.excludeListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.excludeListBox.Size = new System.Drawing.Size(273, 264);
            this.excludeListBox.TabIndex = 12;
            // 
            // includeLabel
            // 
            this.includeLabel.AutoSize = true;
            this.includeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.includeLabel.Location = new System.Drawing.Point(-3, 0);
            this.includeLabel.Name = "includeLabel";
            this.includeLabel.Size = new System.Drawing.Size(61, 18);
            this.includeLabel.TabIndex = 11;
            this.includeLabel.Text = "Include";
            // 
            // includeListBox
            // 
            this.includeListBox.FormattingEnabled = true;
            this.includeListBox.Location = new System.Drawing.Point(0, 21);
            this.includeListBox.Name = "includeListBox";
            this.includeListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.includeListBox.Size = new System.Drawing.Size(273, 264);
            this.includeListBox.TabIndex = 3;
            // 
            // enabledCheckBox
            // 
            this.enabledCheckBox.AutoSize = true;
            this.enabledCheckBox.Location = new System.Drawing.Point(654, 50);
            this.enabledCheckBox.Name = "enabledCheckBox";
            this.enabledCheckBox.Size = new System.Drawing.Size(65, 17);
            this.enabledCheckBox.TabIndex = 18;
            this.enabledCheckBox.Text = "Enabled";
            this.enabledCheckBox.UseVisualStyleBackColor = true;
            this.enabledCheckBox.CheckedChanged += new System.EventHandler(this.EnabledCheckBox_CheckedChanged);
            // 
            // optionsTabPanel
            // 
            this.optionsTabPanel.Controls.Add(this.numberingTabPage);
            this.optionsTabPanel.Controls.Add(this.titleTabPage);
            this.optionsTabPanel.Controls.Add(this.chapterTabPage);
            this.optionsTabPanel.Controls.Add(this.volumeTabPage);
            this.optionsTabPanel.Controls.Add(this.submitTabPage);
            this.optionsTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsTabPanel.Location = new System.Drawing.Point(0, 0);
            this.optionsTabPanel.Name = "optionsTabPanel";
            this.optionsTabPanel.SelectedIndex = 0;
            this.optionsTabPanel.Size = new System.Drawing.Size(784, 451);
            this.optionsTabPanel.TabIndex = 1;
            this.optionsTabPanel.SelectedIndexChanged += new System.EventHandler(this.OptionsTabPanel_SelectedIndexChanged);
            // 
            // numberingTabPage
            // 
            this.numberingTabPage.Controls.Add(this.numberingPanel);
            this.numberingTabPage.Location = new System.Drawing.Point(4, 22);
            this.numberingTabPage.Name = "numberingTabPage";
            this.numberingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.numberingTabPage.Size = new System.Drawing.Size(776, 425);
            this.numberingTabPage.TabIndex = 0;
            this.numberingTabPage.Text = "Numbering";
            // 
            // numberingPanel
            // 
            this.numberingPanel.Controls.Add(this.numberingDigitsLabel);
            this.numberingPanel.Controls.Add(this.numberingDigitsNumericUpDown);
            this.numberingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberingPanel.Location = new System.Drawing.Point(3, 3);
            this.numberingPanel.Name = "numberingPanel";
            this.numberingPanel.Size = new System.Drawing.Size(770, 65);
            this.numberingPanel.TabIndex = 15;
            // 
            // numberingDigitsLabel
            // 
            this.numberingDigitsLabel.AutoSize = true;
            this.numberingDigitsLabel.Location = new System.Drawing.Point(42, 24);
            this.numberingDigitsLabel.Name = "numberingDigitsLabel";
            this.numberingDigitsLabel.Size = new System.Drawing.Size(36, 13);
            this.numberingDigitsLabel.TabIndex = 15;
            this.numberingDigitsLabel.Text = "Digits:";
            // 
            // numberingDigitsNumericUpDown
            // 
            this.numberingDigitsNumericUpDown.Location = new System.Drawing.Point(84, 22);
            this.numberingDigitsNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numberingDigitsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberingDigitsNumericUpDown.Name = "numberingDigitsNumericUpDown";
            this.numberingDigitsNumericUpDown.Size = new System.Drawing.Size(53, 20);
            this.numberingDigitsNumericUpDown.TabIndex = 14;
            this.numberingDigitsNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // titleTabPage
            // 
            this.titleTabPage.Controls.Add(this.titlePanel);
            this.titleTabPage.Location = new System.Drawing.Point(4, 22);
            this.titleTabPage.Name = "titleTabPage";
            this.titleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.titleTabPage.Size = new System.Drawing.Size(776, 425);
            this.titleTabPage.TabIndex = 1;
            this.titleTabPage.Text = "Title";
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleTextBox);
            this.titlePanel.Controls.Add(this.titleTextLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(3, 3);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(770, 65);
            this.titlePanel.TabIndex = 20;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(95, 21);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(158, 20);
            this.titleTextBox.TabIndex = 0;
            // 
            // titleTextLabel
            // 
            this.titleTextLabel.AutoSize = true;
            this.titleTextLabel.Location = new System.Drawing.Point(42, 24);
            this.titleTextLabel.Name = "titleTextLabel";
            this.titleTextLabel.Size = new System.Drawing.Size(27, 13);
            this.titleTextLabel.TabIndex = 16;
            this.titleTextLabel.Text = "Title";
            // 
            // chapterTabPage
            // 
            this.chapterTabPage.Controls.Add(this.chapterPanel);
            this.chapterTabPage.Location = new System.Drawing.Point(4, 22);
            this.chapterTabPage.Name = "chapterTabPage";
            this.chapterTabPage.Size = new System.Drawing.Size(776, 425);
            this.chapterTabPage.TabIndex = 2;
            this.chapterTabPage.Text = "Chapter";
            // 
            // chapterPanel
            // 
            this.chapterPanel.Controls.Add(this.chapterTextBox);
            this.chapterPanel.Controls.Add(this.chapterTextLabel);
            this.chapterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.chapterPanel.Location = new System.Drawing.Point(0, 0);
            this.chapterPanel.Name = "chapterPanel";
            this.chapterPanel.Size = new System.Drawing.Size(776, 65);
            this.chapterPanel.TabIndex = 19;
            // 
            // chapterTextBox
            // 
            this.chapterTextBox.Location = new System.Drawing.Point(95, 21);
            this.chapterTextBox.Name = "chapterTextBox";
            this.chapterTextBox.Size = new System.Drawing.Size(158, 20);
            this.chapterTextBox.TabIndex = 0;
            // 
            // chapterTextLabel
            // 
            this.chapterTextLabel.AutoSize = true;
            this.chapterTextLabel.Location = new System.Drawing.Point(42, 24);
            this.chapterTextLabel.Name = "chapterTextLabel";
            this.chapterTextLabel.Size = new System.Drawing.Size(44, 13);
            this.chapterTextLabel.TabIndex = 16;
            this.chapterTextLabel.Text = "Chapter";
            // 
            // volumeTabPage
            // 
            this.volumeTabPage.Controls.Add(this.volumePanel);
            this.volumeTabPage.Location = new System.Drawing.Point(4, 22);
            this.volumeTabPage.Name = "volumeTabPage";
            this.volumeTabPage.Size = new System.Drawing.Size(776, 425);
            this.volumeTabPage.TabIndex = 3;
            this.volumeTabPage.Text = "Volume";
            // 
            // volumePanel
            // 
            this.volumePanel.Controls.Add(this.volumeTextBox);
            this.volumePanel.Controls.Add(this.volumeTextLabel);
            this.volumePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.volumePanel.Location = new System.Drawing.Point(0, 0);
            this.volumePanel.Name = "volumePanel";
            this.volumePanel.Size = new System.Drawing.Size(776, 65);
            this.volumePanel.TabIndex = 20;
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.Location = new System.Drawing.Point(95, 21);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.Size = new System.Drawing.Size(158, 20);
            this.volumeTextBox.TabIndex = 0;
            // 
            // volumeTextLabel
            // 
            this.volumeTextLabel.AutoSize = true;
            this.volumeTextLabel.Location = new System.Drawing.Point(42, 24);
            this.volumeTextLabel.Name = "volumeTextLabel";
            this.volumeTextLabel.Size = new System.Drawing.Size(42, 13);
            this.volumeTextLabel.TabIndex = 16;
            this.volumeTextLabel.Text = "Volume";
            // 
            // submitTabPage
            // 
            this.submitTabPage.Controls.Add(this.submitPanel);
            this.submitTabPage.Location = new System.Drawing.Point(4, 22);
            this.submitTabPage.Name = "submitTabPage";
            this.submitTabPage.Size = new System.Drawing.Size(776, 425);
            this.submitTabPage.TabIndex = 5;
            this.submitTabPage.Text = "Submit";
            // 
            // submitPanel
            // 
            this.submitPanel.Controls.Add(this.folderButton);
            this.submitPanel.Controls.Add(this.resubmitButton);
            this.submitPanel.Controls.Add(this.submitButton);
            this.submitPanel.Controls.Add(this.issuesListBox);
            this.submitPanel.Controls.Add(this.issuesLabel);
            this.submitPanel.Location = new System.Drawing.Point(23, 19);
            this.submitPanel.Name = "submitPanel";
            this.submitPanel.Size = new System.Drawing.Size(727, 376);
            this.submitPanel.TabIndex = 0;
            // 
            // resubmitButton
            // 
            this.resubmitButton.Enabled = false;
            this.resubmitButton.Location = new System.Drawing.Point(627, 59);
            this.resubmitButton.Name = "resubmitButton";
            this.resubmitButton.Size = new System.Drawing.Size(75, 23);
            this.resubmitButton.TabIndex = 17;
            this.resubmitButton.Text = "Resubmit";
            this.resubmitButton.UseVisualStyleBackColor = true;
            this.resubmitButton.Click += new System.EventHandler(this.ResubmitButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(627, 23);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // issuesListBox
            // 
            this.issuesListBox.FormattingEnabled = true;
            this.issuesListBox.Location = new System.Drawing.Point(26, 37);
            this.issuesListBox.Name = "issuesListBox";
            this.issuesListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.issuesListBox.Size = new System.Drawing.Size(479, 303);
            this.issuesListBox.TabIndex = 15;
            // 
            // issuesLabel
            // 
            this.issuesLabel.AutoSize = true;
            this.issuesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuesLabel.Location = new System.Drawing.Point(23, 14);
            this.issuesLabel.Name = "issuesLabel";
            this.issuesLabel.Size = new System.Drawing.Size(57, 18);
            this.issuesLabel.TabIndex = 14;
            this.issuesLabel.Text = "Issues";
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(627, 174);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(75, 23);
            this.folderButton.TabIndex = 18;
            this.folderButton.Text = "Folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // RenamerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 451);
            this.Controls.Add(this.optionsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RenamerForm";
            this.ShowIcon = false;
            this.Text = "Renamer";
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            this.includeExcludePanel.ResumeLayout(false);
            this.includeExcludePanel.PerformLayout();
            this.optionsTabPanel.ResumeLayout(false);
            this.numberingTabPage.ResumeLayout(false);
            this.numberingPanel.ResumeLayout(false);
            this.numberingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberingDigitsNumericUpDown)).EndInit();
            this.titleTabPage.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.chapterTabPage.ResumeLayout(false);
            this.chapterPanel.ResumeLayout(false);
            this.chapterPanel.PerformLayout();
            this.volumeTabPage.ResumeLayout(false);
            this.volumePanel.ResumeLayout(false);
            this.volumePanel.PerformLayout();
            this.submitTabPage.ResumeLayout(false);
            this.submitPanel.ResumeLayout(false);
            this.submitPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.TabControl optionsTabPanel;
        private System.Windows.Forms.TabPage numberingTabPage;
        private System.Windows.Forms.Panel includeExcludePanel;
        private System.Windows.Forms.TabPage titleTabPage;
        private System.Windows.Forms.Button allInclude;
        private System.Windows.Forms.Button allExclude;
        private System.Windows.Forms.Button oneInclude;
        private System.Windows.Forms.Button oneExclude;
        private System.Windows.Forms.Label excludeLabel;
        private System.Windows.Forms.ListBox excludeListBox;
        private System.Windows.Forms.Label includeLabel;
        private System.Windows.Forms.ListBox includeListBox;
        private System.Windows.Forms.TabPage chapterTabPage;
        private System.Windows.Forms.TabPage volumeTabPage;
        private System.Windows.Forms.CheckBox enabledCheckBox;
        private System.Windows.Forms.Panel numberingPanel;
        private System.Windows.Forms.Label numberingDigitsLabel;
        private System.Windows.Forms.NumericUpDown numberingDigitsNumericUpDown;
        private System.Windows.Forms.Panel volumePanel;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.Label volumeTextLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleTextLabel;
        private System.Windows.Forms.Panel chapterPanel;
        private System.Windows.Forms.TextBox chapterTextBox;
        private System.Windows.Forms.Label chapterTextLabel;
        private System.Windows.Forms.TabPage submitTabPage;
        private System.Windows.Forms.Panel submitPanel;
        private System.Windows.Forms.ListBox issuesListBox;
        private System.Windows.Forms.Label issuesLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button resubmitButton;
        private System.Windows.Forms.Button folderButton;
    }
}