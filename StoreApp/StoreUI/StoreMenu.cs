using System;
using StoreModels;
using StoreBL;

namespace StoreUI
{
    public class StoreMenu : IMenu
    {
        private ICustomerBL _customerBL;
        public StoreMenu(ICustomerBL customerBL)
        {
            _customerBL = customerBL;
        }
        public void Start()
        {
            Boolean stay = true;
            do
            {
                Console.WriteLine("Welcome to our store, please select an option below");
                Console.WriteLine("[1] Creaste a new order.");
                Console.WriteLine("[2] Manager Shit.");
                Console.WriteLine("[3] Search for customer.");
                Console.WriteLine("[4] Create an order.");
                Console.WriteLine("[5] Exit the store.");

                Console.WriteLine("Enter a number: ");
                string userInput = Console.ReadLine();
            
            switch (userInput)
            {
                case "1":
                CreateCustomer();
                break;
                
                case "2":
                //Create an order
                CreateOrder();
                break;

                case "3":
                //search customer
                break;

                case "4":
                //manager access
                break;

                case "5":
                GoodBuy();
                stay = false;
                break;
                
                default:
                    Console.WriteLine("\nThat was not an option try again\n");
                break;
            }
            }while (stay);
        }

        

        public void CreateCustomer()
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
            

            _customerBL.AddCustomer(newCustomer);
            Console.WriteLine("Customer successfully added");
        }
        public void CreateOrder()
        {
            
        }
        //exit the program
        private void GoodBuy()
        {
            Console.WriteLine("Thank you for shopping with us. Goodbye");
        }
    }
    
}