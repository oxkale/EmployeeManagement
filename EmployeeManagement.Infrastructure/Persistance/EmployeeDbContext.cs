using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EmployeeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace EmployeeManagement.Infrastructure.Persistance
{
    public class EmployeeDbContext: DbContext
{
    public EmployeeDbContext(
        DbContextOptions<EmployeeDbContext> options)
        : base(options)
    {
    }

    public DbSet<Employee> Employees => Set<Employee>();

    protected override void OnModelCreating(
        ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(x => x.Id);

            entity.Property(x => x.Name)
                .HasMaxLength(200)
                .IsRequired();

            entity.Property(x => x.Department)
                .HasMaxLength(100)
                .IsRequired();

            entity.Property(x => x.Salary)
                .HasPrecision(18, 2);

            entity.Property(x => x.Active)
                .IsRequired();
        });
    }
}
}