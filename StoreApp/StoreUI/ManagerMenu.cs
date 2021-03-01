using System;
using StoreBL;
using StoreModels;
using System.Collections.Generic;
namespace StoreUI
{
    public class ManagerMenu : IMenu
    {
        public void Start()
        {
            do
            {
                Console.WriteLine("Greetings manager please select an option below.");
                Console.WriteLine("[1] Restock Inventory.");
                Console.WriteLine("[2] Exit Manager Menu.");

                //will add more as i go
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Restock();
                    break;
                    case "2":
                        GoodBuy();
                    break;
                    default:
                    break;
                }

            } while (true);
        }

        public void Restock()
        {

        }


        private void GoodBuy()
        {
            //Console.WriteLine("See ya later boss!");
            //IMenu menu = new StoreMenu(new CustomerBL(new CustomerRepoDB(context, new CustomerMapper())));
            //menu.Start();
        }
    }
}