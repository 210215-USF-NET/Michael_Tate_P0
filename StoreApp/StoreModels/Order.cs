namespace StoreModels
{
    /// <summary>
    /// This class should contain all the fields and properties that define a customer order. 
    /// </summary>
    public class Order
    {
        public Customer Customer { get; set; }
        public StoreLocation Location { get; set; }
        public decimal Total { get; set; }

        //TODO: add a property for the order items
    }
}