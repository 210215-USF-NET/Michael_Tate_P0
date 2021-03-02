using System.Collections.Generic;
using Model = StoreModels;
using Entity = StoreDL.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StoreModels;

namespace StoreDL
{
    public class StoreRepoDB : IStoreRepository
    {
        private Entity.StoreAppDBContext _context;
        private IMapper _mapper;
        public StoreRepoDB(Entity.StoreAppDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Model.Customer AddCustomer(Model.Customer newCustomer)
        {
            _context.Customers.Add(_mapper.ParseCustomer(newCustomer));
            _context.SaveChanges();
            return newCustomer;
        }

        public List<Model.Customer> GetCustomers()
        {
            return _context.Customers.Include("Orders").Select(x =>_mapper.ParseCustomer(x)).ToList();
        }

        public Model.Customer GetCustomerByEmail(string email)
        {
            return _context.Customers
            .AsNoTracking()
            .Select(x => _mapper.ParseCustomer(x))
            .ToList()
            .FirstOrDefault(x => x.Email == email);
        }

        public List<Order> GetOrders()
        {
            throw new System.NotImplementedException();
        }

        public Order AddOrder(Order newOrder)
        {
            throw new System.NotImplementedException();
        }

        public Order FindOrder(int orderID)
        {
            throw new System.NotImplementedException();
        }

        public Order FindOrder(double totalCost)
        {
            throw new System.NotImplementedException();
        }

        public List<Order> GetCustomerOrders(int custID)
        {
            throw new System.NotImplementedException();
        }

        public List<StoreLocation> GetStoreLocation()
        {
            return _context.Locations
            .AsNoTracking()
            .Select(x => _mapper.ParseLocation(x))
            .ToList();
        }
    }
}
