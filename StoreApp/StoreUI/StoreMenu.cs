using System;
using StoreModels;

namespace StoreUI
{
    public class StoreMenu : IMenu
    {
        public void Start()
        {
            Boolean stay = true;
            do
            {
                Console.WriteLine("Welcome to our store, please select an option below");
                Console.WriteLine("[1] Creaste a new order.");
                Console.WriteLine("[2] Manager Shit.");
                Console.WriteLine("[3] Exit the store.");

                Console.WriteLine("Enter a number: ");
                string userInput = Console.ReadLine();
            
            switch (userInput)
            {
                case "1":
                CreateCustomer();
                break;
                
                case "2":
                //manager access
                break;

                case "3":
                stay = false;
                GoodBuy();
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
            Boolean isValid;
            Customer newCustomer = new Customer();
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
                    isValid = true;
                }
            } while (isValid);
            
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

            Location newCustLocarion = new Location();
            
            Console.WriteLine("Please Enter your state of residence: ");
            do
            {
                try
                {
                    newCustLocarion.StateName = Console.ReadLine();
                    isValid = false;

                }
                catch (Exception)
                {
                    Console.WriteLine("this is a required feald. Please try again:");
                    isValid = true;
                }
            } while (isValid);
            
            Console.WriteLine("Please Enter city name: ");
            do
            {
                try
                {
                    newCustLocarion.CityName = Console.ReadLine();
                    isValid = false;

                }
                catch (Exception)
                {
                    Console.WriteLine("this is a required feald. Please try again:");
                    isValid = true;
                }
            } while (isValid);
            
            Console.WriteLine("Please Enter your address: ");
            do
            {
                try
                {
                    newCustLocarion.Address = Console.ReadLine();
                    isValid = false;

                }
                catch (Exception)
                {
                    Console.WriteLine("this is a required feald. Please try again:");
                    isValid = true;
                }
            } while (isValid);
            
            Console.WriteLine("Please Enter your zip code: ");
            do
            {
                try
                {
                    newCustLocarion.Zip = int.Parse(Console.ReadLine());
                    isValid = false;

                }
                catch (Exception)
                {
                    Console.WriteLine("this is a required feald. Please try again:");
                    isValid = true;
                }
            } while (isValid);
            
            Console.WriteLine($"Customer Details: \n\t name: {newCustomer.FirstName} {newCustomer.LastName} \n\t phone number: {newCustomer.PhoneNumber} \n\t email: {newCustomer.Email}");

        }
        private void GoodBuy()
        {
            Console.WriteLine("Thank you for shopping with us. Goodbye");
        }
    }
}