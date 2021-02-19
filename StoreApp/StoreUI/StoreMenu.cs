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
            //// Create customer method
            Customer newCustomer = new Customer();
            Console.WriteLine("Please Enter your first name: ");
            newCustomer.FirstName = Console.ReadLine();
            Console.WriteLine("Please Enter your last name: ");
            newCustomer.LastName = Console.ReadLine();
            Console.WriteLine("Please Enter phone number (Optional): ");
            newCustomer.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Please Enter Email: ");
            newCustomer.Email = Console.ReadLine();

            Location newCustLocarion = new Location();
            Console.WriteLine("Please Enter your state of residence: ");
            newCustLocarion.StateName = Console.ReadLine();
            Console.WriteLine("Please Enter city name: ");
            newCustLocarion.CityName = Console.ReadLine();
            Console.WriteLine("Please Enter your address: ");
            newCustLocarion.Address = Console.ReadLine();
            Console.WriteLine("Please Enter your zip code: ");
            newCustLocarion.Zip = int.Parse(Console.ReadLine());

        }
        private void GoodBuy()
        {
            Console.WriteLine("Thank you for shopping with us. Goodbye");
        }
    }
}