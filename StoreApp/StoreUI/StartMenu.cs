using System;
using StoreModels;
using StoreBL;
using System.Collections.Generic;
using Serilog;
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
            Log.Logger = new LoggerConfiguration().WriteTo.File("../SystemLog.json").CreateLogger();
            do
            {
            Console.Clear();
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
                    Log.Error("Invalid password was entered");
                    Console.WriteLine("ERROR WRONG PASSWORD!!! Press Enter to Continue");
                    Console.ReadLine();
                }
                break;
                case "3":
                Console.WriteLine($"We are sad to see you leave :(\nplease come again soon!!");
                runMenu = false;
                break;
                default:
                Log.Error("Invalid option was chosen(Client did not choose 'Customer Oprions', 'Manager options', or 'Exit Application' )");
                Console.WriteLine("\nThat was not an option try again\nPlease press enter to continue");
                Console.ReadLine();

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