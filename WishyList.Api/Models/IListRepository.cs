using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishyList.Models;

namespace WishyList.Api.Models
{
    public interface IListRepository
    {
        Task<IEnumerable<List>> GetLists();
        Task<List> GetList(int listId);
        Task<IEnumerable<List>> GetMemberLists(int memberId);
        Task<List> AddList(List list);
        Task<List> UpdateList(List list);
        Task<List> DeleteList(int listId);
    }
}
