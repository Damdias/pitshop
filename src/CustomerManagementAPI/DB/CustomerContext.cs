
using Microsoft.EntityFrameworkCore;
using CustomerManagementAPI.Models;
using CustomerManagementAPI.Configuration;

namespace CustomerManagementAPI.DB;
public class CustomerDbContext : DbContext
{
    public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
           : base(options)
    {

    }
    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.ApplyConfiguration(new CustomerConfiguration());

    }
}