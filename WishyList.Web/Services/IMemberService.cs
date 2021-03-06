using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishyList.Models;

namespace WishyList.Web.Services
{
    public interface IMemberService
    {
        Task<IEnumerable<Member>> GetMembers();
        Task<Member> GetMember(int id);
        Task<Member> GetMemberByEmail(string email);
        Task<Member> UpdateMember(Member updatedMember);
        Task<Member> CreateMember(Member newMember);
    }
}
