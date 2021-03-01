using Modle = StoreModels;
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
        Modle.Customer ParseCustomer(Entity.Customer customer);
        Entity.Customer ParseCustomer(Modle.Customer customer);

        Modle.Order ParseOrder(Entity.Order order);
        Entity.Order ParseOrder(Modle.Order order);
    }
}