using Microsoft.EntityFrameworkCore;

namespace ShoppingListApp.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
}