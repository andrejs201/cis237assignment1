using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choiceInt = 1;
            string idString;
            UserInterface ui = new UserInterface();
            CSVProcessor csvp = new CSVProcessor();
            WineItemCollection WIC = new WineItemCollection();
            WineItem wineItem;

            while (choiceInt != 0)
            {
                ui.DisplayMenu();
                try
                {
                    choiceInt = Convert.ToInt32(ui.ReadLine());
                    switch (choiceInt)
                    {
                        case 1:
                            if (csvp.Loaded)
                            {
                                ui.FilesAlreadyLoaded();
                            }
                            else
                            {
                                csvp.LoadFiles();
                                ui.FilesLoaded();
                            }
                            break;

                        case 2:
                            int check = csvp.CheckIfLoaded();
                            if (check == 0)
                                ui.DisplayFiles();
                            break;

                        case 3:
                            idString = ui.ReadLine();

                            break;

                        default:
                            ui.AnotherNumber();
                            break;
                    }
                }
                catch
                    {
                        ui.InvalidEntry();
                    }
            }

        }
    }
}
