// using System.Collections.Generic;
// using StoreModels;
// namespace StoreDL
// {
//     public class StoreRepoSC : IStoreRepository
//     {
//         public List<Customer> GetCustomers()
//         {
//             return Storage.AllCustomers;
//         }
//         public Customer AddCustomer(Customer newCustomer)
//         {
//             Storage.AllCustomers.Add(newCustomer);
//             return newCustomer;
//         }

//         public Customer GetCustomerByEmail(string name)
//         {
//             return Customer(name);
//         }
//     }
// }