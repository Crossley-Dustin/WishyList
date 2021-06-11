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
        public IListService ListService { get; set; }
        public IItemService ItemService { get; set; }

        public Member member { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            member = await MemberService.GetMember(1);
        }
    }
}
