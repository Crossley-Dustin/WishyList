using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishyList.Models;

namespace WishyList.Api.Models
{
    public class ListRepository : IListRepository
    {
        private readonly AppDbContext appDbContext;

        public ListRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<List> AddList(List list)
        {
            var result = await appDbContext.Lists.AddAsync(list);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<List> DeleteList(int listId)
        {
            var result = await appDbContext.Lists
                .FirstOrDefaultAsync(m => m.ListId == listId);
            if (result != null)
            {
                appDbContext.Lists.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async Task<List> GetList(int listId)
        {
            return await appDbContext.Lists.FirstOrDefaultAsync(m => m.ListId == listId);
        }

        public async Task<List> GetListByName(string listName)
        {
            return await appDbContext.Lists.FirstOrDefaultAsync(m => m.Name == listName);
        }

        public async Task<IEnumerable<List>> GetLists()
        {
            return await appDbContext.Lists.ToListAsync();
        }

        public async Task<IEnumerable<List>> GetMemberLists(int memberId)
        {
            // Use a query to get a filtered result of lists for the specified member
            IQueryable<List> query = appDbContext.Lists;
            query = query.Where(m => m.MemberId == memberId);

            return await query.ToListAsync();
        }

        public async Task<List> UpdateList(List list)
        {
            var result = await appDbContext.Lists.FirstOrDefaultAsync(m => m.ListId == list.ListId);

            if (result != null)
            {
                result.Name = list.Name;
                // result.GroupId = list.GroupId;
                // result.MemberId = list.MemberId;
                // result.InsertDate = list.InsertDate;

                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }

    }
}
