using System.Collections.Generic;
using System;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MADAM_Boutique.Models
{
    public static class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.EnsureCreatedAsync();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        ProductName = "Áo Phông 2",
                        Description = "Trông đẹp :))",
                        ImagePath = "ao_phong.jpg",
                        UnitPrice = 22.50,
                        Category = "category2"
                    },
                new Product
                {
                    ProductName = "Áo Khoác 2",
                    Description = "Đẹp",
                    ImagePath = "ao_khoac.jpg",
                    UnitPrice = 15.95,
                    Category = "category3"
                },
                new Product
                {
                    ProductName = "Áo Khoác 2",
                    Description = "Đẹp too :))",
                    ImagePath = "ao_khoac_2.jpg",
                    UnitPrice = 32.99,
                    Category = "category1"
                },
                new Product
                {
                    ProductName = "Áo Sơ Mi 1",
                    Description = "So đẹp",
                    ImagePath = "ao_somi_1.jpg",
                    UnitPrice = 14.95,
                    Category = "category1"
                },
                new Product
                {
                    ProductName = "Áo Sơ Mi 2",
                    Description = "So đẹp",
                    ImagePath = "ao_somi_2.jpg",
                    UnitPrice = 14.95,
                    Category = "category1"
                },
                new Product
                {
                    ProductName = "Quần Jean",
                    Description = "Cute",
                    ImagePath = "quan_jean_1.jpg",
                    UnitPrice = 35.00,
                    Category = "category1"
                },
                new Product
                {
                    ProductName = "Quần Vải",
                    Description = "Thanh Lịch",
                    ImagePath = "quan_vai.jpg",
                    UnitPrice = 14.95,
                    Category = "category1"
                },
                new Product
                {
                    ProductName = "Quần Short",
                    Description = "Cá Tính",
                    ImagePath = "quan_short.jpg",
                    UnitPrice = 12.95,
                    Category = "category1"
                },
                new Product
                {
                    ProductName = "Quần Kaki",
                    Description = "Trẻ trung",
                    ImagePath = "quan_kaki.jpg",
                    UnitPrice = 22.95,
                    Category = "category1"
                });
                context.SaveChanges();
            }
        }
    }
}