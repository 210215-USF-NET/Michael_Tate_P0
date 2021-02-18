namespace StoreModels
{
    /// <summary>
    /// This class should contain necessary properties and fields for customer info.
    /// </summary>
    public class Customer
    {
        public string FirstName { get; set; }
        //TODO: add more properties to identify the customer
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}