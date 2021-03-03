using System.Collections.Generic;
using StoreModels;
namespace StoreBL
{
    public interface IstoreBL
    {
        List<Customer> GetCustomer();
        void AddCustomer(Customer newCustomer);
        void AddOrder(Order newOrder);
        Customer GetCustomerByEmail(string email);
        List<StoreLocation> GetStoreLocation();
        List<Product> GetProduct();
        Product GetPrice();
        void UpdateCustomer(Customer customer2BUpdated, Customer updatedDetails);
        void DeleteCustomer(Customer customer2BDeleted);
    }
}