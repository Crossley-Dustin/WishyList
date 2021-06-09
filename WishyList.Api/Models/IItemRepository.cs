using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishyList.Models;

namespace WishyList.Api.Models
{
    public interface IItemRepository
    {
        Task<IEnumerable<Item>> GetListItems(int listId);
        Task<Item> GetItem(int itemId);
        Task<Item> GetItemByName(int listId, string itemName);
        Task<Item> AddItem(Item item);
        Task<Item> UpdateItem(Item item);
        Task<Item> DeleteItem(int itemId);
        Task<IEnumerable<Item>> DeleteListItems(int listId);
    }
}
