using System;
using StoreBL;
using StoreModels;
using System.Collections.Generic;


namespace StoreUI
{
    public class StoreMenu : IMenu
    {
        private ICustomerBL _customerBL;
        public StoreMenu(ICustomerBL customerBL)
        {
            _customerBL = customerBL;
        }
        // reference: managerMenu = new ManagerMenu(_customerBL, _productBL, _locationBL, _inventoryBL, _orderBL);
        public void Start()
        {
            Boolean stay = true;
            do
            {
                Console.WriteLine("Welcome to the pie store, please select an option below");
                Console.WriteLine("[1] Create a new customer.");
                Console.WriteLine("[2] Create an order.");
                Console.WriteLine("[3] Get all Customers.");
                Console.WriteLine("[4] Manager Shit.");
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
                OrderStart();
                break;

                case "3":
                GetCustomer();                //search customer
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
        
        private void GetCustomer()
        {
            foreach (var item in _customerBL.GetCustomer())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        public void OrderStart()
        {
            string custChoice = "no";
            double wholePie = 15.00;
            double slicePie = 2.50;
            Item newItem = new Item();
            Product newProduct = new Product();
            do
            {
            do
            {
            Console.WriteLine("What kind of pie would like to buy today?");
            Console.WriteLine(@"
#1:CoconutCream  #2:Strawberry  #3:Blueberry        #4:Pumpkin      #5:Apple
#6:Cherry        #7:Peach       #8:SweetPotato      #9:MixedBerry   #10:BananaCream
#11:Razzleberry  #12:Mince      #13:ChocolateCream  #14:Grasshopper #15:LemonMeringue
#16:Custard      #17:Turtle     #18:VanillaCaramel  #19:Rhubarb     #20:Blackberry 
        #21:KeyLime                 #22:Pear                #23:Pecan");
            Console.WriteLine("Please Enter the number of the flavor you would like");
            newProduct.PieFlavor = Enum.Parse<Pie>(Console.ReadLine());
            Console.WriteLine($"flavor added was {newProduct.PieFlavor} Correct?\nPlease answer with Yes or No");
            custChoice = Console.ReadLine().ToLower();
            } while (custChoice != "yes");
            Console.WriteLine("Please enter 1 if you are buying a whole pie or 2 if you are buying slices of pie");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                Console.WriteLine("Please enter how many whole pies your purchasing today");
                newItem.Quantity = int.Parse(Console.ReadLine());
                Console.WriteLine(CalculateTotal(newItem.Quantity, wholePie));
                break;
                case "2":
                Console.WriteLine("Please enter how many slices of pie your purchasing today");
                newItem.Quantity = int.Parse(Console.ReadLine()); 
                Console.WriteLine(CalculateTotal(newItem.Quantity, slicePie));
                break;
                default:
                break;
            }
            }while (true);
        }

        public double CalculateTotal(int ammount,double price)
        {
            double total;
            total = (ammount * price) * .056 + (ammount * price);
            return total;
        }

        /* public void SearchHero()
        {
            Console.WriteLine("Enter hero name: ");
            Cusotmer foundHero = _heroBL.GetHeroByName(Console.ReadLine());
            if (foundHero == null)
            {
                Console.WriteLine("No such hero found :<");
            }
            else
            {
                Console.WriteLine(foundHero.ToString());
            }
    }
    */
    private void GoodBuy()
        {
            Console.WriteLine("Thank you for shopping with us. Goodbye");
        }





    }
    
}