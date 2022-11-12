using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class editUserRoleDataTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("6d396537-b68b-4d87-a9c7-d1eec0ff5254"));

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("f44502d3-ebd1-46e7-b193-e67c94000bea"));

            migrationBuilder.DropColumn(
                name: "User_Role",
                table: "UserRole");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "UserRole",
                nullable: true);

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "CreatedDate", "Role", "UpdatedDate" },
                values: new object[] { new Guid("151bba20-d366-4429-a506-923538385725"), new DateTime(2022, 11, 11, 15, 27, 34, 536, DateTimeKind.Local).AddTicks(5574), "Admin", new DateTime(2022, 11, 11, 15, 27, 34, 539, DateTimeKind.Local).AddTicks(3932) });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "CreatedDate", "Role", "UpdatedDate" },
                values: new object[] { new Guid("73d12ecf-9b52-443e-9289-2b2176491d82"), new DateTime(2022, 11, 11, 15, 27, 34, 539, DateTimeKind.Local).AddTicks(5699), "Anonymous", new DateTime(2022, 11, 11, 15, 27, 34, 539, DateTimeKind.Local).AddTicks(5725) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("151bba20-d366-4429-a506-923538385725"));

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("73d12ecf-9b52-443e-9289-2b2176491d82"));

            migrationBuilder.DropColumn(
                name: "Role",
                table: "UserRole");

            migrationBuilder.AddColumn<int>(
                name: "User_Role",
                table: "UserRole",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "CreatedDate", "UpdatedDate", "User_Role" },
                values: new object[] { new Guid("6d396537-b68b-4d87-a9c7-d1eec0ff5254"), new DateTime(2022, 11, 11, 15, 24, 50, 153, DateTimeKind.Local).AddTicks(6545), new DateTime(2022, 11, 11, 15, 24, 50, 156, DateTimeKind.Local).AddTicks(3164), 0 });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "CreatedDate", "UpdatedDate", "User_Role" },
                values: new object[] { new Guid("f44502d3-ebd1-46e7-b193-e67c94000bea"), new DateTime(2022, 11, 11, 15, 24, 50, 156, DateTimeKind.Local).AddTicks(4826), new DateTime(2022, 11, 11, 15, 24, 50, 156, DateTimeKind.Local).AddTicks(4851), 1 });
        }
    }
}
