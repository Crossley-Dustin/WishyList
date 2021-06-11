using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WishyList.Models;

namespace WishyList.Web.Services
{
    public class ItemService : IItemService
    {
        private readonly HttpClient httpClient;

        public ItemService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Item> GetItem(int itemId)
        {
            return await httpClient.GetJsonAsync<Item>($"api/items/{itemId}");
        }

        public async Task<IEnumerable<Item>> GetListItems(int listId)
        {
            return await httpClient.GetJsonAsync<Item[]>($"api/items/getlistitems/{listId}");
        }
    }
}
