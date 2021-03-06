﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        WineItemCollection WIC = new WineItemCollection();

        public void DisplayMenu()   //The menu
        {
            Console.WriteLine("0 to exit the program");
            Console.WriteLine("1 to load the file");
            Console.WriteLine("2 to display all the file entries");
            Console.WriteLine("3 to find an item by id");
            Console.WriteLine("4 to add an item");
            Console.Write("Enter your choice: ");
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        //****************
        //Display messages
        //****************
        public void InvalidEntry()
        {
            Console.WriteLine("");
            Console.WriteLine("Your choice is invalid, please enter a number");
            Console.WriteLine("");
        }

        public void FilesLoaded()
        {
            Console.WriteLine("");
            Console.WriteLine("The file has been loaded");
            Console.WriteLine("");
        }

        public void FilesAlreadyLoaded()
        {
            Console.WriteLine("");
            Console.WriteLine("The file cannot be loaded a second time");
            Console.WriteLine("");
        }

        public void AnotherNumber()
        {
            Console.WriteLine("");
            Console.WriteLine("Your choice is invalid, please enter another number");
            Console.WriteLine("");
        }

        public void DisplayFiles()
        {
            int counter = 0;
            Console.WriteLine("");
            while (WIC.Length > counter)
            {
                Console.WriteLine(WIC[counter].ToString());
                counter++;
            }
            Console.WriteLine("");
            Console.WriteLine("The file has not yet been loaded");
            Console.WriteLine("");
        }

        public void FilesNotLoaded()
        {
            Console.WriteLine("");
            Console.WriteLine("The file is not loaded yet");
            Console.WriteLine("");
        }

        public void ItemSearchMessage()
        {
            Console.Write("Enter the item's id: ");
        }

        public void ItemSearchResult(string result)
        {
            Console.WriteLine("");
            Console.WriteLine(result);
            Console.WriteLine("");
        }

        public string NewItemId()
        {
            Console.WriteLine("");
            Console.Write("Enter the new item's id: ");
            return Console.ReadLine();
        }

        public string NewItemDescription()
        {
            Console.WriteLine("");
            Console.Write("Enter the new item's description: ");
            return Console.ReadLine();
        }

        public string NewItemPack()
        {
            Console.WriteLine("");
            Console.Write("Enter the new item's pack: ");
            return Console.ReadLine();
        }

        public void FileAdded()
        {
            Console.WriteLine("");
            Console.WriteLine("The file has been added");
            Console.WriteLine("");
        }

        public void DisplayText(string T)
        {
            Console.WriteLine("");
            Console.WriteLine(T);
            Console.WriteLine("");
        }
    }
}
