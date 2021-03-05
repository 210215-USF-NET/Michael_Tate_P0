using System;
using System.Collections.Generic;
using StoreModels;
using StoreDL;

namespace StoreBL
{
    public class storeBL : IstoreBL
    {
        private IStoreRepository _repo;
        public storeBL(IStoreRepository repo)
        {
            _repo = repo;
        }
        public void AddCustomer(Customer newCustomer)
        {
            _repo.AddCustomer(newCustomer);
        }

        public void AddOrder(Order newOrder, StoreLocation getStoreLocation, Customer getCustomer)
        {
            _repo.AddOrder(newOrder, getStoreLocation, getCustomer);
        }

        public void DeleteCustomer(Customer customer2BDeleted)
        {
            _repo.DeleteCustomer(customer2BDeleted);
        }

        public List<Customer> GetCustomer()
        {
            return _repo.GetCustomers();
        }

        public Customer GetCustomerByEmail(string email)
        {
            return _repo.GetCustomerByEmail(email);
        }

        public Product GetPrice()
        {
            return _repo.GetPrice();
        }

        public List<Product> GetProduct()
        {
            return _repo.GetProduct();
        }

        public List<StoreLocation> GetStoreLocation()
        {
            return _repo.GetStoreLocation();
        }
        
        public void UpdateCustomer(Customer customer2BUpdated, Customer updatedDetails)
        {
                customer2BUpdated.FirstName = updatedDetails.FirstName;
                customer2BUpdated.LastName = updatedDetails.LastName;
                customer2BUpdated.Email = updatedDetails.Email;
                customer2BUpdated.PhoneNumber = updatedDetails.PhoneNumber;

                _repo.UpdateCustomer(customer2BUpdated);
        }

        
    }
}
