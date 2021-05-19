using System;

namespace WishyList.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int LastGroupId { get; set; }
        public int LastListId { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
