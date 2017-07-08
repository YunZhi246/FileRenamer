using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangaRenamer
{
    /*
     * Title
     *  0x9C9B
     *  Type: 1
     *  
     * Subject
     *  0x9C9F
     *  Type: 1
     * 
     * Tags
     *  0x9C9E
     *  Type: 1
     * 
     * Comments
     *  0x9C9C
     *  Type: 1



    */

    public class Program
    {
        public static int titleID = 0x9C9B;
        public static int chapterID = 0x9C9F;
        public static int volumeID = 0x9C9E;

        [STAThreadAttribute]
        static void Main(string[] args)
        {


        //    FolderBrowserDialog chooseFolder = new FolderBrowserDialog();
        //    chooseFolder.ShowNewFolderButton = false;
        //    chooseFolder.RootFolder = Environment.SpecialFolder.MyComputer;
        //    chooseFolder.SelectedPath = @"Z:\new";
        //    chooseFolder.ShowDialog();

        //    string[] files = Directory.GetFiles(chooseFolder.SelectedPath, "*.jpg");
        //    FileInfo info = new FileInfo(files[0]);
        ////    changeTitle(files[0], chooseFolder.SelectedPath);
            

            RenamerForm form = new RenamerForm();
            form.ShowDialog();


        }


        public static void Renumbering(RenamerForm form, SortedList<string, string> files, int digitNum)
        {
            SortedList<string, string> issues = new SortedList<string, string>();
            SortedList<string, string> delete = new SortedList<string, string>();
            SortedList<string, string> newFiles = new SortedList<string, string>();
            List<int> fileNums = new List<int>();

            foreach (KeyValuePair<string, string> file in files)
            {
                string fileName = file.Key.Substring(0, file.Key.LastIndexOf('.'));
                int fileNum = 0;
                bool isNum = Int32.TryParse(fileName, out fileNum);
                if (!isNum)
                {
                    issues.Add(file.Key, file.Value);
                }
                else if (fileName.Length > digitNum)
                {
                    issues.Add(file.Key, file.Value);
                }
                else if(fileName.Length == digitNum)
                {
                    if (fileNums.Contains(fileNum))
                    {
                        issues.Add(file.Key, file.Value);
                    }
                    else
                    {
                        fileNums.Add(fileNum);
                    }
                }
                else if(fileName.Length < digitNum)
                {
                    if (fileNums.Contains(fileNum))
                    {
                        issues.Add(file.Key, file.Value);
                    }
                    else
                    {
                        string newFileName = fileNum.ToString().PadLeft(digitNum, '0');
                        newFileName += ".jpg";

                        string newFilePath = file.Value.Substring(0, file.Value.LastIndexOf(@"\") + 1);
                        newFilePath += newFileName;

                        using (Image image = new Bitmap(file.Value))
                        {
                            image.Save(newFilePath, ImageFormat.Jpeg);
                        }

                        delete.Add(file.Key, file.Value);
                        newFiles.Add(newFileName, newFilePath);
                        fileNums.Add(fileNum);
                    }
                }                         
            }

            form.RenumIssues = issues;
            foreach(KeyValuePair<string, string> del in delete)
            {
                form.DeleteFiles.Add(del.Key, del.Value);
            }

            foreach(KeyValuePair<string, string> file in newFiles)
            {
                form.NewFiles.Add(file.Key, file.Value);
            }
        }

        public static void SetTitle(RenamerForm form, SortedList<string, string> files, string title)
        {
            SortedList<string, string> issues = new SortedList<string, string>();

            foreach(KeyValuePair<string, string> file in files)
            {
                bool isSet = ImageSetProperty(file.Value, form.Directory, titleID, 1, title);
                if (!isSet)
                {
                    issues.Add(file.Key, file.Value);
                }                                    
            }

            form.TitleIssues = issues;
        }
              

        public static bool ImageSetProperty(string filePath, string directory, int propID, short propType, string propertyValue)
        {
            try
            {
                string tempPath = directory + "\\temp43210.jpg";
                using (Image image = new Bitmap(filePath))
                {
                    PropertyItem[] propItems = image.PropertyItems;
                    int[] propItemIdList = image.PropertyIdList;

                    if (propItemIdList.Contains<int>(propID))
                    {
                        PropertyItem itemTitle = image.GetPropertyItem(propID);
                        itemTitle.Value = Encoding.Unicode.GetBytes(propertyValue + '\0');
                        itemTitle.Len = itemTitle.Value.Length;
                        image.SetPropertyItem(itemTitle);
                    }
                    else
                    {
                        var newItem = (PropertyItem)FormatterServices.GetUninitializedObject(typeof(PropertyItem));
                        PropertyItem propItem = (PropertyItem)newItem;
                        propItem.Id = propID;
                        propItem.Type = propType;
                        propItem.Value = Encoding.Unicode.GetBytes(propertyValue + '\0');
                        propItem.Len = propItem.Value.Length;
                        image.SetPropertyItem(propItem);
                    }

                    image.Save(tempPath, ImageFormat.Jpeg);
                }

                File.Delete(filePath);
                using(Image image = new Bitmap(tempPath))
                {
                    image.Save(filePath, ImageFormat.Jpeg);
                }

                File.Delete(tempPath);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }                                              
        }


        private static void renameDelete(string[] files)
        {
            using (Image image = new Bitmap(files[0]))
            {

                string newFilePath = $"Z:\\new\\hi.jpg";

                /*
                PropertyItem[] propItems = image.PropertyItems;
                int[] propItemIdList = image.PropertyIdList;
                int itemTitleId = 0x9C9B;

                foreach (int id in propItemIdList)
                {
                    PropertyItem item = image.GetPropertyItem(id);
                    byte[] val = item.Value;
                    char[] cars = Encoding.Unicode.GetChars(val);
                    string hi = cars.ToString();
                }


                if (propItemIdList.Contains<int>(itemTitleId))
                {
                    PropertyItem itemTitle = image.GetPropertyItem(itemTitleId);
                    itemTitle.Value = Encoding.Unicode.GetBytes("title" + '\0');
                    itemTitle.Len = itemTitle.Value.Length;
                    image.SetPropertyItem(itemTitle);
                }
                else
                {
                    var newItem = (PropertyItem)FormatterServices.GetUninitializedObject(typeof(PropertyItem));
                    PropertyItem propItem = (PropertyItem)newItem;
                    propItem.Id = itemTitleId;
                    propItem.Type = 1;
                    propItem.Value = Encoding.Unicode.GetBytes("title" + '\0');
                    propItem.Len = propItem.Value.Length;
                    image.SetPropertyItem(propItem);

                }
                */

                image.Save(newFilePath, ImageFormat.Jpeg);
            }
            File.Delete(files[0]);
        }


        //private static void rename(string[] files, string selectedPath)
        //{
        //    List<string> fileNames = new List<string>();
        //    foreach (string filePath in files)
        //    {
        //        int lastIndex = filePath.LastIndexOf(@"\");
        //        fileNames.Add(filePath.Substring(lastIndex + 1));
        //    }

        //    List<string> toDelete = new List<string>();
        //    RenamerForm form = new RenamerForm(fileNames, selectedPath);
        //    form.ShowDialog();

        //    if (form.DialogResult == DialogResult.OK)
        //    {
        //        List<string> inValidName = new List<string>();

        //        Directory.CreateDirectory(selectedPath + "\\new");

        //        foreach (string filePath in files)
        //        {
        //            int lastIndex = filePath.LastIndexOf(@"\");
        //            string path = filePath.Substring(0, lastIndex + 1);
        //            string name = filePath.Substring(lastIndex + 1);
        //            string noEnding = name.Substring(0, name.LastIndexOf('.'));
        //            int intName = 0;
        //            bool isNum = Int32.TryParse(noEnding, out intName);
        //            if (isNum && intName < 10 && noEnding != $"0{intName}")
        //            {
        //                string newFilePath = $"{path}\\new\\0{intName}.jpg";
        //                Image image = new Bitmap(filePath);
        //                toDelete.Add(filePath);
        //                image.Save(newFilePath, ImageFormat.Jpeg);
        //            }
        //            else if (isNum)
        //            {
        //                string newFilePath = $"{path}\\new\\{noEnding}.jpg";
        //                Image image = new Bitmap(filePath);
        //                toDelete.Add(filePath);
        //                image.Save(newFilePath, ImageFormat.Jpeg);
        //            }
        //            else if (!isNum)
        //            {
        //                inValidName.Add(name);
        //            }
        //        }
        //        RenamerForm form2 = new RenamerForm(inValidName, selectedPath);
        //        form2.ShowDialog();
        //    }

        //    changeTitle(@"Z:\\2.jpg", @"Z:\\");

        //    foreach (string path in toDelete)
        //    {
        //        //        File.Delete(path);
        //    }
        //}

        private static void changeTitle(string file, string path)
        {

            ////https://msdn.microsoft.com/en-us/library/vs/alm/ms534416(v=vs.85).aspx


            string tempPath = path + "\\temp43210.jpg";

            using (Image image = new Bitmap(file))
            {
                image.Tag = "chapter";
                PropertyItem[] propItems = image.PropertyItems;
                int[] propItemIdList = image.PropertyIdList;
                int itemTitleId = 0x9C9B;

                foreach (int id in propItemIdList)
                {
                    PropertyItem item = image.GetPropertyItem(id);
                    byte[] val = item.Value;
                    char[] cars = Encoding.Unicode.GetChars(val);
                    string hi = cars.ToString();
                }


                if (propItemIdList.Contains<int>(itemTitleId))
                {
                    PropertyItem itemTitle = image.GetPropertyItem(itemTitleId);
                    itemTitle.Value = Encoding.Unicode.GetBytes("hi" + '\0');
                    itemTitle.Len = itemTitle.Value.Length;
                    image.SetPropertyItem(itemTitle);
                }
                else
                {
                    var newItem = (PropertyItem)FormatterServices.GetUninitializedObject(typeof(PropertyItem));
                    PropertyItem propItem = (PropertyItem)newItem;
                    propItem.Id = itemTitleId;
                    propItem.Type = 1;
                    propItem.Value = Encoding.Unicode.GetBytes("hi" + '\0');
                    propItem.Len = propItem.Value.Length;
                    image.SetPropertyItem(propItem);


                }
                image.Save(tempPath, ImageFormat.Jpeg);
            }

            File.Delete(file);

            using(Image image = new Bitmap(tempPath))
            {
                image.Save(file, ImageFormat.Jpeg);
            }


                //    image.Save(files[0]);


                /*
                 * WCHAR* propertyTypes[] = {
                L"Nothing",                   // 0
                L"PropertyTagTypeByte",       // 1  Unicode
                L"PropertyTagTypeASCII",      // 2  UTF8
                L"PropertyTagTypeShort",      // 3
                L"PropertyTagTypeLong",       // 4
                L"PropertyTagTypeRational",   // 5
                L"Nothing",                   // 6
                L"PropertyTagTypeUndefined",  // 7
                L"Nothing",                   // 8
                L"PropertyTagTypeSLONG",      // 9
                L"PropertyTagTypeSRational"}; // 10

                    */

            }
    }
}
