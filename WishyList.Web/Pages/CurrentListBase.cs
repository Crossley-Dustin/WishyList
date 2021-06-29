using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishyList.Models;
using WishyList.Web.Services;

namespace WishyList.Web.Pages
{
    public class CurrentListBase : ComponentBase
    {
        [Inject]
        public IMemberService MemberService { get; set; }

        public Member Member { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if (int.TryParse(Id, out int memberId))
            {
                Member = await MemberService.GetMember(memberId);
            }

            
        }
    }
}
