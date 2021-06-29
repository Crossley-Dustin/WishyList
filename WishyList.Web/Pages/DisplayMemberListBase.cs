using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishyList.Models;
using WishyList.Web.Services;

namespace WishyList.Web.Pages
{
    public class DisplayMemberListBase : ComponentBase
    {
        [Parameter]
        public Member Member { get; set; }

        public List List { get; set; }
        public IEnumerable<Item> Items {get;set;}

        [Inject]
        public IListService ListService { get; set; }
        [Inject]
        public IItemService ItemService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            List = await ListService.GetList(Member.LastListId);
            if (List != null)
            {
                Items = await ItemService.GetListItems(Member.LastListId);
            }
        }
    }
}
