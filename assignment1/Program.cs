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

            while (choiceInt != 0)
            {
                bool error = false;
                ui.DisplayMenu();
                try
                {
                    choiceInt = Convert.ToInt32(ui.ReadLine());

                }
                catch
                {
                    ui.InvalidEntry();
                    error = true;
                }

                if (!error)
                {
                    switch (choiceInt)
                    {
                        case 1: //Load the file
                            if (csvp.Loaded)
                                ui.FilesAlreadyLoaded();
                            else
                            {
                                csvp.LoadFiles();
                                ui.FilesLoaded();
                            }
                            break;

                        case 2: //Display all files
                            if (csvp.Loaded)
                                ui.DisplayFiles();
                            else
                                ui.FilesNotLoaded();
                            break;

                        case 3: //Find item by id
                            if (csvp.Loaded)
                            {
                                ui.ItemSearchMessage();
                                idString = ui.ReadLine();
                                ui.ItemSearchResult(WIC.FindItem(idString));
                            }
                            else
                                ui.FilesNotLoaded();
                            break;

                        case 4: //Add item
                            if (csvp.Loaded)
                            {
                                WineItem temp = new WineItem(ui.NewItemId(), ui.NewItemDescription(), ui.NewItemPack());

                                WIC.AddItem(temp);


                            }
                            else
                                ui.FilesNotLoaded();
                            break;

                        default:
                            ui.AnotherNumber();
                            break;
                    }
                }
            }

        }
    }
}
