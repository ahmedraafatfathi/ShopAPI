using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class editUserRoleDataTbl_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("151bba20-d366-4429-a506-923538385725"));

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("73d12ecf-9b52-443e-9289-2b2176491d82"));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "CreatedDate", "Role", "UpdatedDate" },
                values: new object[] { new Guid("ad70cd85-c933-4e4c-9be5-82679530f79f"), new DateTime(2022, 11, 11, 15, 29, 47, 245, DateTimeKind.Local).AddTicks(9716), "Admin", new DateTime(2022, 11, 11, 15, 29, 47, 247, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "CreatedDate", "Role", "UpdatedDate" },
                values: new object[] { new Guid("567b8222-bd08-4d84-95ce-3369c9ab0cf6"), new DateTime(2022, 11, 11, 15, 29, 47, 247, DateTimeKind.Local).AddTicks(7131), "Anonymous", new DateTime(2022, 11, 11, 15, 29, 47, 247, DateTimeKind.Local).AddTicks(7152) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("567b8222-bd08-4d84-95ce-3369c9ab0cf6"));

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("ad70cd85-c933-4e4c-9be5-82679530f79f"));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "CreatedDate", "Role", "UpdatedDate" },
                values: new object[] { new Guid("151bba20-d366-4429-a506-923538385725"), new DateTime(2022, 11, 11, 15, 27, 34, 536, DateTimeKind.Local).AddTicks(5574), "Admin", new DateTime(2022, 11, 11, 15, 27, 34, 539, DateTimeKind.Local).AddTicks(3932) });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "CreatedDate", "Role", "UpdatedDate" },
                values: new object[] { new Guid("73d12ecf-9b52-443e-9289-2b2176491d82"), new DateTime(2022, 11, 11, 15, 27, 34, 539, DateTimeKind.Local).AddTicks(5699), "Anonymous", new DateTime(2022, 11, 11, 15, 27, 34, 539, DateTimeKind.Local).AddTicks(5725) });
        }
    }
}
