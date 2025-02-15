﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Propagator.Infrastucture.DataContext;

#nullable disable

namespace Propagator.Infrastucture.Migrations
{
    [DbContext(typeof(SQLiteContext))]
    partial class SQLiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("Propagator.Infrastucture.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Salary")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "John",
                            LastName = "Doe",
                            Salary = 1000
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "James",
                            LastName = "Doe",
                            Salary = 2000
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Joan",
                            LastName = "Doe",
                            Salary = 3000
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Jane",
                            LastName = "Doe",
                            Salary = 4000
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Jonathan",
                            LastName = "Doe",
                            Salary = 5000
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Jack",
                            LastName = "Doe",
                            Salary = 6000
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "Jay",
                            LastName = "Doe",
                            Salary = 7000
                        },
                        new
                        {
                            Id = 8,
                            FirstName = "Jules",
                            LastName = "Doe",
                            Salary = 8000
                        },
                        new
                        {
                            Id = 9,
                            FirstName = "Jimmy",
                            LastName = "Doe",
                            Salary = 9000
                        },
                        new
                        {
                            Id = 10,
                            FirstName = "Jaime",
                            LastName = "Doe",
                            Salary = 10000
                        },
                        new
                        {
                            Id = 11,
                            FirstName = "Henry",
                            LastName = "Doe",
                            Salary = 11000
                        },
                        new
                        {
                            Id = 12,
                            FirstName = "Dwayne",
                            LastName = "Doe",
                            Salary = 12000
                        },
                        new
                        {
                            Id = 13,
                            FirstName = "Hugh",
                            LastName = "Doe",
                            Salary = 13000
                        },
                        new
                        {
                            Id = 14,
                            FirstName = "Rose",
                            LastName = "Doe",
                            Salary = 14000
                        },
                        new
                        {
                            Id = 15,
                            FirstName = "Emily",
                            LastName = "Doe",
                            Salary = 15000
                        },
                        new
                        {
                            Id = 16,
                            FirstName = "Ana",
                            LastName = "Doe",
                            Salary = 16000
                        },
                        new
                        {
                            Id = 17,
                            FirstName = "Jason",
                            LastName = "Doe",
                            Salary = 17000
                        },
                        new
                        {
                            Id = 18,
                            FirstName = "Jackie",
                            LastName = "Doe",
                            Salary = 18000
                        },
                        new
                        {
                            Id = 19,
                            FirstName = "Bruce",
                            LastName = "Doe",
                            Salary = 19000
                        },
                        new
                        {
                            Id = 20,
                            FirstName = "Keanu",
                            LastName = "Doe",
                            Salary = 20000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
