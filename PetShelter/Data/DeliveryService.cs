namespace PetShelter.Data;

public class DeliveryService
{
    private readonly ApplicationDbContext _context;

    public DeliveryService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddDelivery(Delivery delivery)
    {
        _context.Deliveries.Add(delivery);
        await _context.SaveChangesAsync();
    }
}