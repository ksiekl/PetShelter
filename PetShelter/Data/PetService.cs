using Microsoft.EntityFrameworkCore;
using PetShelter.Pages;

namespace PetShelter.Data;

public class PetService
{
    private readonly ApplicationDbContext _context;

    public PetService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<List<Pet>> GetAllPets()
    {
        return await _context.Pets.ToListAsync();
    }

    public async Task<List<Pet>> GetAvailablePets()
    {
        var deliveredPets = _context.Pets
            .Join(_context.Deliveries, pet => pet.Id, delivery => delivery.NewPetId,
                (pet, delivery) => new Tuple<Pet, Delivery>(pet, delivery))
            .AsEnumerable()
            .Where(p => p.Item2.Status == Status.Finished)
            .Select(pet => pet.Item1)
 
            .ToHashSet();

        var adoptedPets =  _context.Pets
            .Join(_context.Adoptions, pet => pet.Id, adoption => adoption.PetId,
                (pet, adoption) => new Tuple<Pet, PetAdoption>(pet, adoption))
            .AsEnumerable()
            .Where(p => p.Item2.Status != Status.Declined)
            .Select(pet => pet.Item1)
            
            .ToHashSet();

        deliveredPets.ExceptWith(adoptedPets);
        return deliveredPets.ToList();

    }

    public async Task AddPet(Pet pet)
    {
        _context.Pets.Add(pet);
        await _context.SaveChangesAsync();
    }
    
    public Pet GetOnePet(int petId)
    {
        return Enumerable.FirstOrDefault(_context.Pets, pet => pet.Id == petId)!;
    }

    public async Task<List<Pet>> GetUsersAdoptions(string userId)
    {
       return await _context.Adoptions
            .Where(adoption => adoption.Status == Status.Finished && adoption.UserId == userId)
            .Join(_context.Pets, a => a.PetId, p => p.Id, (adoption, pet) => pet)
            .ToListAsync();
    }
}