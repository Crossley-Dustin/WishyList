using Microsoft.AspNetCore.Components;
using WishyList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishyList.Web.Services;
using Microsoft.AspNetCore.Components.Authorization;

namespace WishyList.Web.Pages
{
    public class ListsBase : ComponentBase
    {
        [CascadingParameter]
        public Task<AuthenticationState> authenticationStateTask { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        //public IEnumerable<Item> Items { get; set; }
        public IEnumerable<List> Lists { get; set; }

        [Inject]
        public IMemberService MemberService { get; set; }
        public IListService ListService { get; set; }
        public IItemService ItemService { get; set; }

        protected override async Task OnInitializedAsync()
        {

            // get authentication state of the user
            var authenticationState = await authenticationStateTask;

            if (!authenticationState.User.Identity.IsAuthenticated)
            {
                NavigationManager.NavigateTo("/identity/account/login");
            }

            // possible process
            // check authenticated user and get email
            // search for members with that email
            // if no member found, create a member
            // check if user last list is populated
            // if no list, create a new list and update the member last list
            // populate list
            // get items in the list and populate items object

            // have to implement an endpoint and service for this.
            var user = MemberService.GetMemberByEmail(authenticationState.User.Identity.Name);

            //await Task.Run(LoadItems);
            Lists = (await ListService.GetMemberLists(1)).ToList();
        }

        /*
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
        */
    }
}
