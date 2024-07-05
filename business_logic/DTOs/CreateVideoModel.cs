using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Bussiness_Logic.DTOs
{
    public class CreateVideoModel
    {
        string Title { get; set; }
        public int Views { get; set; }
        public bool IsPrivate { get; set; }
        public IFormFile VideoUrl { get; set; }
        public DateTime PublishDate { get; set; }
        public string UserId { get; set; }
    }   
}
