using Model = StoreModels;
using Entity = StoreDL.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StoreDL.Entities;

namespace StoreDL
{
    /// <summary>
    /// to parse entities from DB to models used in BL and vice versa
    /// </summary>
    public interface IMapper
    {
        Model.Customer ParseCustomer(Entity.Customer customer);
        Entity.Customer ParseCustomer(Model.Customer customer);

        Model.Order ParseOrder(Entity.Order order);
        Entity.Order ParseOrder(Model.Order order);

        Model.StoreLocation ParseLocation(Entity.Location location);
        Entity.Location ParseLocation(Model.StoreLocation location);
        
        Model.Product ParseProduct(Entity.Product product);
        Entity.Product ParseProduct(Model.Product product);
    }
}