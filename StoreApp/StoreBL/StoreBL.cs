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
            //Todo: Add BL
            _repo.AddCustomer(newCustomer);
        }

        public List<Customer> GetCustomer()
        {
            return _repo.GetCustomers();
        }

        public Customer GetCustomerByEmail(string email)
        {
            return _repo.GetCustomerByEmail(email);
        }
        
        public List<StoreLocation> GetStoreLocation()
        {
            return _repo.GetStoreLocation();
        }
    }
}
