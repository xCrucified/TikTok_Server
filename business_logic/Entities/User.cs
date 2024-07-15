using business_logic.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Logic.Entities
{
    public class User : IdentityUser
    {
        public decimal? Balance { get; set; }
        public string? AvatarPicture { get; set; }
        public DateTime? Birthdate { get; set; }
        public int? Followers { get; set; }
        public int? Followings { get; set; }
        public string? Description { get; set; }
        public IEnumerable<Video>? Videos { get; set;}
        public IEnumerable<Like>? Likes { get; set;}
        public IEnumerable<Comment>? Comments { get; set;}
        public ICollection<RefreshToken>? RefreshTokens { get; set; }

    }
}
