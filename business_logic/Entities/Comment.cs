using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Logic.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int VideoId { get; set; }
        public Video Video { get; set; }
    }
}
