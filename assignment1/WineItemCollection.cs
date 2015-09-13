using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        private static int length;
        private static WineItem[] wineItems = new WineItem[4000];

        public WineItem this[int index]
        {
            get { return wineItems[index]; }
            set { wineItems[index] = value; }
        }

        public int Length 
        {
            get { return length; }
            set { length = value; }
        }

        public void FindItem(string itemId)
        {
            int counter = 0;


        }
    }
}
