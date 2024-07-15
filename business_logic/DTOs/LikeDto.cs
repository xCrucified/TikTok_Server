using business_logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.DTOs
{
    public class LikeDto
    {   
        public int Id { get; set; }
        public DateTime DateTimeLike { get; set; }
        public string UserId { get; set; }
        public int VideoId { get; set; }
    }
}
