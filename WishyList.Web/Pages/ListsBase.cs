using Microsoft.AspNetCore.Components;
using WishyList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WishyList.Web.Pages
{
    public class ListsBase : ComponentBase
    {
        public IEnumerable<Item> Items { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadItems);
        }

        private void LoadItems()
        {
            System.Threading.Thread.Sleep(1000);

            Item I1 = new Item
            {
                ItemId = 1,
                ListId = 1,
                MemberId = 1,
                Label = "Book - Magician: Apprentice"
            };

            Item I2 = new Item
            {
                ItemId = 1,
                ListId = 1,
                MemberId = 1,
                Label = "DVD - A Knight's Tale"
            };

            Item I3 = new Item
            {
                ItemId = 1,
                ListId = 1,
                MemberId = 1,
                Label = "Wireless headphones"
            };

            Item I4 = new Item
            {
                ItemId = 1,
                ListId = 1,
                MemberId = 1,
                Label = "mechanical pencil"
            };

            Items = new List<Item> { I1, I2, I3, I4 };
        }
    }
}
