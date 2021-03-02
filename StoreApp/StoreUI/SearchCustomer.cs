using System;
using StoreModels;
using StoreBL;
using System.Collections.Generic;
namespace StoreUI
{
    public class SearchCustomer : IMenu
    {
        private IstoreBL _customerBL;
        public SearchCustomer(IstoreBL customerBL)
        {
            _customerBL = customerBL;
        }
        
        public void Start()
        {
            Console.WriteLine("Welcome Customer!!!");
            Console.WriteLine("Please select an option below");
            Console.WriteLine("=============================");
            Console.WriteLine("[1] New Customer");
            Console.WriteLine("[2] Existing Customer");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                CreateCustomer();
                break;
                case "2":
                SearchForCustomer();
                break;
                default:
                break;
            }
            
        }

        //get all customer
        // private void GetCustomer()
        // {
        //     foreach (var item in _customerBL.GetCustomer())
        //     {
        //         Console.WriteLine(item.ToString());
        //     }
        //     Console.WriteLine("Press any key to continue");
        //     Console.ReadLine();
        // }

        //create a customer
        public void CreateCustomer()
        {
            _customerBL.AddCustomer(InputCustomerDetails());
            Console.WriteLine("Customer successfully added");
        }

                //input the details of a customer
        public Customer InputCustomerDetails()
        {
            /// Create customer method\
            Boolean isValid = true;
            Customer newCustomer = new Customer();
            
            //set customers first name
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
                    newCustomer.Email = Console.ReadLine();
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
            Customer locatedCustomer = _customerBL.GetCustomerByEmail(Console.ReadLine());
            if (locatedCustomer == null)
            {
                Console.WriteLine("No such Customer found.");
            }
            else
            {
                Console.WriteLine($"Customer found {locatedCustomer.FirstName}");
            }
        }
    }
}