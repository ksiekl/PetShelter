using PetShelter.Pages;

namespace PetShelter.Data;

public class PendingRequestsService
{
    private readonly ApplicationDbContext _context;

    public PendingRequestsService(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Tuple<Pet, PetAdoption>> GetRequestedAdoptions()
    {
        return _context.Adoptions
            .Where(adoption => adoption.Status == Status.Requested)
            .Join(_context.Pets, adoption => adoption.PetId, pet => pet.Id, (adoption, pet) => new Tuple<Pet, PetAdoption>(pet, adoption))
            .ToList();
    }
    
    public List<Tuple<Pet, Delivery>> GetRequestedDeliveries()
    {
        return _context.Deliveries
            .Where(delivery => delivery.Status == Status.Requested)
            .Join(_context.Pets, delivery => delivery.NewPetId, pet => pet.Id, (delivery, pet) => new Tuple<Pet, Delivery>(pet, delivery))
            .ToList();
    }
    
    public List<Tuple<Pet, PetAdoption>> GetAcceptedAdoptions()
    {
        return _context.Adoptions
            .Where(adoption => adoption.Status == Status.Accepted)
            .Join(_context.Pets, adoption => adoption.PetId, pet => pet.Id, (adoption, pet) => new Tuple<Pet, PetAdoption>(pet, adoption))
            .ToList();
    }
    
    public List<Tuple<Pet, Delivery>> GetAcceptedDeliveries()
    {
        return _context.Deliveries
            .Where(delivery => delivery.Status == Status.Accepted)
            .Join(_context.Pets, delivery => delivery.NewPetId, pet => pet.Id, (delivery, pet) => new Tuple<Pet, Delivery>(pet, delivery))
            .ToList();
    }

    public async Task UpdateAdoptions(PetAdoption newAdoption)
    {
        var oldAdoption = await _context.Adoptions.FindAsync(newAdoption.Id);
        oldAdoption!.Status = newAdoption.Status;
        await _context.SaveChangesAsync();
    }
    
    public async Task UpdateDeliveries(Delivery newDelivery)
    {
        var oldDelivery = await _context.Deliveries.FindAsync(newDelivery.Id);
        oldDelivery!.Status = newDelivery.Status;
        await _context.SaveChangesAsync();
    }
}