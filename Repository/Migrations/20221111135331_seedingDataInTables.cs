using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class seedingDataInTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("c8ef64a5-65d1-45cd-b240-30f61a777508"), new DateTime(2022, 11, 11, 15, 53, 30, 240, DateTimeKind.Local).AddTicks(5366), "TV", new DateTime(2022, 11, 11, 15, 53, 30, 240, DateTimeKind.Local).AddTicks(5392) },
                    { new Guid("759c950d-4eff-4315-9c5a-f95f1eb68778"), new DateTime(2022, 11, 11, 15, 53, 30, 240, DateTimeKind.Local).AddTicks(6214), "Laptop", new DateTime(2022, 11, 11, 15, 53, 30, 240, DateTimeKind.Local).AddTicks(6230) },
                    { new Guid("f00829d3-db27-4fde-8bb3-75bf418d82fe"), new DateTime(2022, 11, 11, 15, 53, 30, 240, DateTimeKind.Local).AddTicks(6269), "Sound System", new DateTime(2022, 11, 11, 15, 53, 30, 240, DateTimeKind.Local).AddTicks(6271) }
                });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("567b8222-bd08-4d84-95ce-3369c9ab0cf6"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 11, 15, 53, 30, 237, DateTimeKind.Local).AddTicks(4661), new DateTime(2022, 11, 11, 15, 53, 30, 237, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("ad70cd85-c933-4e4c-9be5-82679530f79f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 11, 15, 53, 30, 236, DateTimeKind.Local).AddTicks(794), new DateTime(2022, 11, 11, 15, 53, 30, 237, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "BirthDate", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "Gender", "ImageUrl", "IsBlocked", "LastName", "LoginType", "PhoneNumber", "UpdatedDate", "UserName", "UserRoleId" },
                values: new object[] { new Guid("f26f330c-05c9-4b5d-9323-0a35aa0cdc8d"), true, new DateTime(1990, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 11, 15, 53, 30, 239, DateTimeKind.Local).AddTicks(5508), "admin@gmail.com", true, "Admin", 1, null, false, null, 3, "01111111999", new DateTime(2022, 11, 11, 15, 53, 30, 239, DateTimeKind.Local).AddTicks(5535), "admin", new Guid("ad70cd85-c933-4e4c-9be5-82679530f79f") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableQty", "CategoryId", "CreatedDate", "Desc", "Name", "Price", "UpdatedDate" },
                values: new object[] { new Guid("68b4070e-2254-47f6-91b3-66d059ac88b1"), 4000, new Guid("c8ef64a5-65d1-45cd-b240-30f61a777508"), new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(2457), "75 inch Samsung TV Tournament Subscription package + free TOD inclusive one month package with 1 subscription", "75 inch Samsung TV Tournament Subscription package + free TOD inclusive one month package with 1 subscription", 24000f, new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableQty", "CategoryId", "CreatedDate", "Desc", "Name", "Price", "UpdatedDate" },
                values: new object[] { new Guid("c9541fc0-cab7-4db8-b8cd-20e3228fa7d5"), 4000, new Guid("759c950d-4eff-4315-9c5a-f95f1eb68778"), new DateTime(2022, 11, 11, 15, 53, 30, 240, DateTimeKind.Local).AddTicks(7670), "HP 255 G8 Laptop - Ryzen 5 3500U, 8 GB RAM, 1 TB HDD, AMD Radeon Vega 8 Graphics, 15.6-Inch HD, DOS - Asteroid silver", "HP 255 G8 Laptop - Ryzen 5 3500U, 8 GB RAM, 1 TB HDD, AMD Radeon Vega 8 Graphics, 15.6-Inch HD, DOS - Asteroid silver", 11100f, new DateTime(2022, 11, 11, 15, 53, 30, 240, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableQty", "CategoryId", "CreatedDate", "Desc", "Name", "Price", "UpdatedDate" },
                values: new object[] { new Guid("39e44bcc-3b80-4bd7-9f76-dc23911b4a28"), 4000, new Guid("759c950d-4eff-4315-9c5a-f95f1eb68778"), new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(2303), "SAMSUNG Galaxy Tab S8 Ultra 14.6in - 256GB, 12GB RAM, 5G, WiFi - Graphite", "SAMSUNG Galaxy Tab S8 Ultra 14.6in - 256GB, 12GB RAM, 5G, WiFi - Graphite", 32000f, new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(2328) });

            migrationBuilder.InsertData(
                table: "ProductDiscounts",
                columns: new[] { "Id", "CreatedDate", "DiscountQty", "DiscountValue", "ProductId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("56ada7dd-4176-46a3-8053-bec9741b6e80"), new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6702), 2, 10f, new Guid("68b4070e-2254-47f6-91b3-66d059ac88b1"), new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6711) },
                    { new Guid("c5709294-653a-41b5-8cb9-6259fb57856f"), new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6721), 3, 25f, new Guid("68b4070e-2254-47f6-91b3-66d059ac88b1"), new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6723) },
                    { new Guid("13db5c7d-5e59-42e7-b273-928705693929"), new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(3974), 2, 5f, new Guid("c9541fc0-cab7-4db8-b8cd-20e3228fa7d5"), new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(3984) },
                    { new Guid("a0e9d928-3d97-4bab-8185-372139fc88dd"), new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6487), 3, 15f, new Guid("c9541fc0-cab7-4db8-b8cd-20e3228fa7d5"), new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6496) },
                    { new Guid("ac91ea37-0ae6-4ba3-83b4-e7e12cfcc6e9"), new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6558), 2, 7f, new Guid("39e44bcc-3b80-4bd7-9f76-dc23911b4a28"), new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6561) },
                    { new Guid("665401d2-99f8-4209-815d-369e7e41048d"), new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6571), 3, 20f, new Guid("39e44bcc-3b80-4bd7-9f76-dc23911b4a28"), new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6573) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f00829d3-db27-4fde-8bb3-75bf418d82fe"));

            migrationBuilder.DeleteData(
                table: "ProductDiscounts",
                keyColumn: "Id",
                keyValue: new Guid("13db5c7d-5e59-42e7-b273-928705693929"));

            migrationBuilder.DeleteData(
                table: "ProductDiscounts",
                keyColumn: "Id",
                keyValue: new Guid("56ada7dd-4176-46a3-8053-bec9741b6e80"));

            migrationBuilder.DeleteData(
                table: "ProductDiscounts",
                keyColumn: "Id",
                keyValue: new Guid("665401d2-99f8-4209-815d-369e7e41048d"));

            migrationBuilder.DeleteData(
                table: "ProductDiscounts",
                keyColumn: "Id",
                keyValue: new Guid("a0e9d928-3d97-4bab-8185-372139fc88dd"));

            migrationBuilder.DeleteData(
                table: "ProductDiscounts",
                keyColumn: "Id",
                keyValue: new Guid("ac91ea37-0ae6-4ba3-83b4-e7e12cfcc6e9"));

            migrationBuilder.DeleteData(
                table: "ProductDiscounts",
                keyColumn: "Id",
                keyValue: new Guid("c5709294-653a-41b5-8cb9-6259fb57856f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f26f330c-05c9-4b5d-9323-0a35aa0cdc8d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39e44bcc-3b80-4bd7-9f76-dc23911b4a28"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68b4070e-2254-47f6-91b3-66d059ac88b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9541fc0-cab7-4db8-b8cd-20e3228fa7d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("759c950d-4eff-4315-9c5a-f95f1eb68778"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8ef64a5-65d1-45cd-b240-30f61a777508"));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("567b8222-bd08-4d84-95ce-3369c9ab0cf6"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 11, 15, 29, 47, 247, DateTimeKind.Local).AddTicks(7131), new DateTime(2022, 11, 11, 15, 29, 47, 247, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: new Guid("ad70cd85-c933-4e4c-9be5-82679530f79f"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 11, 15, 29, 47, 245, DateTimeKind.Local).AddTicks(9716), new DateTime(2022, 11, 11, 15, 29, 47, 247, DateTimeKind.Local).AddTicks(5572) });
        }
    }
}
