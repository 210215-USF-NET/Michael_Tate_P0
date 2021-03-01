using System;
using StoreModels;
using StoreBL;
using System.Collections.Generic;
namespace StoreUI
{
    public class SearchCustomer : IMenu
    {
        private ICustomerBL _customerBL;
        public CustomerMenu(ICustomerBL customerBL)
        {
            _customerBL = customerBL;
        }
        public void Start()
        {
            Console.WriteLine("test");
            /*private void GetCustomer()
            foreach (var item in _customerBL.GetCustomer())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            */
        }

        //get all customer, does not work yet
        private void GetCustomer()
        {
            foreach (var item in _customerBL.GetCustomer())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}