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

        public string FindItem(string itemId)   //Find the item
        {
            bool itemFound = false;
            int counter = 0;

            while (itemFound == false && counter < wineItems.Length)
            {
                if (wineItems[counter] != null)
                {
                    if (wineItems[counter].Id == itemId)
                    {
                        itemFound = true;
                    }
                }
                counter++;
            }

            if (itemFound)
            {
                return wineItems[counter - 1].ToString();
            }
            return "The item was not found";
        }

        public string AddItem(WineItem wi)  //Add an item
        {
            bool itemAdded = false;
            int counter = 0;

            while (itemAdded == false)
            {
                if (wineItems[counter] != null && wi.Id == wineItems[counter].Id)
                {
                    return "The item id is already in use. Please choose another id";
                }
                else if (wineItems[counter] == null)
                {
                    wineItems[counter] = wi;
                    itemAdded = true;
                    this.Length++;
                    return "The item has been added";
                }
                counter++;
            }

            return "There has been an error in the AddItem method";
        }
    }
}
