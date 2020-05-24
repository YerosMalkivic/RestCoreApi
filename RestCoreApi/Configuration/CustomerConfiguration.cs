using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestCoreApi.Models;
using System;

namespace RestCoreApi.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData
            (
                new Customer
                {
                    CustomerId = new Guid("d783cd3f-14c3-4912-966c-22ef3a6ae0b2"),
                    Name = "Paulo Hilton Zuchini Silva",
                    Email = "paulo.hilton@gmail.com"
                }
            );
        }
    }
}
