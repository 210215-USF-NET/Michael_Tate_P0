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
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException();
                }
                firstName = value;
                
            } 
        }
        //TODO: add more properties to identify the customer
        public string LastName 
        { 
            get{return lastName;} 
            set
            {
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException();
                }
                lastName = value;
            }
        }
        public string PhoneNumber { get; set; }
        public string Email 
        { 
            get{return email;}
            set
            {
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException();
                }
                email = value;
            } 
        }
        public Location Location {get; set;}
        
        public override string ToString() => $"Customer Details: \n\t name: {this.FirstName} {this.LastName} \n\t phone number: {this.PhoneNumber} \n\t email: {this.Email}";
    }
}