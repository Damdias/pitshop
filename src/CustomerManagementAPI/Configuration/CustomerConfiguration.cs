using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CustomerManagementAPI.Models;

namespace CustomerManagementAPI.Configuration;
public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.Property(a => a.Address).HasMaxLength(100);
        builder.Property(a => a.City).HasMaxLength(100);
        builder.Property(a => a.EmailAddress).HasMaxLength(100);
        builder.Property(a => a.Name).HasMaxLength(100);
        builder.Property(a => a.PostalCode).HasMaxLength(100);
        builder.Property(a => a.TelephoneNumber).HasMaxLength(20);
    }
}
