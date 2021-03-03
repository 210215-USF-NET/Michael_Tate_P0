namespace StoreModels
{
    //This class should contain all necessary fields to define a product.
    public class Product
    {
        public Pie ProductName { get; set; } 
        public decimal Price { get; set; }
        public int WholeCount { get; set; }
        public int SliceCount { get; set; }
        //todo: add more properties to define a product (maybe a category?)
    }
    
}