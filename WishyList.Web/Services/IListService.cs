using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishyList.Models;

namespace WishyList.Web.Services
{
    public interface IListService
    {
        Task<IEnumerable<List>> GetMemberLists(int id);
        Task<List> GetList(int id);
        Task<List> UpdateList(List updatedList);
        Task<List> CreateList(List newList);
    }
}
