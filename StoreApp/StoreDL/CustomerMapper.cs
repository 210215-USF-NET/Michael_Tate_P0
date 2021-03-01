using Modle = StoreModels;
using Entity = StoreDL.Entities;
using StoreDL;
using StoreModels;

namespace StoreDL
{
    public class CustomerMapper : IMapper
    {
        public Modle.Customer ParseCustomer(Entity.Customer customer)
        {
            return new Modle.Customer
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            };
        }

        public Entity.Customer ParseCustomer(Modle.Customer customer)
        {
            return new Entity.Customer
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            };
        }
        public Modle.Order ParseOrder(Entity.Order order)
        {
            return new Modle.Order()
            {
                /*Customer = ParseCustomer(order.Customer),
                Location = ParseCustomer(order.Location),
                Total = (double)order.Total*/
            };
        }

        public Entity.Order ParseOrder(Modle.Order order)
        {
            return new Entity.Order()
            {
               /* Customer = ParseCustomer(order.Customer),
                Location = ParseCustomer(order.Location),
                Total = (decimal)order.Total*/
            };
        }
    }
}