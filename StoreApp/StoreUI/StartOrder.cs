using System;
using StoreBL;
using StoreModels;
using System.Collections.Generic;
using System.Linq;

namespace StoreUI
{
    public class StartOrder : IMenu
    {
        IMenu menu;
        private IstoreBL _repo;
        private Customer _customer;
        List<Order> orders;
        List<Product> products;
        public List<StoreLocation> StoresFromDB;
        
        public StartOrder(IstoreBL repo, Customer cust){
            _repo = repo;
            _customer = cust;
            StoresFromDB = _repo.GetStoreLocation();
        }

        public void Start()
        {        
            do
            {
                Console.WriteLine($"Welcome back {_customer.FirstName} would you like to...");
                Console.WriteLine("[1] Create a new order");
                Console.WriteLine("[2] View your order history");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                case "1":
                SelectStoreLocation();
                break;
                case "2":

                break;
                default:
                Console.WriteLine("\nThat was not an option try again\n");
                break;
                }
            } while (true);
        }



        public void SelectStoreLocation()
        {
            //IMenu menu;
            Boolean runMenu = true;
            //Boolean badEntryFlag = true;
            do
            {
                Console.WriteLine($"Enter the name of the shop you are looking to buy from today.\nyour options are:");
                foreach(StoreLocation store in StoresFromDB)
                {
                    Console.WriteLine(store.Name);
                }
                string userInput = Console.ReadLine();
                foreach(StoreLocation store in StoresFromDB)
                {

                    if (userInput.Equals(store.Name))
                    {
                        CreateOrder();
                        runMenu = false;
                    }
                    else
                    {
                        Console.WriteLine("\nThat was not an option try again\n");
                    }
                }

            } while (runMenu);

        
    }

        private void CreateOrder()
        {
            Console.WriteLine("It worked");
            Console.ReadLine();
        }
    }
}

//             string custChoice = "no";
//             double wholePie = 16.00;
//             double slicePie = 2.50;
//             Item newItem = new Item();
//             Product newProduct = new Product();
//             do
//             {
//             do
//             {
//             Console.WriteLine("What kind of pie would like to buy today?");
//             Console.WriteLine("#1:CoconutCream  #2:Strawberry  #3:Blueberry  #4:Pumpkin  #5:Apple");
//             Console.WriteLine("Please Enter the number of the flavor you would like");
//             newProduct.PieFlavor = Enum.Parse<Pie>(Console.ReadLine());
//             Console.WriteLine($"flavor added was {newProduct.PieFlavor} Correct?\nPlease answer with Yes or No");
//             custChoice = Console.ReadLine().ToLower();
//             } while (custChoice != "yes");
//             Console.WriteLine("Please enter 1 if you are buying a whole pie or 2 if you are buying slices of pie");
//             string userInput = Console.ReadLine();
//             switch (userInput)
//             {
//                 case "1":
//                 Console.WriteLine("Please enter how many whole pies your purchasing today");
//                 newItem.Quantity = int.Parse(Console.ReadLine());
//                 Console.WriteLine(CalculateTotal(newItem.Quantity, wholePie));
//                 break;
//                 case "2":
//                 Console.WriteLine("Please enter how many slices of pie your purchasing today");
//                 newItem.Quantity = int.Parse(Console.ReadLine()); 
//                 Console.WriteLine(CalculateTotal(newItem.Quantity, slicePie));
//                 break;
//                 default:
//                 break;
//             }
//             }while (true);

//calculate the ttal cost of an order
        // public double CalculateTotal(int ammount,double price)
        // {
        //     double total;
        //     total = (ammount * price) * .056 + (ammount * price);
        //     return total;
        // }