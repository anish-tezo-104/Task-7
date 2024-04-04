using EMS.DB.Models;
using Microsoft.EntityFrameworkCore;

namespace EMS.DB.Context;
public class EMSContext : DbContext
{

    public DbSet<Employee> Employee { get; set; }
    public DbSet<Role> Role { get; set; }
    public DbSet<Department> Department { get; set; }
    public DbSet<Project> Project { get; set; }
    public DbSet<Location> Location { get; set; }

    private readonly string _connectionString;

    public EMSContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
     => options.UseSqlServer(_connectionString);
}