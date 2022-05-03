namespace PetShelter.Data;

public class UserRequestsService
{
    private readonly ApplicationDbContext _context;

    public UserRequestsService(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public List<Pet> GetAdoptions(string? userId)
    {
        var usersAdoptions = _context.Adoptions
            .Where(adoption => adoption.UserId == userId)
            .Join(_context.Pets, adoption => adoption.PetId, pet => pet.Id, (adoption, pet) => pet)
            .ToList();
        return usersAdoptions;
    }

    public List<Pet> GetDeliveries(string? userId)
    {
        var userDeliveries = _context.Deliveries
            .Where(delivery => delivery.UserId == userId)
            .Join(_context.Pets, delivery => delivery.NewPetId, pet => pet.Id, (delivery, pet) => pet)
            .ToList();
        return userDeliveries;
    }
}