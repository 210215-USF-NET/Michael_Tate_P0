namespace StoreModels
{
    //This class should contain all necessary fields to define a product.
    public class Product
    {
        public Pie PieFlavor { get; set; } 
        public double Price { get; set; }
        //todo: add more properties to define a product (maybe a category?)
    }
}