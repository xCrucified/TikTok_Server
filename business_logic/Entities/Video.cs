using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Logic.Entities
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsPrivate { get; set; }
        public string VideoUrl {  get; set; }
        public int Views {  get; set; }
        public DateTime PublishDate { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<Like> Likes { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Save> Saves { get; set; }
    }
}
