using Model = StoreModels;
using Entity = StoreDL.Entities;
using StoreDL;
using StoreModels;
using StoreDL.Entities;
using System;

namespace StoreDL
{
    public class StoreMapper : IMapper
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
                //ID = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            };
        }

        public Model.StoreLocation ParseLocation(Location location)
        {
            return new Model.StoreLocation
            {
                Name = location.Name,
                Address = location.Address,
                City = location.City,
                State = location.State,
                Zip = location.Zip
            };
        }

        public Entity.Location ParseLocation(StoreLocation location)
        {
                return new Entity.Location
            {
                Name = location.Name,
                Address = location.Address,
                City = location.City,
                State = location.State,
                Zip = location.Zip,
                Id = (int)location.Id
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

        public Model.Product ParseProduct(Entity.Product product)
        {
            return new Model.Product()
            {
                ProductName = (Model.Pie)product.ProductName,
                Price = product.Price,
                WholeCount = product.WholeCount,
                SliceCount = product.SliceCount
            };
        }

        public Entity.Product ParseProduct(Model.Product product)
        {
            return new Entity.Product()
            {
                ProductName = (int)product.ProductName,
                Price = product.Price,
                WholeCount = product.WholeCount,
                SliceCount = product.SliceCount,
            };
        }
    }
}