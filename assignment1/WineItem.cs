using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        string id;
        string description;
        string pack;

        public WineItem()
        { }

        public WineItem(string id, string description, string pack)
        {
            this.id = id;
            this.description = description;
            this.pack = pack;
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.Description = value; }
        }

        public string Pack
        {
            get { return this.pack; }
            set { this.Pack = value; }
        }

        public override string ToString()
        {
            string temp = this.id + " " + this.description + " " + this.pack;
            return temp;
        }
        
    }
}
