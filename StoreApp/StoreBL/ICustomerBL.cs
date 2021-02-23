using StoreModels;
using System.Collections.Generic;
namespace StoreBL
{
    public interface ICustomerBL
    {
        List<Customer> GetCustomer();
        void AddCustomer(Customer newCustomer);
    }
}