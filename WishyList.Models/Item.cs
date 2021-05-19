using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WishyList.Models
{
    class Item
    {
        public int ItemId { get; set; }
        public int ListId { get; set; }
        public int MemberId { get; set; }
        public string Label { get; set; }
        public bool Completed { get; set; }
        public DateTime CompletedDate { get; set; }
        public int CompletedByMemberId { get; set; }
    }
}
