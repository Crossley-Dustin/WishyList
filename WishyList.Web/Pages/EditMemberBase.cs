using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishyList.Models;
using WishyList.Web.Services;

namespace WishyList.Web.Pages
{
    public class EditMemberBase : ComponentBase
    {
        public Member Member { get; set; } = new Member();
        
        [Inject]
        public IMemberService MemberService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            if (int.TryParse(Id, out int memberId))
            {
                if (memberId != 0)
                {
                    Member = await MemberService.GetMember(int.Parse(Id));
                }
                else
                {
                    Member = new Member
                    {
                        InsertDate = DateTime.Now
                    };
                }
            }                   
        }

        protected async Task HandleValidSubmit()
        {
            var result = await MemberService.UpdateMember(Member);

            if (result != null)
            {
                NavigationManager.NavigateTo("members");
            }
        }
    }
}
