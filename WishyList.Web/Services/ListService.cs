using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WishyList.Models;

namespace WishyList.Web.Services
{
    public class ListService : IListService
    {
        private readonly HttpClient httpClient;

        public ListService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List> CreateList(List newList)
        {
            return await httpClient.PostJsonAsync<List>("api/lists", newList);
        }

        public async Task<List> GetList(int listId)
        {
            return await httpClient.GetJsonAsync<List>($"api/lists/{listId}");
        }

        public async Task<IEnumerable<List>> GetMemberLists(int memberId)
        {
            return await httpClient.GetJsonAsync<List[]>($"api/lists/getmemberlists/{memberId}");
        }

        public async Task<List> UpdateList(List updatedList)
        {
            return await httpClient.PutJsonAsync<List>("api/lists", updatedList);
        }
    }
}
