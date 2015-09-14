using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcessor
    {
        private bool loaded = false;
        StreamReader reader;
        WineItemCollection WIC = new WineItemCollection();
        WineItem tempWine;

        public bool Loaded
        {
            get { return loaded; }
        }

        public void LoadFiles()
        {
            reader = File.OpenText("../../../datafiles/WineList.csv");
            int counter = 0;

            while (!reader.EndOfStream)
            {
                var fields = reader.ReadLine().Split(',');
                tempWine = new WineItem(fields[0], fields[1], fields[2]);
                WIC[counter] = tempWine;
                counter++;
            }
            reader.Close();
            WIC.Length = counter;
            loaded = true;
        }
    }
}
