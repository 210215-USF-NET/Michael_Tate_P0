using System;
using StoreModels;
using StoreBL;
using System.Collections.Generic;
namespace StoreUI
{
    public class StartCustomer : IMenu
    {
        IMenu menu;
        private IstoreBL _repo;
        public StartCustomer(IstoreBL repo)
        {
            _repo = repo;
        }
        
        public void Start()
        {
            Boolean runMenu = true;
            do
            {
            Console.WriteLine("Welcome Customer!!!");
            Console.WriteLine("Please select an option below");
            Console.WriteLine("=============================");
            Console.WriteLine("[1] New Customer");
            Console.WriteLine("[2] Existing Customer");
            Console.WriteLine("[3] Go Back");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                CreateCustomer();
                break;
                case "2":
                SearchForCustomer();
                break;
                case "3":
                runMenu = false;
                break;
                default:
                Console.WriteLine("\nThat was not an option try again\n");
                break;
            }
            } while (runMenu);
        }

        

        //create a customer
        public void CreateCustomer()
        {
            _repo.AddCustomer(InputCustomerDetails());
            Console.WriteLine("Customer successfully added");
        }

                //input the details of a customer
        public Customer InputCustomerDetails()
        {
            /// Create customer method\
            Boolean isValid = true;
            Customer newCustomer = new Customer();
            
            //set customers first name/
            Console.WriteLine("Please Enter your first name: ");
            do
            {
                try
                {
                    newCustomer.FirstName = Console.ReadLine();
                    isValid = false;

                }
                catch (Exception)
                {
                    Console.WriteLine("this is a required feald. Please try again:");
                }
            } while (isValid);
            
            //set customers last name
            Console.WriteLine("Please Enter your last name: ");
            do
            {
                try
                {
                    newCustomer.LastName = Console.ReadLine();
                    isValid = false;

                }
                catch (Exception)
                {
                    Console.WriteLine("this is a required feald. Please try again:");
                    isValid = true;
                } 
            } while (isValid);
            
            //set customers phone number (not required)
            Console.WriteLine("Please Enter phone number (Optional): ");
            newCustomer.PhoneNumber = Console.ReadLine();
            
            Console.WriteLine("Please Enter Email: ");
            do
            {
                try
                {
                    newCustomer.Email = Console.ReadLine().ToLower();
                    isValid = false;

                }
                catch (Exception)
                {
                    Console.WriteLine("this is a required feald. Please try again:");
                    isValid = true;
                }
            } while (isValid);

            return newCustomer;
        }

        public void SearchForCustomer()
        {
            Console.WriteLine("Customers email address: ");
            string email = Console.ReadLine().ToLower();
            Customer locatedCustomer = _repo.GetCustomerByEmail(email);
            if (locatedCustomer == null)
            {
                Console.WriteLine("No such Customer found.");
            }
            else
            {
                Console.WriteLine($"Customer found, hello {locatedCustomer.FirstName}");
                menu = new StartOrder(_repo, locatedCustomer);
                menu.Start();
            }
        }
    }
}