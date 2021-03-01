using System.Collections.Generic;
using Modle = StoreModels;
using Entity = StoreDL.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace StoreDL
{   
    public class CustomerRepoDB : ICustomerRepository
    {
        private Entity.StoreAppDBContext _context;
        private IMapper _mapper;
        public CustomerRepoDB(Entity.StoreAppDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Modle.Customer AddCustomer(Modle.Customer newCustomer)
        {
            _context.Customers.Add(_mapper.ParseCustomer(newCustomer));
            _context.SaveChanges();
            return newCustomer;
        }

        public List<Modle.Customer> GetCustomers()
        {
            return _context.Customers.Include("Orders").Select(x =>_mapper.ParseCustomer(x)).ToList();
        }
    }
}