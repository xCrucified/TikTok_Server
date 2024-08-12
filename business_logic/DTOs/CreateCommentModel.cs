using business_logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.DTOs
{
    public class CreateCommentModel
    {
        public string Content { get; set; }
        public string UserId { get; set; }
        public int VideoId { get; set; }
    }
}
