using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace data_access.Migrations
{
    /// <inheritdoc />
    public partial class hotfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb6653b1-0e3f-4d18-abc2-f24f57874dcd");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarPicture", "Balance", "Birthdate", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "Followers", "Followings", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, null, 99999m, null, "280cd20f-b78d-49ee-8563-705d24305513", "admin", null, false, -1, 0, false, null, null, null, null, "123456789", false, "3bb24b01-4c17-4b88-b78f-d7b39961a5a2", false, "admin" },
                    { "10", 0, null, 9000m, null, "5cb702c3-e2d1-486d-ba7e-306d70388dd6", "user9", null, false, 90, 45, false, null, null, null, null, "012345678", false, "1634814e-a767-48da-9dd4-8e9fe2b90d6b", false, "user9" },
                    { "2", 0, null, 1000m, null, "c8bffbd6-50dd-4a2e-b824-02dc908a13f6", "user1", null, false, 10, 5, false, null, null, null, null, "234567890", false, "cb46ea68-138d-4b21-8a48-481348ad10e8", false, "user1" },
                    { "3", 0, null, 2000m, null, "2cf1423c-274b-4f01-ae85-d4716e06bb30", "user2", null, false, 20, 10, false, null, null, null, null, "345678901", false, "64895769-b43a-4248-b52c-3230afb70695", false, "user2" },
                    { "4", 0, null, 3000m, null, "9fb7c77b-269f-469b-80d6-d833c0f50d27", "user3", null, false, 30, 15, false, null, null, null, null, "456789012", false, "0e16d653-37df-42c1-be70-67732cd383bc", false, "user3" },
                    { "5", 0, null, 4000m, null, "a27f0bd0-8592-4e0f-b02e-bf49d5e765ef", "user4", null, false, 40, 20, false, null, null, null, null, "567890123", false, "5135f650-c63e-4d5f-9b2a-b9a3e64366f8", false, "user4" },
                    { "6", 0, null, 5000m, null, "779de28f-bb9a-457d-8ecb-229b35dbcfa7", "user5", null, false, 50, 25, false, null, null, null, null, "678901234", false, "be19e49d-bd5d-4d51-bab1-c60cf9113ebc", false, "user5" },
                    { "7", 0, null, 6000m, null, "170e51ea-5aa0-493c-b6ca-5902734ee50b", "user6", null, false, 60, 30, false, null, null, null, null, "789012345", false, "ebe265d6-43c8-4d67-a9e4-8a8011464fe0", false, "user6" },
                    { "8", 0, null, 7000m, null, "59dac5c0-e8d5-4f3f-9a46-5ae680f8aa1e", "user7", null, false, 70, 35, false, null, null, null, null, "890123456", false, "dff77a63-37e2-49f8-9966-5fb002d6dac6", false, "user7" },
                    { "9", 0, null, 8000m, null, "00255325-4342-439e-a1d3-e6699cf0bad6", "user8", null, false, 80, 40, false, null, null, null, null, "901234567", false, "36f7b0a3-f28f-4909-b35d-6a82cac0726d", false, "user8" }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "PublishDate", "Title", "UserId", "VideoUrl", "Views", "isPrivate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5368), "test1", "1", "https://www.youtube.com/watch?v=bFhY0LH9XxY", 0, true },
                    { 2, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5412), "test2", "2", "https://www.youtube.com/watch?v=dQw4w9WgXcQ", 0, false },
                    { 3, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5457), "test3", "3", "https://www.youtube.com/watch?v=3JZ_D3ELwOQ", 0, true },
                    { 4, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5461), "test4", "4", "https://www.youtube.com/watch?v=oHg5SJYRHA0", 0, false },
                    { 5, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5463), "test5", "5", "https://www.youtube.com/watch?v=ZZ5LpwO-An4", 0, true },
                    { 6, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5466), "test6", "6", "https://www.youtube.com/watch?v=6_b7RDuLwcI", 0, false },
                    { 7, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5469), "test7", "7", "https://www.youtube.com/watch?v=tVj0ZTS4WF4", 0, true },
                    { 8, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5471), "test8", "8", "https://www.youtube.com/watch?v=FTQbiNvZqaY", 0, false },
                    { 9, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5474), "test9", "9", "https://www.youtube.com/watch?v=lXMskKTw3Bc", 0, true },
                    { 10, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5476), "test10", "10", "https://www.youtube.com/watch?v=60ItHLz5WEA", 0, false }
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
                    { 1, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5573), "1", 1 },
                    { 2, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5576), "2", 2 },
                    { 3, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5578), "3", 3 },
                    { 4, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5581), "4", 4 },
                    { 5, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5583), "5", 5 },
                    { 6, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5585), "6", 6 },
                    { 7, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5587), "7", 7 },
                    { 8, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5589), "8", 8 },
                    { 9, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5591), "9", 9 },
                    { 10, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5593), "10", 10 }
                });

            migrationBuilder.InsertData(
                table: "Saves",
                columns: new[] { "Id", "DateSave", "UserId", "VideoId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5534), "1", 1 },
                    { 2, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5538), "2", 2 },
                    { 3, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5540), "3", 3 },
                    { 4, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5543), "4", 4 },
                    { 5, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5545), "5", 5 },
                    { 6, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5547), "6", 6 },
                    { 7, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5549), "7", 7 },
                    { 8, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5551), "8", 8 },
                    { 9, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5553), "9", 9 },
                    { 10, new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5555), "10", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarPicture", "Balance", "Birthdate", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "Followers", "Followings", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eb6653b1-0e3f-4d18-abc2-f24f57874dcd", 0, null, 99999m, null, "bc6b019e-4d8e-4bbf-9070-9e42d52fe6f3", "admin", null, false, -1, 0, false, null, null, null, null, "123456789", false, "d32e9147-f153-45f6-9ff1-5a6a6d4a9928", false, "admin" });
        }
    }
}
