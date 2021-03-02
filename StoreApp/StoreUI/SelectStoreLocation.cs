using System;
using StoreBL;
using StoreModels;
using System.Collections.Generic;

namespace StoreUI
{
    public class SelectStoreLocation : IMenu
    {
        private IstoreBL _repo;
        public List<StoreLocation> StoresFromDB;

        public SelectStoreLocation(IstoreBL repo){
            _repo = repo;
            StoresFromDB = _repo.GetStoreLocation();
        }
        public void Start()
        {
            IMenu menu;
            Boolean runMenu = true;
            Boolean badEntryFlag = true;
            do
            {
                Console.WriteLine($"Enter the name of the shop you are looking to buy from today.\nyour options are:");
                foreach(StoreLocation store in StoresFromDB)
                {
                    Console.WriteLine(store.Name);
                }
                string userInput = Console.ReadLine();
                if (!userInput.Equals(StoresFromDB))
                {
                    Console.WriteLine("Invalid option please try again");
                }
                foreach(StoreLocation store in StoresFromDB)
                {
                    Console.WriteLine(store.Name);
                    if (userInput.Equals(store.Name))
                    {
                        badEntryFlag = false;
                        menu = new CategoryChoiceMenu(store, _repo);
                        menu.Start();
                        break;
                    }
                }

            } while (runMenu);
        }
    }
}