using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WishyList.Models;

namespace WishyList.Web.Services
{
    public class MemberService : IMemberService
    {
        private readonly HttpClient httpClient;

        public MemberService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Member> GetMember(int id)
        {
            return await httpClient.GetJsonAsync<Member>($"api/members/{id}");
        }

        public async Task<IEnumerable<Member>> GetMembers()
        {
            return await httpClient.GetJsonAsync<Member[]>("api/members");
        }
    }
}
