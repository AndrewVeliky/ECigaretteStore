using System;
using System.Data.Entity;
using ElectronicCigarette.Domain.Entities;

namespace ElectronicCigarette.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
