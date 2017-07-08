using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaRenamer.Objects
{
    public class PropertyTag
    {

        public PropertyTag()
        {

        }

        public PropertyTag(string name, int id, int type)
        {
            this.Name = name;
            this.ID = id;
            this.Type = type;

            if (this.Type == 1)
            {
                this.Encoding = Encoding.Unicode;
            }
            else if (this.Type == 2)
            {
                this.Encoding = Encoding.UTF8;
            }
        }

        public string Name { get; set; }

        public int ID { get; set; }

        public int Type { get; set; }

        public Encoding Encoding { get; set; }

    }
}
