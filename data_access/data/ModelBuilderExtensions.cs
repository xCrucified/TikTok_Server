using business_logic.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.data
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>().HasData(new[]
            {
                 new User() { UserName = "admin", Balance = 99999, PhoneNumber = "123456789", Followers = -1, Followings = 0, Description = "admin"}
            });

            //builder.Entity<Video>().HasData(new[]
            //{
            //    new Video() { Id = 1, Title = "test1", isPrivate = true, VideoUrl =  }
            //});

        }
    }
}
