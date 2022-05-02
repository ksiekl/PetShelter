using Microsoft.EntityFrameworkCore;

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
    
    public async Task AddPet(Pet pet)
    {
        _context.Pets.Add(pet);
        await _context.SaveChangesAsync();
    }
}