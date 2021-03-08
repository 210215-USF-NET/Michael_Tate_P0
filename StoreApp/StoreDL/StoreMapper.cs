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
                CustID = customer.Id,
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
                Id = customer.CustID,
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
                Zip = location.Zip,
                Id = (int)location.Id
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
                CustID= order.CustomerID,
                LocID = order.LocationID,
                ProID = order.ProductID,
                Quantity = order.Quantity,
                Total = order.Total,
            };
        }

        public Entity.Order ParseOrder(Model.Order order)
        {
            return new Entity.Order
            {
                CustomerID = order.CustID,
                LocationID = order.LocID,
                ProductID = order.ProID,
                Quantity = order.Quantity,
                Total = order.Total,
            };
        }

        public Model.Product ParseProduct(Entity.Product product)
        {
            return new Model.Product()
            {
                Id = product.Location,
                ProductName = (Model.Pie)product.ProductName,
                Price = product.Price,
                PieCount = product.PieCount,
            };
        }

        public Entity.Product ParseProduct(Model.Product product)
        {
            return new Entity.Product()
            {
                Location = (int)product.Id,
                ProductName = (int)product.ProductName,
                Price = product.Price,
                PieCount = product.PieCount,
            };
        }
    }
}