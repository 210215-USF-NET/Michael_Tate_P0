using System.Collections.Generic;
using StoreModels;
using System.IO;
using System.Text.Json;
using System;

namespace StoreDL
{
    public class StoreRepoFile : IStoreRepository
    {
        private string jsonString;
        private string filePath = "./StoreDL/StoreFiles.json";
        public Customer AddCustomer(Customer newCustomer)
        {
            //List<Customer> CustomersFromFile = GetCustomers();
            //CustomersFromFile.Add(newCustomer);
            jsonString = JsonSerializer.Serialize(newCustomer);
            File.WriteAllText(filePath, jsonString);
            return newCustomer;
        }

        public List<Customer> GetCustomers()
        {

            jsonString = File.ReadAllText(filePath);
            Customer fileRecord = JsonSerializer.Deserialize<Customer>(jsonString);
            return new List<Customer> {fileRecord};
        }
    }
}
