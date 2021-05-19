using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WishyList.Models
{
    public class GroupMember
    {
        public int GroupMemberId { get; set; }
        public int GroupId { get; set; }
        public int MemberId { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
