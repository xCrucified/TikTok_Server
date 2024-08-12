using business_logic.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.DTOs
{
    public class VideoDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsPrivate { get; set; }
        public string VideoUrl { get; set; }
        public int Views { get; set; }
        public DateTime PublishDate { get; set; }
        public string UserId { get; set; }
    }
}
