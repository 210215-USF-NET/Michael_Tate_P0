using System.Collections.Generic;
using StoreModels;
namespace StoreBL
{
    public interface IstoreBL
    {
        List<Customer> GetCustomer();
        void AddCustomer(Customer newCustomer);
        Customer GetCustomerByEmail(string email);
        List<StoreLocation> GetStoreLocation();
    }
}