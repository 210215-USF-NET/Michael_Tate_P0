using System;
namespace StoreModels
{

    /// <summary>
    /// This data structure models a product and its quantity. The quantity was separated from the product as it could vary from orders and locations.  
    /// </summary>
    public class Item
    {
        //private int quantity;
        public Product Product { get; set; }
        public int Quantity {get; set;}

        /*public int Quantity 
        { 
            get{return quantity;} 
            set
            {
                if (value <= 0)
                throw new ArgumentOutOfRangeException();
            }
        }
        */
    }
}