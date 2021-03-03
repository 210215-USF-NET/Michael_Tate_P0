using System;
using StoreBL;
using StoreModels;
using System.Collections.Generic;
namespace StoreUI
{
    public class ManagerMenu : IMenu
    {
        private IstoreBL _repo;
        List<StoreLocation> location;
        List<Product> product;
        public ManagerMenu(IstoreBL repo)
        {
            _repo = repo;
            product = _repo.GetProduct();
            location = _repo.GetStoreLocation();
        }
        public void Start()
        {
            Boolean runMenu = true;
            do
            {
                Console.WriteLine("Hey Boss hows it going");
                Console.WriteLine("Please select an option below");
                Console.WriteLine("=============================");
                Console.WriteLine("[1] Check Inventory");
                Console.WriteLine("[2] Existing Customer");
                Console.WriteLine("[3] Go Back");

                //will add more as i go
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        CheckInventory();
                    break;
                    case "2":
                        Restock();
                    break;
                    case "3":
                        runMenu = false;
                    break;
                    default:
                    Console.WriteLine("\nCome on boss what are you doing...\nLets try this again.");
                    break;
                }

            } while (runMenu);
        }

        private void CheckInventory()
        {
            foreach (var item in product)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        public void Restock()
        {
            
        }
    }
}