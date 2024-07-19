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
                new User() { UserName = "admin", Balance = 99999, PhoneNumber = "123456789", Followers = -1, Followings = 0, Description = "admin"},
                new User() { UserName = "user1", Balance = 1000, PhoneNumber = "234567890", Followers = 10, Followings = 5, Description = "user1"},
                new User() { UserName = "user2", Balance = 2000, PhoneNumber = "345678901", Followers = 20, Followings = 10, Description = "user2"},
                new User() { UserName = "user3", Balance = 3000, PhoneNumber = "456789012", Followers = 30, Followings = 15, Description = "user3"},
                new User() { UserName = "user4", Balance = 4000, PhoneNumber = "567890123", Followers = 40, Followings = 20, Description = "user4"},
                new User() { UserName = "user5", Balance = 5000, PhoneNumber = "678901234", Followers = 50, Followings = 25, Description = "user5"},
                new User() { UserName = "user6", Balance = 6000, PhoneNumber = "789012345", Followers = 60, Followings = 30, Description = "user6"},
                new User() { UserName = "user7", Balance = 7000, PhoneNumber = "890123456", Followers = 70, Followings = 35, Description = "user7"},
                new User() { UserName = "user8", Balance = 8000, PhoneNumber = "901234567", Followers = 80, Followings = 40, Description = "user8"},
                new User() { UserName = "user9", Balance = 9000, PhoneNumber = "012345678", Followers = 90, Followings = 45, Description = "user9"},
            });

            builder.Entity<Video>().HasData(new[]
            {
                new Video() { Id = 1, PublishDate = DateTime.Now, UserId = "1", Title = "test1", isPrivate = true, VideoUrl = "https://www.youtube.com/watch?v=bFhY0LH9XxY" },
                new Video() { Id = 2, PublishDate = DateTime.Now, UserId = "2", Title = "test2", isPrivate = false, VideoUrl = "https://www.youtube.com/watch?v=dQw4w9WgXcQ" },
                new Video() {Id = 3, PublishDate = DateTime.Now, UserId = "3", Title = "test3", isPrivate = true, VideoUrl = "https://www.youtube.com/watch?v=3JZ_D3ELwOQ"},
                new Video() {Id = 4, PublishDate = DateTime.Now, UserId = "4", Title = "test4", isPrivate = false, VideoUrl = "https://www.youtube.com/watch?v=oHg5SJYRHA0"},
                new Video() {Id = 5, PublishDate = DateTime.Now, UserId = "5", Title = "test5", isPrivate = true, VideoUrl = "https://www.youtube.com/watch?v=ZZ5LpwO-An4"},
                new Video() {Id = 6, PublishDate = DateTime.Now, UserId = "6", Title = "test6", isPrivate = false, VideoUrl = "https://www.youtube.com/watch?v=6_b7RDuLwcI"},
                new Video() {Id = 7, PublishDate = DateTime.Now, UserId = "7", Title = "test7", isPrivate = true, VideoUrl = "https://www.youtube.com/watch?v=tVj0ZTS4WF4"},
                new Video() {Id = 8, PublishDate = DateTime.Now, UserId = "8", Title = "test8", isPrivate = false, VideoUrl = "https://www.youtube.com/watch?v=FTQbiNvZqaY"},
                new Video() {Id = 9, PublishDate = DateTime.Now, UserId = "9", Title = "test9", isPrivate = true, VideoUrl = "https://www.youtube.com/watch?v=lXMskKTw3Bc"},
                new Video() {Id = 10, PublishDate = DateTime.Now, UserId = "0", Title = "test10", isPrivate = false, VideoUrl = "https://www.youtube.com/watch?v=60ItHLz5WEA"},           
            });
            builder.Entity<Comment>().HasData(new[]
            {  
                new Comment() { Id = 1, VideoId = 1, UserId = "1", Content = "Video Super!!!"},
                new Comment() { Id = 2, VideoId = 2, UserId = "2", Content = "Nice video!"},
                new Comment() { Id = 3, VideoId = 3, UserId = "3", Content = "Very informative."},
                new Comment() { Id = 4, VideoId = 4, UserId = "4", Content = "Amazing content!"},
                new Comment() { Id = 5, VideoId = 5, UserId = "5", Content = "Loved it!"},
                new Comment() { Id = 6, VideoId = 6, UserId = "6", Content = "Great work!"},
                new Comment() { Id = 7, VideoId = 7, UserId = "7", Content = "Fantastic!"},
                new Comment() { Id = 8, VideoId = 8, UserId = "8", Content = "Very helpful."},
                new Comment() { Id = 9, VideoId = 9, UserId = "9", Content = "Enjoyed watching."},
                new Comment() { Id = 10, VideoId = 10, UserId = "10", Content = "Well done!"},            
            });
            builder.Entity<Save>().HasData(new[]
            {
                new Save() { Id = 1, UserId = "1", VideoId = 1, DateSave = DateTime.Now },
                new Save() { Id = 2, UserId = "2", VideoId = 2, DateSave = DateTime.Now },
                new Save() { Id = 3, UserId = "3", VideoId = 3, DateSave = DateTime.Now },
                new Save() { Id = 4, UserId = "4", VideoId = 4, DateSave = DateTime.Now },
                new Save() { Id = 5, UserId = "5", VideoId = 5, DateSave = DateTime.Now },
                new Save() { Id = 6, UserId = "6", VideoId = 6, DateSave = DateTime.Now },
                new Save() { Id = 7, UserId = "7", VideoId = 7, DateSave = DateTime.Now },
                new Save() { Id = 8, UserId = "8", VideoId = 8, DateSave = DateTime.Now },
                new Save() { Id = 9, UserId = "9", VideoId = 9, DateSave = DateTime.Now },
                new Save() { Id = 10, UserId = "10", VideoId = 10, DateSave = DateTime.Now },            
            });
            builder.Entity<Like>().HasData(new[]
            {
                new Like() { Id = 1, UserId = "1", VideoId = 1, DateTimeLike = DateTime.Now },
                new Like() { Id = 2, UserId = "2", VideoId = 2, DateTimeLike = DateTime.Now },
                new Like() { Id = 3, UserId = "3", VideoId = 3, DateTimeLike = DateTime.Now },
                new Like() { Id = 4, UserId = "4", VideoId = 4, DateTimeLike = DateTime.Now },
                new Like() { Id = 5, UserId = "5", VideoId = 5, DateTimeLike = DateTime.Now },
                new Like() { Id = 6, UserId = "6", VideoId = 6, DateTimeLike = DateTime.Now },
                new Like() { Id = 7, UserId = "7", VideoId = 7, DateTimeLike = DateTime.Now },
                new Like() { Id = 8, UserId = "8", VideoId = 8, DateTimeLike = DateTime.Now },
                new Like() { Id = 9, UserId = "9", VideoId = 9, DateTimeLike = DateTime.Now },
                new Like() { Id = 10, UserId = "10", VideoId = 10, DateTimeLike = DateTime.Now },
            });
        }
    }
}
