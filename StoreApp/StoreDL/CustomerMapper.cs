using Model = StoreModels;
using Entity = StoreDL.Entities;
using StoreDL;
using StoreModels;

namespace StoreDL
{
    public class CustomerMapper : IMapper
    {
        public Model.Customer ParseCustomer(Entity.Customer customer)
        {
            return new Model.Customer
            {
                //Id = 
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            };
        }

        public Entity.Customer ParseCustomer(Model.Customer customer)
        {
            return new Entity.Customer
            {
                //Id =
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            };
        }
        public Model.Order ParseOrder(Entity.Order order)
        {
            return new Model.Order()
            {
                /*Customer = ParseCustomer(order.Customer),
                Location = ParseCustomer(order.Location),
                Total = (decimal)order.Total
            */
            };
        }

        public Entity.Order ParseOrder(Model.Order order)
        {
            return new Entity.Order()
            {
                /*
                Customer = order.Customer.id,
                Location = Customer(order.Location),
                Total = (decimal)order.Total
            */
            };
        }
    }
}