using System;
using StoreModels;
using StoreBL;
using System.Collections.Generic;

namespace StoreUI
{
    public class StartMenu : IMenu
    {
        private IstoreBL _repo;
        public StartMenu(IstoreBL repo)
        {
            _repo = repo;
        }
        public void Start()
        {
            Boolean runMenu = true;
            string managerPassword;
            
            do
            {
            Console.WriteLine("Welcome to the Pie Shop!");
            Console.WriteLine("Please make a selection below:");
            Console.WriteLine("[1] Customer Oprions");
            Console.WriteLine("[2] Manager options");
            Console.WriteLine("[3] Exit Application");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                StartCustomer newSearch = new StartCustomer(_repo);
                newSearch.Start();
                break;
                case "2":
                Console.WriteLine("Please enter the Password (Psss its Passw0rd!)");
                managerPassword = Console.ReadLine();
                if (managerPassword.Equals("Passw0rd!"))
                {
                    ManagerMenu newManager = new ManagerMenu(_repo);
                    newManager.Start();
                }
                else
                {
                    Console.WriteLine("ERROR WRONG PASSWORD!!!");
                }
                break;
                case "3":
                Console.WriteLine($"We are sad to see you leave :(\nplease come again soon!!");
                runMenu = false;
                break;
                default:
                Console.WriteLine("\nThat was not an option try again\n");
                break;
            }
            } while (runMenu);
        }


        //end the program
        private void GoodBuy()
        {
            Console.WriteLine("Thank you for shopping with us. Goodbye");
        }

    }
}