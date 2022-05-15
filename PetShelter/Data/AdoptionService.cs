namespace PetShelter.Data;

public class AdoptionService
{
    private readonly ApplicationDbContext _context;

    public AdoptionService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAdoption(PetAdoption adoption)
    {
        _context.Adoptions.Add(adoption);
        await _context.SaveChangesAsync();
    }
}