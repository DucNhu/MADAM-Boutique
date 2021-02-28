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
                        UnitPrice = 22,
                        Category = "category2"
                    },
                    new Product
                    {
                        ProductName = "Áo Phông 2",
                        Description = "Trông đẹp :))",
                        ImagePath = "ao_phong_1.jpg",
                        UnitPrice = 25.5,
                        Category = "category2"
                    },
                    new Product
                    {
                        ProductName = "Áo Phông 2",
                        Description = "Trông đẹp :))",
                        ImagePath = "ao_phong_2.jpg",
                        UnitPrice = 28.5,
                        Category = "category2"
                    },
                    new Product
                    {
                        ProductName = "Áo Phông 2",
                        Description = "Trông đẹp :))",
                        ImagePath = "ao_phong_3.jpg",
                        UnitPrice = 35.5,
                        Category = "category2"
                    },
                    new Product
                    {
                        ProductName = "Áo Phông 2",
                        Description = "Trông đẹp :))",
                        ImagePath = "ao_phong_4.jpg",
                        UnitPrice = 30.5,
                        Category = "category2"
                    },
                    new Product
                    {
                        ProductName = "Áo Khoác 2",
                        Description = "Đẹp",
                        ImagePath = "ao_khoac.jpg",
                        UnitPrice = 15.90,
                        Category = "category3"
                    },
                    new Product
                    {
                        ProductName = "Áo Khoác 2",
                        Description = "Đẹp too :))",
                        ImagePath = "ao_khoac_1.jpg",
                        UnitPrice = 32.99,
                        Category = "category1"
                    },
                    new Product
                    {
                        ProductName = "Áo Khoác 2",
                        Description = "Đẹp too :))",
                        ImagePath = "ao_khoac_2.jpg",
                        UnitPrice = 35.99,
                        Category = "category1"
                    },
                    new Product
                    {
                        ProductName = "Áo Khoác 2",
                        Description = "Đẹp too :))",
                        ImagePath = "ao_khoac_3.jpg",
                        UnitPrice = 42.59,
                        Category = "category1"
                    },
                    new Product
                    {
                        ProductName = "Áo Khoác 2",
                        Description = "Đẹp too :))",
                        ImagePath = "ao_khoac_4.jpg",
                        UnitPrice = 37.9,
                        Category = "category1"
                    },
                    new Product
                    {
                        ProductName = "Áo Khoác 2",
                        Description = "Đẹp too :))",
                        ImagePath = "ao_khoac_5.jpg",
                        UnitPrice = 32.99,
                        Category = "category1"
                    },
                    new Product
                    {
                        ProductName = "Áo Sơ Mi 1",
                        Description = "So đẹp",
                        ImagePath = "ao_somi.jpg",
                        UnitPrice = 24.95,
                        Category = "category2"
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
                        ProductName = "Áo Sơ Mi 1",
                        Description = "So đẹp",
                        ImagePath = "ao_somi_2.jpg",
                        UnitPrice = 16.95,
                        Category = "category3"
                    },
                    new Product
                    {
                        ProductName = "Áo Sơ Mi 1",
                        Description = "So đẹp",
                        ImagePath = "ao_somi_3.jpg",
                        UnitPrice = 14.95,
                        Category = "category2"
                    },
                    new Product
                    {
                        ProductName = "Áo Sơ Mi 2",
                        Description = "So đẹp",
                        ImagePath = "ao_somi_4.jpg",
                        UnitPrice = 14.95,
                        Category = "category3"
                    },
                    new Product
                    {
                        ProductName = "Quần Jean",
                        Description = "Cute",
                        ImagePath = "quan_jean.jpg",
                        UnitPrice = 35.00,
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
                        ProductName = "Quần Jean",
                        Description = "Cute",
                        ImagePath = "quan_jean_2.jpg",
                        UnitPrice = 37.00,
                        Category = "category1"
                    },
                    new Product
                    {
                        ProductName = "Quần Jean",
                        Description = "Cute",
                        ImagePath = "quan_jean_3.jpg",
                        UnitPrice = 38.00,
                        Category = "category3"
                    },
                    new Product
                    {
                        ProductName = "Quần Jean",
                        Description = "Cute",
                        ImagePath = "quan_jean_4.jpg",
                        UnitPrice = 45.00,
                        Category = "category3"
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
                        ProductName = "Quần Short",
                        Description = "Cá Tính",
                        ImagePath = "quan_short_1.jpg",
                        UnitPrice = 15.95,
                        Category = "category2"
                    },
                    new Product
                    {
                        ProductName = "Quần Short",
                        Description = "Cá Tính",
                        ImagePath = "quan_short_2.jpg",
                        UnitPrice = 17.9,
                        Category = "category2"
                    },
                    new Product
                    {
                        ProductName = "Quần Short",
                        Description = "Cá Tính",
                        ImagePath = "quan_short_3.jpg",
                        UnitPrice = 16.5,
                        Category = "category2"
                    },
                    new Product
                    {
                        ProductName = "Quần Short",
                        Description = "Cá Tính",
                        ImagePath = "quan_short_4.jpg",
                        UnitPrice = 20.95,
                        Category = "category2"
                    },
                    new Product
                    {
                        ProductName = "Quần Kaki",
                        Description = "Trẻ trung",
                        ImagePath = "quan_kaki.jpg",
                        UnitPrice = 24.5,
                        Category = "category1"
                    },
                    new Product
                    {
                        ProductName = "Quần Kaki",
                        Description = "Trẻ trung",
                        ImagePath = "quan_kaki_1.jpg",
                        UnitPrice = 23.45,
                        Category = "category3"
                    },
                    new Product
                    {
                        ProductName = "Quần Kaki",
                        Description = "Trẻ trung",
                        ImagePath = "quan_kaki_2.jpg",
                        UnitPrice = 25.5,
                        Category = "category3"
                    },
                    new Product
                    {
                        ProductName = "Quần Kaki",
                        Description = "Trẻ trung",
                        ImagePath = "quan_kaki_3.jpg",
                        UnitPrice = 24.5,
                        Category = "category3"
                    },
                    new Product
                    {
                        ProductName = "Quần Kaki",
                        Description = "Trẻ trung",
                        ImagePath = "quan_kaki_4.jpg",
                        UnitPrice = 22.95,
                        Category = "category3"
                    });
                context.SaveChanges();
            }
        }
    }
}