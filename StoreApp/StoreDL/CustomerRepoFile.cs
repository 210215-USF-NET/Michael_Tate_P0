﻿using System.Collections.Generic;
using StoreModels;
using System.IO;
using System.Text.Json;
using System;

namespace StoreDL
{
    public class CustomerRepoFile : ICustomerRepository
    {
        private string jsonString;
        
        private string filePath = "C:/Users/Michael Tate/Desktop/Revature/Michael_Tate_P0/StoreApp/StoreDL/CustomerFiles.json";
        public Customer AddCustomer(Customer newCustomer)
        {
            List<Customer> CustomersFromFile = GetCustomers();
            CustomersFromFile.Add(newCustomer);
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
