using Microsoft.EntityFrameworkCore;
using Propagator.Infrastucture.Entities;

namespace Propagator.Infrastucture.Helpers;

public class DataSeeder
{
    private readonly ModelBuilder modelBuilder;

    public DataSeeder(ModelBuilder modelBuilder)
    {
        this.modelBuilder = modelBuilder;
    }

    public void Seed()
    {
        modelBuilder.Entity<Employee>().HasData(
               new Employee() { Id = 1, FirstName = "John", LastName = "Doe", Salary = 1000 },
               new Employee() { Id = 2, FirstName = "John", LastName = "Doe", Salary = 2000 },
               new Employee() { Id = 3, FirstName = "John", LastName = "Doe", Salary = 3000 },
               new Employee() { Id = 4, FirstName = "John", LastName = "Doe", Salary = 4000 },
               new Employee() { Id = 5, FirstName = "John", LastName = "Doe", Salary = 5000 },
               new Employee() { Id = 6, FirstName = "John", LastName = "Doe", Salary = 6000 },
               new Employee() { Id = 7, FirstName = "John", LastName = "Doe", Salary = 7000 },
               new Employee() { Id = 8, FirstName = "John", LastName = "Doe", Salary = 8000 },
               new Employee() { Id = 9, FirstName = "John", LastName = "Doe", Salary = 9000 },
               new Employee() { Id = 10, FirstName = "John", LastName = "Doe", Salary = 10000 },
               new Employee() { Id = 11, FirstName = "John", LastName = "Doe", Salary = 11000 },
               new Employee() { Id = 12, FirstName = "John", LastName = "Doe", Salary = 12000 },
               new Employee() { Id = 13, FirstName = "John", LastName = "Doe", Salary = 13000 },
               new Employee() { Id = 14, FirstName = "John", LastName = "Doe", Salary = 14000 },
               new Employee() { Id = 15, FirstName = "John", LastName = "Doe", Salary = 15000 },
               new Employee() { Id = 16, FirstName = "John", LastName = "Doe", Salary = 16000 },
               new Employee() { Id = 17, FirstName = "John", LastName = "Doe", Salary = 17000 },
               new Employee() { Id = 18, FirstName = "John", LastName = "Doe", Salary = 18000 },
               new Employee() { Id = 19, FirstName = "John", LastName = "Doe", Salary = 19000 },
               new Employee() { Id = 20, FirstName = "John", LastName = "Doe", Salary = 20000 }
        );
    }
}
