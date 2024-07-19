using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace data_access.Migrations
{
    /// <inheritdoc />
    public partial class InitSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61d2eeef-e0b9-48eb-b791-8cde62f13fa6");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarPicture", "Balance", "Birthdate", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "Followers", "Followings", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3237ac8e-f595-4624-a32f-4ba5fede3495", 0, null, 9000m, null, "13335acd-829a-489b-9712-35e13c0f7df0", "user9", null, false, 90, 45, false, null, null, null, null, "012345678", false, "15380209-a3df-4326-8793-147a1fd01c9c", false, "user9" },
                    { "5471030f-cc9a-47c7-ba90-62d647f4cdc6", 0, null, 1000m, null, "dbc46cba-0203-4740-baef-39df71253324", "user1", null, false, 10, 5, false, null, null, null, null, "234567890", false, "17075708-4136-404a-915a-1caa81137434", false, "user1" },
                    { "58f1eb52-e65c-4ea5-be62-c2c1c4eeb8cf", 0, null, 3000m, null, "0fd38151-d602-49be-a292-0dd0dff5f3f6", "user3", null, false, 30, 15, false, null, null, null, null, "456789012", false, "1dd78c11-39f2-43ef-844c-3dba730a5847", false, "user3" },
                    { "5e6e040a-a296-4d6e-9533-3acdcc052171", 0, null, 4000m, null, "e95f9402-abf6-4fe3-af7e-3188742d72ee", "user4", null, false, 40, 20, false, null, null, null, null, "567890123", false, "979b1151-c795-4763-844e-248e788a956f", false, "user4" },
                    { "792dc171-726b-4d10-a7ac-61a2cbe88027", 0, null, 2000m, null, "f755485b-69d4-4a05-913d-3cc225a1e8ea", "user2", null, false, 20, 10, false, null, null, null, null, "345678901", false, "51838524-29d8-487b-bb69-1ad34a273361", false, "user2" },
                    { "82c49ce0-0bc6-4501-a675-91c8d6ac801d", 0, null, 6000m, null, "4f8e9985-c5d9-48d5-adef-a95609e5ca00", "user6", null, false, 60, 30, false, null, null, null, null, "789012345", false, "07ad6d4e-61fa-4254-a729-5fdfd03af8f0", false, "user6" },
                    { "d6366cae-d385-404d-bc6b-21af12662404", 0, null, 8000m, null, "83f3ef0f-1b77-4ef8-be94-cb71c2dcc14a", "user8", null, false, 80, 40, false, null, null, null, null, "901234567", false, "484e87d6-8587-4da0-9e9c-13095636442f", false, "user8" },
                    { "d668690e-ffbf-4bad-8895-668f95dc5cc1", 0, null, 5000m, null, "9df6ec3e-185c-4af3-a7b2-6287e74031f3", "user5", null, false, 50, 25, false, null, null, null, null, "678901234", false, "47f7b10a-6dc5-43ee-8a0a-a6f1ad06c470", false, "user5" },
                    { "dd02ed32-0eec-499d-95e7-1a9b4e0f8dff", 0, null, 7000m, null, "92195542-4e9c-4a37-bae2-962b22c3fd8d", "user7", null, false, 70, 35, false, null, null, null, null, "890123456", false, "6dfcc411-bb78-4cbf-bfec-171a4fbc547d", false, "user7" },
                    { "eca9d97d-e09c-457e-bdf8-45f486560607", 0, null, 99999m, null, "0c843c90-a539-48b8-9e8c-87fdf0494c8b", "admin", null, false, -1, 0, false, null, null, null, null, "123456789", false, "4598d62f-4b19-41fd-a9af-b30b2de2c428", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "PublishDate", "Title", "UserId", "VideoUrl", "Views", "isPrivate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4222), "test1", "1", "https://www.youtube.com/watch?v=bFhY0LH9XxY", 0, true },
                    { 2, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4272), "test2", "2", "https://www.youtube.com/watch?v=dQw4w9WgXcQ", 0, false },
                    { 3, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4275), "test3", "3", "https://www.youtube.com/watch?v=3JZ_D3ELwOQ", 0, true },
                    { 4, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4278), "test4", "4", "https://www.youtube.com/watch?v=oHg5SJYRHA0", 0, false },
                    { 5, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4280), "test5", "5", "https://www.youtube.com/watch?v=ZZ5LpwO-An4", 0, true },
                    { 6, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4283), "test6", "6", "https://www.youtube.com/watch?v=6_b7RDuLwcI", 0, false },
                    { 7, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4286), "test7", "7", "https://www.youtube.com/watch?v=tVj0ZTS4WF4", 0, true },
                    { 8, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4288), "test8", "8", "https://www.youtube.com/watch?v=FTQbiNvZqaY", 0, false },
                    { 9, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4291), "test9", "9", "https://www.youtube.com/watch?v=lXMskKTw3Bc", 0, true },
                    { 10, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4293), "test10", "0", "https://www.youtube.com/watch?v=60ItHLz5WEA", 0, false }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "Content", "UserId", "VideoId" },
                values: new object[,]
                {
                    { 1, "Video Super!!!", "1", 1 },
                    { 2, "Nice video!", "2", 2 },
                    { 3, "Very informative.", "3", 3 },
                    { 4, "Amazing content!", "4", 4 },
                    { 5, "Loved it!", "5", 5 },
                    { 6, "Great work!", "6", 6 },
                    { 7, "Fantastic!", "7", 7 },
                    { 8, "Very helpful.", "8", 8 },
                    { 9, "Enjoyed watching.", "9", 9 },
                    { 10, "Well done!", "10", 10 }
                });

            migrationBuilder.InsertData(
                table: "Likes",
                columns: new[] { "Id", "DateTimeLike", "UserId", "VideoId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4386), "1", 1 },
                    { 2, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4389), "2", 2 },
                    { 3, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4391), "3", 3 },
                    { 4, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4393), "4", 4 },
                    { 5, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4395), "5", 5 },
                    { 6, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4398), "6", 6 },
                    { 7, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4400), "7", 7 },
                    { 8, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4402), "8", 8 },
                    { 9, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4404), "9", 9 },
                    { 10, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4406), "10", 10 }
                });

            migrationBuilder.InsertData(
                table: "Saves",
                columns: new[] { "Id", "DateSave", "UserId", "VideoId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4345), "1", 1 },
                    { 2, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4348), "2", 2 },
                    { 3, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4351), "3", 3 },
                    { 4, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4353), "4", 4 },
                    { 5, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4355), "5", 5 },
                    { 6, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4357), "6", 6 },
                    { 7, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4360), "7", 7 },
                    { 8, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4362), "8", 8 },
                    { 9, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4364), "9", 9 },
                    { 10, new DateTime(2024, 7, 19, 20, 7, 29, 987, DateTimeKind.Local).AddTicks(4366), "10", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3237ac8e-f595-4624-a32f-4ba5fede3495");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5471030f-cc9a-47c7-ba90-62d647f4cdc6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58f1eb52-e65c-4ea5-be62-c2c1c4eeb8cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e6e040a-a296-4d6e-9533-3acdcc052171");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "792dc171-726b-4d10-a7ac-61a2cbe88027");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c49ce0-0bc6-4501-a675-91c8d6ac801d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6366cae-d385-404d-bc6b-21af12662404");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d668690e-ffbf-4bad-8895-668f95dc5cc1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd02ed32-0eec-499d-95e7-1a9b4e0f8dff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eca9d97d-e09c-457e-bdf8-45f486560607");

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarPicture", "Balance", "Birthdate", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "Followers", "Followings", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "61d2eeef-e0b9-48eb-b791-8cde62f13fa6", 0, null, 99999m, null, "18029ce6-a73e-4c75-8db3-e5607b35da6c", "admin", null, false, -1, 0, false, null, null, null, null, "123456789", false, "3f05a65f-c0cc-4cea-a9a8-c75a6bfef0d1", false, "admin" });
        }
    }
}
