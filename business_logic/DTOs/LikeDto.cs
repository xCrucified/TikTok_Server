using Bussiness_Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Logic.DTOs
{
    public class LikeDto
    {   
        public int Id { get; set; }
        public DateTime DateTimeLike { get; set; }
        public string UserId { get; set; }
        public int VideoId { get; set; }
    }
}
