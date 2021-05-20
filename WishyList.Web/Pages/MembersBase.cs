using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using WishyList.Models;

namespace WishyList.Web.Pages
{
    public class MembersBase : ComponentBase
    {
        public IEnumerable<Member> Members { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadMembers);
        }

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
    }
}
