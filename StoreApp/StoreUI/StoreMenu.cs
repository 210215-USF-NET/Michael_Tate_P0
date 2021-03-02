using System;
using StoreBL;
using StoreModels;
using System.Collections.Generic;

namespace StoreUI
{
    public class StoreMenu : IMenu
    {
        
        // reference: managerMenu = new ManagerMenu(_customerBL, _productBL, _locationBL, _inventoryBL, _orderBL);

        //start menu code
        public void Start()
        {
            Boolean runMenu = true;
            do
            {
                Console.WriteLine("Welcome to the pie store, please select an option below");
                Console.WriteLine("[1] Create a new customer.");
                Console.WriteLine("[2] Create an order.");
                Console.WriteLine("[3] Search for Customer.");
                Console.WriteLine("[4] Manager Shit.");
                Console.WriteLine("[5] Exit the store.");

                Console.WriteLine("Enter a number: ");
                string userInput = Console.ReadLine();            
            switch (userInput)
            {
                case "1":
                break;
                
                case "2":
                //Create an order
                OrderStart();
                break;

                case "3":
                //search all customers or one customer
                // SearchCustomer newSearch = new SearchCustomer(_customerBL);
                // newSearch.Start();
                break;

                case "4":
                
                

                case "5":
                runMenu = false;
                break;
                
                default:
                    Console.WriteLine("\nThat was not an option try again\n");
                break;
            }
            }while (runMenu);
        }
        
        
        
        
        //start an order
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

        //calculate the ttal cost of an order
        public double CalculateTotal(int ammount,double price)
        {
            double total;
            total = (ammount * price) * .056 + (ammount * price);
            return total;
        }

        
        

        
        /*public void SearchHero()
        {
            Console.WriteLine("Enter hero name: ");
            Customer foundCustomer = _customerBL.GetCustomerByName(Console.ReadLine());
            if (foundCustomer == null)
            {
                Console.WriteLine("No such hero found :<");
            }
            else
            {
                Console.WriteLine(foundCustomer.ToString());
            }
        }
    */
    
    


    }
    
}