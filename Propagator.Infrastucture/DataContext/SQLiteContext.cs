using Microsoft.EntityFrameworkCore;
using Propagator.Infrastucture.Entities;
using Propagator.Infrastucture.Helpers;

namespace Propagator.Infrastucture.DataContext;

public class SQLiteContext : DbContext
{
    public SQLiteContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        new DataSeeder(modelBuilder).Seed();
    }

    public DbSet<Employee> Employees { get; set; }
}
