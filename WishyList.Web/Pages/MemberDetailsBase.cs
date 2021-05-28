using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishyList.Models;
using WishyList.Web.Services;

namespace WishyList.Web.Pages
{
    public class MemberDetailsBase : ComponentBase
    {
        public Member Member { get; set; } = new Member();

        [Inject]
        public IMemberService MemberService { get; set; }
        
        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Member = await MemberService.GetMember(int.Parse(Id));
        }

    }
}
