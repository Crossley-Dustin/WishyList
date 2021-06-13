using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WishyList.Models;
using WishyList.Web.Services;

namespace WishyList.Web.Pages
{
    public class MembersBase : ComponentBase
    {
        [CascadingParameter]
        public Task<AuthenticationState> authenticationStateTask { get; set; }

        public IEnumerable<Member> Members { get; set; }
        
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IMemberService MemberService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            // get authentication state of the user
            var authenticationState = await authenticationStateTask;

            //authenticationState.User.Claims.

            if (!authenticationState.User.Identity.IsAuthenticated)
            {
                // If we wanted to redirect the user to the page they were trying to reach when directed to the login page
                //string returnUrl = WebUtility.UrlEncode($"/editEmployee/{Id}");
                //NavigationManager.NavigateTo($"/identity/account/login?returnUrl={returnUrl}");
                NavigationManager.NavigateTo("/identity/account/login");
            }

            Members = (await MemberService.GetMembers()).ToList();
        }

            /*
        private void LoadMembers()
        {
            System.Threading.Thread.Sleep(1000);
            Member M1 = new Member
            {
                MemberId = 1,
                Name = "John One",
                Email = "john1@example.com",
                LastGroupId = 1,
                LastListId = 1,
                InsertDate = DateTime.Now
            };

            Member M2 = new Member
            {
                MemberId = 2,
                Name = "Suzie Two",
                Email = "suzie2@example.com",
                LastGroupId = 1,
                LastListId = 1,
                InsertDate = DateTime.Now
            };

            Member M3 = new Member
            {
                MemberId = 3,
                Name = "Pete Three",
                Email = "pete3@example.com",
                LastGroupId = 1,
                LastListId = 1,
                InsertDate = DateTime.Now
            };

            Member M4 = new Member
            {
                MemberId = 4,
                Name = "Jill Four",
                Email = "jill4@example.com",
                LastGroupId = 1,
                LastListId = 1,
                InsertDate = DateTime.Now
            };

            Members = new List<Member> { M1, M2, M3, M4 };
        }
            */
    }
}
