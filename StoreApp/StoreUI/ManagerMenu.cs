using System;
using StoreBL;
using StoreModels;
using System.Collections.Generic;
using Serilog;
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
                Console.Clear();
                Console.WriteLine("Hey Boss hows it going");
                Console.WriteLine("Please select an option below");
                Console.WriteLine("=============================");
                Console.WriteLine("[1] Check Inventory/Replenish Inventory");
                Console.WriteLine("[2] Check all Customers");
                //Console.WriteLine("[3] Update a Customer");
                //Console.WriteLine("[4] Delete a Customer");
                Console.WriteLine("[5] Go Back");

                //will add more as i go
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Inventory();
                    break;
                    case "2":
                        GetAllCustomer();
                    break;
                    case "3":
                        updateCustomer();
                    break;
                    case "4":
                        DeleteCustomer();
                    break;
                    case "5":
                        runMenu = false;
                    break;
                    default:
                    Console.WriteLine("\nCome on boss what are you doing...\nLets try this again.");
                    break;
                }

            } while (runMenu);
        }

        private void updateCustomer()
        {
            Console.WriteLine("Enter the email of the customer you wish to update: ");
            string email = Console.ReadLine().ToLower();
            Customer locatedCustomer = _repo.GetCustomerByEmail(email);
            if (locatedCustomer == null)
            {
                Console.WriteLine("That customer does not exist");
            }
            else
            {
                //ask the end user for the details they wanna change
                _repo.UpdateCustomer(locatedCustomer, InputCustomerDetails());
                Console.WriteLine("Customer has been sucessfully updated.");
            }
        }

        private void Inventory()
        {
            Boolean runMenu = true;
            do
            {
            Console.Clear();
            Console.WriteLine("Please select an option below");
            Console.WriteLine("=============================");
            Console.WriteLine("[1] Replenish Inventory");
            Console.WriteLine("[2] Check Inventory");
            Console.WriteLine("[3] Go Back");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                ReplenishInventory();
                break;
                case "2":
                foreach (var item in product)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
                break;
                case "3":
                runMenu = false;
                break;
                default:

                break;
            }
            } while (runMenu);
            
        }

        private Product ReplenishInventory()
        {
            Product newInventory;
            int newLocationID=0;
            Console.WriteLine("Enter Location you'd like to update:");
            string userInput = Console.ReadLine();
            int productUserInput = 0;
            foreach(StoreLocation l in _repo.GetStoreLocation())
            {
                if (l.Name.Equals(userInput))
                {
                    newLocationID = l.Id;

                    Console.WriteLine("Enter Product ID you'd like to update:");
                    userInput = Console.ReadLine();

                    foreach(Product inv in _repo.GetProduct())
                    {
                        if(inv.Id.Equals(newLocationID) && inv.ProductName.Equals(_repo.GetProductByName(productUserInput).Id))
                        {
                            newInventory = inv;
                            Console.WriteLine("Enter the updated Stock Quantity:");
                            userInput = Console.ReadLine();
                            newInventory.PieCount = int.Parse(userInput);
                            _repo.UpdateInventory(inv);
                            return inv;
                        }
                    }
                    Log.Error("Invalid product selection - Manager Menu - Update Inventory");
                    throw new Exception();
                }
            }
            Log.Error("Invalid location selection - Manager Menu - Update Inventory");
            throw new Exception();


        }

        public void DeleteCustomer()
        {
            Console.WriteLine("Enter the email of the Customer that you wish to be removed from the DB: ");
            Customer customer2BDeleted = _repo.GetCustomerByEmail(Console.ReadLine());
            if (customer2BDeleted == null)
            {
                Console.WriteLine("We can't find the Customer. They may have already been deleted. \n Or you typed their name wrong, please keep in mind this is a case sensitive app.");
            }
            else
            {
                _repo.DeleteCustomer(customer2BDeleted);
                Console.WriteLine($"Success!!!! {customer2BDeleted.FirstName} is gone from your Customer collection");
            }
        }
        private void GetAllCustomer()
        {
            foreach (var item in _repo.GetCustomer())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
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

    }
}