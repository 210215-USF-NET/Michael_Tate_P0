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
        
        public StartOrder(IstoreBL repo, Customer cust){
            _repo = repo;
            _customer = cust;
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
                menu = new SelectStoreLocation(_repo);
                menu.Start();
                break;
                case "2":

                break;
                default:
                Console.WriteLine("\nThat was not an option try again\n");
                break;
                }
            } while (true);
        }

        //calculate the ttal cost of an order
        // public double CalculateTotal(int ammount,double price)
        // {
        //     double total;
        //     total = (ammount * price) * .056 + (ammount * price);
        //     return total;
        // }
    }
}

// string custChoice = "no";
//             double wholePie = 15.00;
//             double slicePie = 2.50;
//             Item newItem = new Item();
//             Product newProduct = new Product();
//             do
//             {
//             do
//             {
//             Console.WriteLine("What kind of pie would like to buy today?");
//             Console.WriteLine(@"
// #1:CoconutCream  #2:Strawberry  #3:Blueberry        #4:Pumpkin      #5:Apple
// #6:Cherry        #7:Peach       #8:SweetPotato      #9:MixedBerry   #10:BananaCream
// #11:Razzleberry  #12:Mince      #13:ChocolateCream  #14:Grasshopper #15:LemonMeringue
// #16:Custard      #17:Turtle     #18:VanillaCaramel  #19:Rhubarb     #20:Blackberry 
//         #21:KeyLime                 #22:Pear                #23:Pecan");
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