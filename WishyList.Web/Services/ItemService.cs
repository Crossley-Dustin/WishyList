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

        public async Task<Item> CreateItem(Item newItem)
        {
            return await httpClient.PostJsonAsync<Item>("api/items", newItem);
        }

        public async Task<Item> GetItem(int itemId)
        {
            return await httpClient.GetJsonAsync<Item>($"api/items/{itemId}");
        }

        public async Task<IEnumerable<Item>> GetListItems(int listId)
        {
            var result = await httpClient.GetJsonAsync<Item[]>($"api/items/getlistitems/{listId}");

            if (result != null)
            {
                return result;
            }

            return null;
        }

        public async Task<Item> UpdateItem(Item updatedItem)
        {
            return await httpClient.PutJsonAsync<Item>("api/items", updatedItem);
        }
    }
}
