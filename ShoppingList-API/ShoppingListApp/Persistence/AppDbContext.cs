using Microsoft.EntityFrameworkCore;
using ShoppingListApp.Persistence.Entities;

namespace ShoppingListApp.Persistence;

public class AppDbContext : DbContext
{
    public DbSet<AppUser> Users { get; set; }
    public DbSet<ShoppingList> ShoppingLists { get; set; }

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // TODO Move to IEntityTypeConfiguration? (https://learn.microsoft.com/en-us/ef/core/modeling/#grouping-configuration)

        modelBuilder.Entity<AppUser>()
            .HasMany<ShoppingList>()
            .WithOne(x => x.Owner)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ShoppingList>()
            .HasMany(x => x.ListItems)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);


        modelBuilder.Entity<ShoppingListItem>()
            .Property(x => x.QuantityType)
            .HasConversion(
                v => v.ToString(),
                v => v.ToEnumValue<QuantityTypeEnum>());
    }
}