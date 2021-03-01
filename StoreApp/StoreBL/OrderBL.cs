using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public class OrderBL : IOrderBL
    {
        public void AddOrder(Order newOrder)
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

        public List<Order> GetOrder()
        {
            throw new System.NotImplementedException();
        }
    }
}