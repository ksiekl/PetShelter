using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PetShelter.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        // Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public DbSet<Pet> Pets { get; set; }
    public DbSet<Delivery> Deliveries { get; set; }
    public DbSet<PetAdoption> Adoptions { get; set; }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     base.OnModelCreating(modelBuilder);
    //     modelBuilder.Entity<User>().HasData(new User
    //     {
    //         Id = 1,
    //         Name = "Kabco",
    //         Pets = new List<Pet>(),
    //         SurName = "Siera"
    //     });
    //     modelBuilder.Entity<Pet>().HasData(new List<Pet>
    //     {
    //         new()
    //         {
    //             Id = 1,
    //             Name = "Bruno",
    //             Type = "Dog",
    //             Breed = "BadBoi",
    //             Age = 7,
    //             Picture = "Pets/Dogs/Bruno.jpeg",
    //             UserId = "1",
    //             Description = "Will scream."
    //         },
    //         new()
    //         {
    //             Id = 2,
    //             Name = "Cuki",
    //             Type = "Cat",
    //             Breed = "StreetSmart",
    //             Age = 2,
    //             Picture = "Pets/Cats/Lusia.jpg",
    //             UserId = "1",
    //             Description = "Is a lil angel."
    //         },
    //         new()
    //         {
    //             Id = 3,
    //             Name = "Punťo",
    //             Type = "Dog",
    //             Breed = "GoodBoi",
    //             Age = 14,
    //             Picture = "Pets/Dogs/Punto.jpg",
    //             UserId = "1",
    //             Description = "Will share a spliff."
    //         },
    //
    //
    //         new()
    //         {
    //             Id = 4,
    //             Name = "Pacco",
    //             Type = "Bird",
    //             Breed = "Parrot",
    //             Age = 1,
    //             Picture = "Pets/Birds/Pacco.jpeg",
    //             UserId = "1",
    //             Description = "Will alarm in case of intrusion."
    //         },
    //         new()
    //         {
    //             Id = 5,
    //             Name = "Jerry",
    //             Type = "Doggo",
    //             Breed = "Cavalier",
    //             Age = 1,
    //             Picture = "Pets/Dogs/Jerry.jpg",
    //             UserId = "1",
    //             Description = "Likes arson a little too much."
    //         },
    //         new()
    //         {
    //             Id = 6,
    //             Name = "Tono",
    //             Type = "Cat",
    //             Breed = "Street Mix",
    //             Age = 1,
    //             Picture = "Pets/Cats/Tono.jpeg",
    //             UserId = "1",
    //             Description = "Prefers to be called Antonio."
    //         },
    //         new()
    //         {
    //             Id = 7,
    //             Name = "Tweety",
    //             Type = "Bird",
    //             Picture = "Pets/Birds/Tweety.jpg",
    //             UserId = "1",
    //             Description = "Cheeky little rascal."
    //         },
    //         new()
    //         {
    //             Id = 8,
    //             Name = "Pepe",
    //             Type = "Cat",
    //             Picture = "Pets/Cats/Pepe.jpeg",
    //             UserId = "1",
    //             Description = "Understands spanish commands."
    //         },
    //         new()
    //         {
    //             Id = 9,
    //             Name = "Minnie",
    //             Type = "Bird",
    //             Picture = "Pets/Birds/Minnie.jpg",
    //             UserId = "1",
    //             Description = "Has intrusive thoughts."
    //         },
    //         new()
    //         {
    //             Id = 10,
    //             Name = "Pancake",
    //             Type = "Cat",
    //             Picture = "Pets/Cats/Pancake.jpeg",
    //             UserId = "1",
    //             Description = "Tries to hold the darkness in, usually succeeds."
    //         }
    //     });
    // }
}