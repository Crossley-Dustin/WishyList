using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishyList.Models;

namespace WishyList.Web.Services
{
    public interface IItemService
    {
        Task<IEnumerable<Item>> GetListItems(int listId);
        Task<Item> GetItem(int itemId);
    }
}
