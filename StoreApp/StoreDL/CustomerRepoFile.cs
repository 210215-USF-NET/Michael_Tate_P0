using System.Collections.Generic;
using StoreModels;
using System.IO;
using System.Text.Json;
using System;

namespace StoreDL
{
    public class CustomerRepoFile : ICustomerRepository
    {
        private string jsonString;
        private string filePath; //add file path
        public Customer AddCustomer(Customer newCustomer)
        {
            List<Customer> CustomersFromFile = GetCustomers();
            CustomersFromFile.Add(newCustomer);
            jsonString = JsonSerializer.Serialize(CustomersFromFile);
            File.WriteAllText(filePath, jsonString);
            return newCustomer;
        }

        public List<Customer> GetCustomers()
        {
            try
            {
                jsonString = File.ReadAllText(filePath);
            }
            catch (Exception)
            {
                return new List<Customer>();
            }
            return JsonSerializer.Deserialize<List<Customer>>(jsonString);
        }
    }
}
