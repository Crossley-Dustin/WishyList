using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishyList.Models;

namespace WishyList.Api.Models
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext appDbContext;

        public ItemRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Item> AddItem(Item item)
        {
            var result = await appDbContext.Items.AddAsync(item);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Item> DeleteItem(int itemId)
        {
            var result = await appDbContext.Items
                .FirstOrDefaultAsync(i => i.ItemId == itemId);
            if (result != null)
            {
                appDbContext.Items.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async Task<IEnumerable<Item>> DeleteListItems(int listId)
        {
            // get the list of items
            var itemList = await GetListItems(listId);
            if (itemList != null)
            {
                // verify all items are valid
                foreach(Item item in itemList)
                {
                    var result = await appDbContext.Items.FindAsync(item.ItemId);
                    if (result == null)
                    {
                        return null;
                    }
                }
                
                // remove the items
                appDbContext.RemoveRange(itemList);
                await appDbContext.SaveChangesAsync();
                return itemList;
            }

            return null;
        }

        public async Task<Item> GetItem(int itemId)
        {
            return await appDbContext.Items.FindAsync(itemId);
        }

        public async Task<IEnumerable<Item>> GetListItems(int listId)
        {
            // get all items for the specified list
            IQueryable<Item> query = appDbContext.Items;
            query = query.Where(i => i.ListId == listId);

            return await query.ToListAsync();
        }

        public async Task<Item> UpdateItem(Item item)
        {
            var result = await appDbContext.Items.FirstOrDefaultAsync(i => i.ItemId == item.ItemId);

            if (result != null)
            {
                result.Label = item.Label;
                result.Completed = item.Completed;
                result.CompletedByMemberId = item.CompletedByMemberId;
                result.CompletedDate = item.CompletedDate;

                // result.ListId = item.ListId;
                // result.MemberId = item.MemberId;

                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
