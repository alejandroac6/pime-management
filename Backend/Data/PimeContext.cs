using Microsoft.EntityFrameworkCore;
using Backend.Models;

namespace Backend.Data;

public class PimeContext : DbContext
{
    public PimeContext(DbContextOptions<PimeContext> options)
        : base(options)
    {
    }

    public DbSet<Company> Companies => Set<Company>();
    public DbSet<Worker> Workers => Set<Worker>();
    public DbSet<Project> Projects => Set<Project>();
}