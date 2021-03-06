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
            return _context.Customers
            .Select(x =>_mapper.ParseCustomer(x))
            .ToList();
        }

        public Model.Customer GetCustomerByEmail(string email)
        {
            return _context.Customers
            .AsNoTracking()
            .Select(x => _mapper.ParseCustomer(x))
            .ToList()
            .FirstOrDefault(x => x.Email == email);
        }

        public Order AddOrder(Model.Order newOrder)
        {
            _context.Orders.Add(_mapper.ParseOrder(newOrder));
            _context.SaveChanges();
            return newOrder;
        }

        public List<StoreLocation> GetStoreLocation()
        {
            return _context.Locations
            .AsNoTracking()
            .Select(Id => _mapper.ParseLocation(Id))
            .ToList();
        }

        public List<Product> GetProduct()
        {
            return _context.Products
            .AsNoTracking()
            .Select(x => _mapper.ParseProduct(x))
            .ToList();
        }

        public void UpdateCustomer(Customer customer2BUpdated)
        {
            Entity.Customer oldCustomer = _context.Customers.Find(customer2BUpdated.CustID);
            _context.Entry(oldCustomer).CurrentValues.SetValues(_mapper.ParseCustomer(customer2BUpdated));
            _context.SaveChanges();
            _context.ChangeTracker.Clear();
        }

        public Customer DeleteCustomer(Customer customer2BDeleted)
        {
            _context.Customers.Remove(_mapper.ParseCustomer(customer2BDeleted));
            _context.SaveChanges();
            return customer2BDeleted;
        }

        public List<Order> GetOrders()
        {
            return _context.Orders
            .AsNoTracking()
            .Select(x =>_mapper.ParseOrder(x))
            .ToList();
        }

        public Model.Product GetProductByName(int ProductName)
        {
            return _context.Products
            .AsNoTracking()
            .Select(x => _mapper.ParseProduct(x))
            .ToList().FirstOrDefault(x => x.ProductName.Equals(ProductName));
        }
        public void UpdateInventory(Product inv)
        {
            Entity.Product oldInv = _context.Products.Find(inv.ProductName);
            _context.Entry(oldInv).CurrentValues.SetValues(_mapper.ParseProduct(inv));

            _context.SaveChanges();
            _context.ChangeTracker.Clear();
        }

        public Model.Product GetPrice()
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

        
    }
}
