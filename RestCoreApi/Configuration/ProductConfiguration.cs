using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestCoreApi.Models;
using System;

namespace RestCoreApi.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
            (
                new Product
                {
                    ProductID = new Guid ("1b38d689-2c05-4942-afc8-4c08a74062af"),
                    ProductName = "Game Console",
                    Price = 400
                },
                new Product
                {
                    ProductID = new Guid("7fe1ec96-46a8-4921-a53b-8fade6c44f96"),
                    ProductName = "Gamepad",
                    Price = 50
                },
                new Product
                {
                    ProductID = new Guid("82add73e-2509-4d4c-9d29-4e4240588870"),
                    ProductName = "Additional Storage",
                    Price = 50
                },
                new Product
                {
                    ProductID = new Guid("63b683d6-ecc1-4a41-871f-0e4ee09d9906"),
                    ProductName = "Latest AAA Game",
                    Price = 100
                }
            );
        }
    }
}
