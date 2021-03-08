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
        Product GetProductByName(int ProductName);
        List<StoreLocation> GetStoreLocation();
        List<Product> GetProduct();
        Product GetPrice();
        void UpdateCustomer(Customer customer2BUpdated, Customer updatedDetails);
        void DeleteCustomer(Customer customer2BDeleted);
        List<Order> GetOrder();
        void UpdateInventory(Product inv);
    }
}