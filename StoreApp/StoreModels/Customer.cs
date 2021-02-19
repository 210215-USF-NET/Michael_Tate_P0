using System;
namespace StoreModels
{
    /// <summary>
    /// This class should contain necessary properties and fields for customer info.
    /// </summary>
    public class Customer
    {
        private string firstName;
        private string lastName;
        private string email;
        public string FirstName 
        { 
            get {return firstName;} 
            set
            {
                while (value == null || value.Equals(""))
                {
                    Console.WriteLine("this is a required feald. Please try again:");
                    value = Console.ReadLine();
                }
                
            } 
        }
        //TODO: add more properties to identify the customer
        public string LastName 
        { 
            get{return lastName;} 
            set
            {
                while (value == null || value.Equals(""))
                {
                    Console.WriteLine("this is a required feald. Please try again:");
                    value = Console.ReadLine();
                }
            } 
        }
        public string PhoneNumber { get; set; }
        public string Email 
        { 
            get{return email;}
            set
            {
                while (value == null || value.Equals(""))
                {
                    Console.WriteLine("this is a required feald. Please try again:");
                    value = Console.ReadLine();
                }
            } 
        }

        public Location Location {get; set;}
    }
}