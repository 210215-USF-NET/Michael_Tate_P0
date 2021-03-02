using StoreModels;
using System.Collections.Generic;
using Entity = StoreDL.Entities;
using Model = StoreModels;
namespace StoreDL
{
    public interface ICustomerRepository
    {
        private Entity.StoreAppDBContext _context;
        List<Customer> GetCustomers();
        Customer AddCustomer(Customer newCustomer);

        public Customer GetCustomerByName(string name)
        {
            //this method returns the hero entity, and eagerly loads the superpower entity associated with it 
            //using the .Include() method. the .AsNoTracking() method makes sure that the enities aren't being 
            //tracked by the change tracker. the .Select() method is used to transform each entity type to a model type
            //The .ToList() method structures the collection into a list, and the FirstOrDefault() method searches
            //that list for a element whose heroName is equal to the parameter
            return _context.Customers
            .Include("Superpower")
            .AsNoTracking()
            .Select(x => _mapper.ParseHero(x))
            .ToList()
            .FirstOrDefault(x => x.HeroName == name);
        }
    }
}