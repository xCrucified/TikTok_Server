using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace data_access.Migrations
{
    /// <inheritdoc />
    public partial class connectionToServer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fac7041-45c6-4f06-836e-6cae7c2fde35");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarPicture", "Balance", "Birthdate", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "Followers", "Followings", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "61d2eeef-e0b9-48eb-b791-8cde62f13fa6", 0, null, 99999m, null, "18029ce6-a73e-4c75-8db3-e5607b35da6c", "admin", null, false, -1, 0, false, null, null, null, null, "123456789", false, "3f05a65f-c0cc-4cea-a9a8-c75a6bfef0d1", false, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61d2eeef-e0b9-48eb-b791-8cde62f13fa6");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarPicture", "Balance", "Birthdate", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "Followers", "Followings", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9fac7041-45c6-4f06-836e-6cae7c2fde35", 0, null, 99999m, null, "af76ae9c-c33e-4e64-bf0d-ad3f5490dd89", "admin", null, false, -1, 0, false, null, null, null, null, "123456789", false, "6cdde469-aa1e-4302-8f9a-cf64a84af890", false, "admin" });
        }
    }
}
