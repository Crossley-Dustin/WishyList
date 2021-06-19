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

        public async Task<Member> CreateMember(Member newMember)
        {
            return await httpClient.PostJsonAsync<Member>("api/members", newMember);
        }

        public async Task<Member> GetMember(int id)
        {
            return await httpClient.GetJsonAsync<Member>($"api/members/{id}");
        }

        public async Task<Member> GetMemberByEmail(string email)
        {
            var result = await httpClient.GetJsonAsync<Member>($"api/members/getmemberbyemail/{email}");

            if (result != null)
            {
                return result;
            }

            return null;
        }

        public async Task<IEnumerable<Member>> GetMembers()
        {
            return await httpClient.GetJsonAsync<Member[]>("api/members");
        }

        public async Task<Member> UpdateMember(Member updatedMember)
        {
            return await httpClient.PutJsonAsync<Member>("api/members", updatedMember);
        }
    }
}
