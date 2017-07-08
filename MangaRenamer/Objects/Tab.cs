using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaRenamer.Objects
{
    using System.Windows.Forms;

    public class Tab
    {
        public Tab(string name, PropertyTag tag, TabPage page, SortedList<string, string> namelist, Panel panel)
        {
            this.Name = name;
            this.Property = tag;
            this.Page = page;
            this.Enabled = false;
            this.IncludedFiles = new SortedList<string, string>();
            foreach(KeyValuePair<string, string> n in namelist)
            {
                this.IncludedFiles.Add(n.Key, n.Value);
            }


            this.ExcludedFiles = new SortedList<string, string>();       
            this.Panel = panel;
        }

        public string Name { get; set; }

        public PropertyTag Property { get; set; }

        public TabPage Page { get; set; }

        public bool Enabled { get; set; }
        
        public SortedList<string, string> IncludedFiles { get; set; }

        public SortedList<string, string> ExcludedFiles { get; set; } 

        public Panel Panel { get; set; }
    }

    public class CustomAttribute
    {
        public CustomAttribute(string name, bool isInt, object value)
        {
            this.Name = name;
            this.IsInt = isInt;
            this.Value = value;
        }

        public string Name { get; set; }

        public bool IsInt { get; set; }

        public object Value { get; set; }
    }
}
