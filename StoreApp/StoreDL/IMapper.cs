using Model = StoreModels;
using Entity = StoreDL.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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
    }
}