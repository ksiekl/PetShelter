namespace PetShelter.Data;

public class UserRequestsService
{
    private readonly ApplicationDbContext _context;

    public UserRequestsService(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Tuple<Pet, Status>> GetAdoptions(string? userId)
    {
        var usersAdoptions = _context.Adoptions
            .Where(adoption => adoption.UserId == userId)
            .Join(_context.Pets, adoption => adoption.PetId, pet => pet.Id,
                (adoption, pet) => new Tuple<Pet, Status>(pet, adoption.Status))
            .ToList();
        return usersAdoptions;
    }

    public List<Tuple<Pet, Status>> GetDeliveries(string? userId)
    {
        var userDeliveries = _context.Deliveries
            .Where(delivery => delivery.UserId == userId)
            .Join(_context.Pets, delivery => delivery.NewPetId, pet => pet.Id,
                (delivery, pet) => new Tuple<Pet, Status>(pet, delivery.Status))
            .ToList();
        return userDeliveries;
    }
}