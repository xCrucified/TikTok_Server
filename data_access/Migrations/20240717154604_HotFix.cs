using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace data_access.Migrations
{
    /// <inheritdoc />
    public partial class HotFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff604141-f3e9-428d-be50-f33e58fbfb7e");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarPicture", "Balance", "Birthdate", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "Followers", "Followings", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e2c36d48-0057-42e1-8727-e578262f7e4e", 0, null, 99999m, null, "04d096e5-6624-42ea-af13-5e9f0fa286b2", "admin", null, false, -1, 0, false, null, null, null, null, "123456789", false, "7ad418ae-a98a-40d4-b623-e1470a669343", false, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2c36d48-0057-42e1-8727-e578262f7e4e");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarPicture", "Balance", "Birthdate", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "Followers", "Followings", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ff604141-f3e9-428d-be50-f33e58fbfb7e", 0, null, 99999m, null, "5711c05e-9521-4e6d-be1f-8093dd892d69", "admin", null, false, -1, 0, false, null, null, null, null, "123456789", false, "a25863c6-9b78-4bcf-87fe-f7913d4f23e2", false, "admin" });
        }
    }
}
