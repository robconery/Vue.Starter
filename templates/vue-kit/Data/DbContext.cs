using Vue.Kit.Models;
using Microsoft.EntityFrameworkCore;
namespace Vue.Kit.Data;

public class AppContext: DbContext
{
    public AppContext(DbContextOptions<AppContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("users");
    }

}