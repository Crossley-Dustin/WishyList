using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishyList.Models;

namespace WishyList.Api.Models
{
    public class MemberRepository : IMemberRepository
    {
        private readonly AppDbContext appDbContext;

        public MemberRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Member> AddMember(Member member)
        {
            var result = await appDbContext.Members.AddAsync(member);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Member> DeleteMember(int memberId)
        {
            var result = await appDbContext.Members
                .FirstOrDefaultAsync(m => m.MemberId == memberId);
            if (result != null)
            {
                appDbContext.Members.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async Task<Member> GetMember(int memberId)
        {
            return await appDbContext.Members.FindAsync(memberId);
        }

        public async Task<Member> GetMemberByEmail(string email)
        {
            return await appDbContext.Members.FirstOrDefaultAsync(m => m.Email == email);
        }

        public async Task<IEnumerable<Member>> GetMembers()
        {
            return await appDbContext.Members.ToListAsync();
        }

        public async Task<Member> UpdateMember(Member member)
        {
            var result = await appDbContext.Members.FirstOrDefaultAsync(m => m.MemberId == member.MemberId);

            if (result != null)
            {
                result.Name = member.Name;
                result.Email = member.Email;
                result.LastGroupId = member.LastGroupId;
                result.LastListId = member.LastListId;

                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
