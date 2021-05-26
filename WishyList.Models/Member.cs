using System;
using System.ComponentModel.DataAnnotations;

namespace WishyList.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        [MinLength(3)]
        public string Email { get; set; }
        public int LastGroupId { get; set; }
        public int LastListId { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
