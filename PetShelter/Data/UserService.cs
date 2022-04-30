using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace PetShelter.Data;

public class UserService
{
    private readonly ApplicationDbContext _context;

    public UserService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<List<User>> GetAllUsers()
    {
        return await _context.Users.ToListAsync();
    }
}