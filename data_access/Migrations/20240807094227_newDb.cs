using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace data_access.Migrations
{
    /// <inheritdoc />
    public partial class newDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f40258ed-7350-40d7-87db-f4b0d91a1df9", "c94fface-456d-41cd-a38c-976b997135f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "912104c3-65bc-4e94-ade4-ee30a9a31d3c", "a1872b34-3efd-4695-b172-6b4b21ad9cd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d8d18210-3502-4361-9f83-6b46f8dbbd21", "443d4fca-2b0b-4a6e-a41a-264722762f24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86d4b016-934e-40dc-ad56-53e1f41de623", "b7b5e19b-675d-4796-932b-0c874a072d04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1bfa0adf-9cd3-41bf-89bc-9ee95f1193a8", "907031cb-0bb3-44d4-951e-54f457d962df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "03c714f1-189e-46e5-af6b-75fe33cf4bab", "ae8c5bd1-a1c8-4147-912c-92d6a5aa7fcb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5a902c62-8da5-4749-9d3b-c4660433e2b6", "091c2c3b-e679-481a-8f3f-68a9f7f7d177" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8aa8dbfb-d83d-420d-ac59-7767f7ef1408", "d2b5cf1b-d883-4817-8c8e-a4aa316026ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "885d0771-50a9-4293-a338-01fa7d147ac5", "eff980fd-63bc-4b4f-8d5f-b75140124064" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a40d41ec-d4a2-479f-a8ac-8d9f32014de9", "cc6b17f0-f21c-4195-8fc6-9e923471d4bf" });

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTimeLike",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTimeLike",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTimeLike",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTimeLike",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTimeLike",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTimeLike",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTimeLike",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTimeLike",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTimeLike",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTimeLike",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateSave",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateSave",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateSave",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateSave",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateSave",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateSave",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateSave",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateSave",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateSave",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateSave",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishDate",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishDate",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishDate",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishDate",
                value: new DateTime(2024, 8, 7, 12, 42, 26, 890, DateTimeKind.Local).AddTicks(2549));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "280cd20f-b78d-49ee-8563-705d24305513", "3bb24b01-4c17-4b88-b78f-d7b39961a5a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5cb702c3-e2d1-486d-ba7e-306d70388dd6", "1634814e-a767-48da-9dd4-8e9fe2b90d6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c8bffbd6-50dd-4a2e-b824-02dc908a13f6", "cb46ea68-138d-4b21-8a48-481348ad10e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2cf1423c-274b-4f01-ae85-d4716e06bb30", "64895769-b43a-4248-b52c-3230afb70695" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9fb7c77b-269f-469b-80d6-d833c0f50d27", "0e16d653-37df-42c1-be70-67732cd383bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a27f0bd0-8592-4e0f-b02e-bf49d5e765ef", "5135f650-c63e-4d5f-9b2a-b9a3e64366f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "779de28f-bb9a-457d-8ecb-229b35dbcfa7", "be19e49d-bd5d-4d51-bab1-c60cf9113ebc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "170e51ea-5aa0-493c-b6ca-5902734ee50b", "ebe265d6-43c8-4d67-a9e4-8a8011464fe0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "59dac5c0-e8d5-4f3f-9a46-5ae680f8aa1e", "dff77a63-37e2-49f8-9966-5fb002d6dac6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "00255325-4342-439e-a1d3-e6699cf0bad6", "36f7b0a3-f28f-4909-b35d-6a82cac0726d" });

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTimeLike",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTimeLike",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTimeLike",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTimeLike",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTimeLike",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTimeLike",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTimeLike",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTimeLike",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTimeLike",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTimeLike",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateSave",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateSave",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateSave",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateSave",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateSave",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateSave",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateSave",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateSave",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateSave",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Saves",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateSave",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishDate",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishDate",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishDate",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishDate",
                value: new DateTime(2024, 7, 19, 20, 23, 37, 879, DateTimeKind.Local).AddTicks(5476));
        }
    }
}
