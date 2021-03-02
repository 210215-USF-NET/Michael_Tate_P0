using System;
using StoreModels;
using StoreBL;
using System.Collections.Generic;

namespace StoreUI
{
    public class StartMenu : IMenu
    {
        private IstoreBL _customerBL;
        public StartMenu(IstoreBL customerBL)
        {
            _customerBL = customerBL;
        }
        public void Start()
        {
            IMenu startNewMenu;

            Console.WriteLine("Welcome to the Pie Shop");
            Console.WriteLine("Please make a selection below:");
            Console.WriteLine("[1] Customer Oprions");
            Console.WriteLine("[2] Manager options");
            Console.WriteLine("[3] Exit Application");

            string managerPassword;
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":

                break;
                case "2":

                break;
                case "3":
                Console.WriteLine("Please enter the Password (Psss its Passw0rd!)");
                managerPassword = Console.ReadLine();
                if (managerPassword.Equals("Passw0rd!"))
                {
                    ManagerMenu newManager = new ManagerMenu();
                    newManager.Start();
                }
                else
                {
                    Console.WriteLine("ERROR WRONG PASSWORD!!!");
                }
                break;
                default:
                break;
            }
        }


        //end the program
        private void GoodBuy()
        {
            Console.WriteLine("Thank you for shopping with us. Goodbye");
        }

    }
}