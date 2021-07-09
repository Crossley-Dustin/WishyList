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
    public class IndexBase : ComponentBase
    {
        [CascadingParameter]
        public Task<AuthenticationState> AuthenticationStateTask { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        //public IEnumerable<Item> Items { get; set; }
        public Member Member { get; set; }
        public List List { get; set; }
        public IEnumerable<Item> ListItems { get; set; }
        //public IEnumerable<List> Lists { get; set; }

        [Inject]
        public IMemberService MemberService { get; set; }
        [Inject]
        public IListService ListService { get; set; }
        //public IItemService ItemService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            // possible process

            // check authenticated user and get email
            // get authentication state of the user
            var authenticationState = await AuthenticationStateTask;

            if (!authenticationState.User.Identity.IsAuthenticated)
            {
                NavigationManager.NavigateTo("/identity/account/login");
            }

            // search for members with that email
            // if no member found, create a member
            Member = await MemberService.GetMemberByEmail(authenticationState.User.Identity.Name);
            
            if (Member == null)
            {
                // create the member with the email address from identity name
                Member = new Member
                {
                    Name = authenticationState.User.Identity.Name,
                    Email = authenticationState.User.Identity.Name,
                    InsertDate = DateTime.Now,
                    LastGroupId = 1
                };

                Member = await MemberService.CreateMember(Member);
                
                NavigationManager.NavigateTo("/editmember/" + Member.MemberId);
            }


            NavigationManager.NavigateTo("/memberdetails/" + Member.MemberId);
            
            /*
            if (Member != null)
            {
                // check if user last list is populated
                //List = await ListService.GetList(Member.LastListId);
                // if no list, create a new list and update the member last list
                //if (List == null)
                if (Member.LastListId == 0)
                {
                    List = new List
                    {
                        GroupId = 1,
                        MemberId = Member.MemberId,
                        Name = "New List",
                        InsertDate = DateTime.Now
                    };

                    List = await ListService.CreateList(List);

                    if (List.ListId != 0)
                    {
                        Member.LastListId = List.ListId;
                        await MemberService.UpdateMember(Member);
                    }

                }

                //if (List != null)
                //{
                //    // populate listz
                //    ListItems = await ItemService.GetListItems(List.ListId);
                //    // get items in the list and populate items object
                //}
            }

            NavigationManager.NavigateTo("currentlist/" + Member.MemberId);
            */
        }
    }
}
