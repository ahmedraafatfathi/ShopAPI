using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class seedingUserRoleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "CreatedDate", "UpdatedDate", "User_Role" },
                values: new object[] { new Guid("6d396537-b68b-4d87-a9c7-d1eec0ff5254"), new DateTime(2022, 11, 11, 15, 24, 50, 153, DateTimeKind.Local).AddTicks(6545), new DateTime(2022, 11, 11, 15, 24, 50, 156, DateTimeKind.Local).AddTicks(3164), 0 });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "CreatedDate", "UpdatedDate", "User_Role" },
                values: new object[] { new Guid("f44502d3-ebd1-46e7-b193-e67c94000bea"), new DateTime(2022, 11, 11, 15, 24, 50, 156, DateTimeKind.Local).AddTicks(4826), new DateTime(2022, 11, 11, 15, 24, 50, 156, DateTimeKind.Local).AddTicks(4851), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("6d396537-b68b-4d87-a9c7-d1eec0ff5254"));

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("f44502d3-ebd1-46e7-b193-e67c94000bea"));
        }
    }
}
