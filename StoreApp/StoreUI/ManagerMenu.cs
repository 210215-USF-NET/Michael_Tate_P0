using System;
namespace StoreUI
{
    public class ManagerMenu : IMenu
    {
        public void Start()
        {
            do
            {
                Console.WriteLine("Greetings manager please select an option below.");
                Console.WriteLine("[1] Restock Inventory.");
                Console.WriteLine("[2] Exit Manager Menu.");

                //will add more as i go
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Restock();
                    break;
                    case "2":

                    break;
                    default:
                    break;
                }

            } while (true);
        }

        public void Restock()
        {

        }
    }
}