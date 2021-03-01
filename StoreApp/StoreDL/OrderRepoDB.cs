using System.Collections.Generic;
using Model = StoreModels;
using Entity = StoreDL.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StoreModels;

namespace StoreDL
{
    public class OrderRepoDB : IOrderRepository
    {
        private Entity.StoreAppDBContext _context;
        private IMapper _mapper;

        public Order AddOrder(Entity.StoreAppDBContext context, IMapper mapper)
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

        public List<Order> GetOrders()
        {
            throw new System.NotImplementedException();
        }
    }
}