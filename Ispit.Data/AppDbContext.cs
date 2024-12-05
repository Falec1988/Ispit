using Ispit.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace Ispit.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<ShoppingItem> ShoppingItems { get; set; }
}