using System.Collections.Generic;
using Model = StoreModels;
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
    }
}