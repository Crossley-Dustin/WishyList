using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishyList.Models;

namespace WishyList.Api.Models
{
    public interface IMemberRepository
    {
        Task<IEnumerable<Member>> GetMembers();
        Task<Member> GetMember(int memberId);
        Task<Member> GetMemberByEmail(string email);
        Task<Member> AddMember(Member member);
        Task<Member> UpdateMember(Member member);
        Task<Member> DeleteMember(int memberId);
    }
}
