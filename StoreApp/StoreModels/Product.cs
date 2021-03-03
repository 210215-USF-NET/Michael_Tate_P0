namespace StoreModels
{
    //This class should contain all necessary fields to define a product.
    public class Product
    {
        public Pie ProductName { get; set; } 
        public decimal Price { get; set; }
        public int WholeCount { get; set; }
        public int SliceCount { get; set; }
        public override string ToString() => $"Inventory Details: \n\t Product: {this.ProductName} \n\t Price: {this.Price} \n\t Whole Pies: {this.WholeCount} \n\t Slice of Pie: {this.SliceCount}";
        //todo: add more properties to define a product (maybe a category?)
    }
    
}