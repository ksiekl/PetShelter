using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PetShelter.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Delivery> Deliveries { get; set; }
    public DbSet<PetAdoption> Adoptions { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        // Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>().HasData(new User()
        {
            Id = 1,
            Name = "Kabco",
            Pets = new List<Pet>(),
            SurName = "Siera"
        });
        modelBuilder.Entity<Pet>().HasData(new List<Pet>
        {
            new Pet()
            {
                Id = 1,
                Name = "Jerry",
                Type = "Doggo",
                Breed = "Cavalier",
                Age = 1,
                Picture = "Pets/Dogs/Jerry.jpg",
                UserId = "1",
                Description = "Likes arson a little too much."
            },
            new Pet()
            {
                Id = 2,
                Name = "Bruno",
                Type = "Dog",
                Breed = "BadBoi",
                Age = 7,
                Picture = "Pets/Dogs/Bruno.jpeg",
                UserId = "1",
                Description = "Will scream."
            },
            new Pet()
            {
                Id = 3,
                Name = "Punťo",
                Type = "Dog",
                Breed = "GoodBoi",
                Age = 14,
                Picture = "Pets/Dogs/Punto.jpg",
                UserId = "1",
                Description = "Eats your house."

            },
            new Pet()
            {
                Id = 4,
                Name = "Cuki",
                Type = "Cat",
                Breed = "StreetSmart",
                Age = 2,
                Picture = "Pets/Cats/Lusia.jpg",
                UserId = "1",
                Description = "Is a lil angel."

            },
            new Pet()
            {
                Id = 5,
                Name = "Pacco",
                Type = "Bird",
                Breed = "Parrot",
                Age = 1,
                Picture = "Pets/Birds/Pacco.jpeg",
                UserId = "1",
                Description = "Will alarm in case of intrusion."

            },
            new Pet()
            {
                Id = 6,
                Name = "Cuki",
                Type = "Cat",
                Breed = "Cavalier",
                Age = 1,
                Picture = "Pets/Dogs/Jerry.jpg",
                UserId = "1",
                Description = "Likes arson a little too much."

            },
            new Pet()
            {
                Id = 7,
                Name = "Cuki",
                Type = "Cat",
                Picture = "Pets/Dogs/Jerry.jpg",
                UserId = "1",
                Description = "Likes arson a little too much."

            },
        });
         
    }
}