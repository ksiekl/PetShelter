using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PetShelter.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Pet> Pets { get; set; }
    public DbSet<User> Users { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<User>().HasData(new User()
        {
            Id = 1,
            Name = "Kabco",
            Pets = new List<Pet>(),
            SurName = "Siera"
        });
        modelBuilder.Entity<Pet>().HasData(new Pet()
        {
            Id = 1,
            Name = "Cuki",
            Type = "Cat",
            Breed = "Cavalier",
            Age = 1,
            Picture = "Pets/Dogs/Jerry.jpg",
            UserId = 1,

        });
        Console.WriteLine(Directory.GetCurrentDirectory());
        base.OnModelCreating(modelBuilder);
    }
    
}