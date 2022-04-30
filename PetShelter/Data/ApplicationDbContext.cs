using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PetShelter.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Pet> Pets { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     
    //     modelBuilder.Entity<Pet>().HasData(new List<Pet>{
    //         new Pet
    //         {
    //             Id = 5,
    //             Name = "StyleZ",
    //             Age = 22,
    //             Breed = "dog",
    //             Type = "Aggresive"
    //         },
    //         new Pet
    //         {
    //             Id = 1,
    //             Name = "Cuketa",
    //             Age = 1,
    //             Breed = "Cat",
    //             Type = "Horny"
    //         },
    //         new Pet
    //         {
    //             Id = 2,
    //             Name = "Akim",
    //             Age = 3,
    //             Breed = "dog",
    //             Type = "Depressed"
    //         },
    //     });
    //     base.OnModelCreating(modelBuilder);
    // }
    
}