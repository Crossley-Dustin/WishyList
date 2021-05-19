using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WishyList.Models
{
    class List
    {
        public int ListId { get; set; }
        public int GroupId { get; set; }
        public int MemberId { get; set; }
        public int Name { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
