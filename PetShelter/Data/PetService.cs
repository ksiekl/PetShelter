using Microsoft.EntityFrameworkCore;

namespace PetShelter.Data;

public class PetService
{
    private readonly ApplicationDbContext _context;

    public PetService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<List<Pet>> GetAllPersons()
    {
        
        return await _context.Pets.ToListAsync();
    }
    
    public async Task IncrementAgeOfAnimal(int animalId)
    {

        var pet = await _context.Pets.FindAsync(animalId);
        pet!.Age += 1;
        _context.Pets.Update(pet);
        await _context.SaveChangesAsync();
    }
}