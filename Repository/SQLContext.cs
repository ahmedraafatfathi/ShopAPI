using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class SQLContext : DbContext
    {
        public SQLContext(DbContextOptions<SQLContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<UserRole>().HasData(
            new UserRole
            {
                Id = new Guid("ad70cd85-c933-4e4c-9be5-82679530f79f"),
                CreatedDate = DateTime.Now,
                UpdatedDate= DateTime.Now,
                Role = "Admin"
            },
            new UserRole
            {
                Id = new Guid("567b8222-bd08-4d84-95ce-3369c9ab0cf6"),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Role = "Anonymous"
            });



            modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = new Guid("f26f330c-05c9-4b5d-9323-0a35aa0cdc8d"),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Active = true,
                BirthDate = new DateTime(1990,10,23),
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                FirstName = "Admin",
                Gender = Entities.Enums.Gender.Male,
                IsBlocked= false,
                PhoneNumber = "01111111999",
                UserName = "admin",
                UserRoleId = new Guid("ad70cd85-c933-4e4c-9be5-82679530f79f")
            });




            modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = new Guid("c8ef64a5-65d1-45cd-b240-30f61a777508"),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Name = "TV"
            },
            new Category
            {
                Id = new Guid("759c950d-4eff-4315-9c5a-f95f1eb68778"),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Name = "Laptop"
            },
            new Category
            {
                Id = new Guid("f00829d3-db27-4fde-8bb3-75bf418d82fe"),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Name = "Sound System"
            });

            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = new Guid("c9541fc0-cab7-4db8-b8cd-20e3228fa7d5"),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                CategoryId = new Guid("759c950d-4eff-4315-9c5a-f95f1eb68778"),
                Price = 11100,
                AvailableQty = 4000,
                Name = "HP 255 G8 Laptop - Ryzen 5 3500U, 8 GB RAM, 1 TB HDD, AMD Radeon Vega 8 Graphics, 15.6-Inch HD, DOS - Asteroid silver",
                Desc = "HP 255 G8 Laptop - Ryzen 5 3500U, 8 GB RAM, 1 TB HDD, AMD Radeon Vega 8 Graphics, 15.6-Inch HD, DOS - Asteroid silver"
            },
            new Product
            {
                Id = new Guid("39e44bcc-3b80-4bd7-9f76-dc23911b4a28"),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                CategoryId = new Guid("759c950d-4eff-4315-9c5a-f95f1eb68778"),
                Price = 32000,
                AvailableQty = 4000,
                Name = "SAMSUNG Galaxy Tab S8 Ultra 14.6in - 256GB, 12GB RAM, 5G, WiFi - Graphite",
                Desc = "SAMSUNG Galaxy Tab S8 Ultra 14.6in - 256GB, 12GB RAM, 5G, WiFi - Graphite"
            },
            new Product
            {
                Id = new Guid("68b4070e-2254-47f6-91b3-66d059ac88b1"),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                CategoryId = new Guid("c8ef64a5-65d1-45cd-b240-30f61a777508"),
                Price = 24000,
                AvailableQty = 4000,
                Name = "75 inch Samsung TV Tournament Subscription package + free TOD inclusive one month package with 1 subscription",
                Desc = "75 inch Samsung TV Tournament Subscription package + free TOD inclusive one month package with 1 subscription"
            });


            modelBuilder.Entity<ProductDiscount>().HasData(
            new ProductDiscount
            {
                Id = new Guid("13db5c7d-5e59-42e7-b273-928705693929"),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                ProductId = new Guid("c9541fc0-cab7-4db8-b8cd-20e3228fa7d5"),
                DiscountValue = 5,
                DiscountQty = 2
            },
            new ProductDiscount
            {
                Id = new Guid("a0e9d928-3d97-4bab-8185-372139fc88dd"),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                ProductId = new Guid("c9541fc0-cab7-4db8-b8cd-20e3228fa7d5"),
                DiscountValue = 15,
                DiscountQty = 3
            },
            new ProductDiscount
            {
                Id = new Guid("ac91ea37-0ae6-4ba3-83b4-e7e12cfcc6e9"),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                ProductId = new Guid("39e44bcc-3b80-4bd7-9f76-dc23911b4a28"),
                DiscountValue = 7,
                DiscountQty = 2
            },
            new ProductDiscount
            {
                Id = new Guid("665401d2-99f8-4209-815d-369e7e41048d"),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                ProductId = new Guid("39e44bcc-3b80-4bd7-9f76-dc23911b4a28"),
                DiscountValue = 20,
                DiscountQty = 3
            },
            new ProductDiscount
            {
                Id = new Guid("56ada7dd-4176-46a3-8053-bec9741b6e80"),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                ProductId = new Guid("68b4070e-2254-47f6-91b3-66d059ac88b1"),
                DiscountValue = 10,
                DiscountQty = 2
            },
            new ProductDiscount
            {
                Id = new Guid("c5709294-653a-41b5-8cb9-6259fb57856f"),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                ProductId = new Guid("68b4070e-2254-47f6-91b3-66d059ac88b1"),
                DiscountValue = 25,
                DiscountQty = 3
            });
        }

        public DbSet<AuditLog> AuditLogs { get; set; }


        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<UserPassword> UserPasswords { get; set; }
        public DbSet<RegisterAttempt> RegisterAttempts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDiscount> ProductDiscounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }



    }

}
