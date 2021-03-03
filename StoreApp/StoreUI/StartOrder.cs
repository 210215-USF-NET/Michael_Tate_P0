using System;
using StoreBL;
using StoreModels;
using System.Collections.Generic;
using System.Linq;

namespace StoreUI
{
    public class StartOrder : IMenu
    {
        //IMenu menu;
        private IstoreBL _repo;
        private Customer _customer;
        private StoreLocation _location;
        //List<Order> orders;
        //List<Product> products;
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
                        
                        _location = store;
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

        public void CreateOrder()
        {
            //Order ord = new InputOrderDetails();
            _repo.AddOrder(InputOrderDetails());
            Console.WriteLine("Order Created");
        }

        private Order InputOrderDetails()
        {
            Order newOrder = new Order();
            Product newProduct = new Product();
            decimal wholePie = (decimal)16.00;
            decimal slicePie = (decimal)2.50;
            string custChoice;

            do
            {
                Console.WriteLine("What kind of pie would like to buy today?");
                Console.WriteLine("==================================================================");
                Console.WriteLine("#1:CoconutCream  #2:Strawberry  #3:Blueberry  #4:Pumpkin  #5:Apple");
                Console.WriteLine("==================================================================");
                Console.WriteLine("Please Enter the number of the flavor you would like");
                newProduct.ProductName = Enum.Parse<Pie>(Console.ReadLine());
                Console.WriteLine($"flavor added was {newProduct.ProductName} Correct?\nPlease answer with Yes or No");
                custChoice = Console.ReadLine().ToLower();
            } while (custChoice != "yes");
            Console.WriteLine("Pie options");
            Console.WriteLine("[1] Whole Pies");
            Console.WriteLine("[2] Slice's of Pie");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                Console.WriteLine("Please enter how many whole pies your purchasing today");
                newOrder.Quantity = int.Parse(Console.ReadLine());
                newOrder.Total = (CalculateTotal(newOrder.Quantity, wholePie));
                break;
                case "2":
                Console.WriteLine("Please enter how many slices of pie your purchasing today");
                newOrder.Quantity = int.Parse(Console.ReadLine()); 
                newOrder.Total = (CalculateTotal((decimal)newOrder.Quantity, slicePie));
                break;
                default:
                break;
            }
            return newOrder;
        }

        //calculate the total cost of an order
        public decimal CalculateTotal(decimal ammount,decimal price)
        {
            decimal beforeTax;
            decimal impTax;
            decimal tax= (decimal).056;
            decimal afterTax;
            beforeTax = decimal.Multiply( ammount, price );
            impTax = decimal.Multiply( beforeTax, tax );
            afterTax = decimal.Multiply( ammount, price ) + impTax;
            return afterTax;
        }    
    }
}


            // string custChoice = "no";
            // double wholePie = 16.00;
            // double slicePie = 2.50;

        
        