using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.DTOs
{
    public class UserDto : IdentityUser
    {
        public decimal Balance { get; set; }
        public string AvatarPicture { get; set; }
        public DateTime Birthdate { get; set; }
        public int Followers { get; set; }
        public int Followings { get; set; }
        public Boolean isFriend { get; set; }
        public string? Description { get; set; }
    }
}
