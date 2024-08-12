using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace data_access.Migrations
{
    /// <inheritdoc />
    public partial class fixx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c23b683-6679-4c61-a0f0-e9d9c369103c");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarPicture", "Balance", "Birthdate", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "Followers", "Followings", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eb6653b1-0e3f-4d18-abc2-f24f57874dcd", 0, null, 99999m, null, "bc6b019e-4d8e-4bbf-9070-9e42d52fe6f3", "admin", null, false, -1, 0, false, null, null, null, null, "123456789", false, "d32e9147-f153-45f6-9ff1-5a6a6d4a9928", false, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb6653b1-0e3f-4d18-abc2-f24f57874dcd");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarPicture", "Balance", "Birthdate", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "Followers", "Followings", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7c23b683-6679-4c61-a0f0-e9d9c369103c", 0, null, 99999m, null, "ffe54afe-8dfe-44aa-ad64-8a372d0c81a8", "admin", null, false, -1, 0, false, null, null, null, null, "123456789", false, "42032901-9f70-4490-a773-722ce84cac3a", false, "admin" });
        }
    }
}
