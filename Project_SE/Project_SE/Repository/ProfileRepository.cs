/*﻿using Project_SE.Data;
using Project_SE.Models;
using Microsoft.EntityFrameworkCore;
using Project_SE.Models;



public class ProfileRepository : IProfileRepository
{
    private readonly ApplicationDbContext _context;

    public ProfileRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Profile> GetByIdAsync(int id) =>
        await _context.Profiles.Include(p => p.User).FirstOrDefaultAsync(p => p.Id == id);

    public async Task<Profile> GetByUserIdAsync(string userId) =>
        await _context.Profiles.Include(p => p.User).FirstOrDefaultAsync(p => p.UserId == userId);

    public async Task<IEnumerable<Profile>> GetAllAsync() =>
        await _context.Profiles.Include(p => p.User).ToListAsync();

    public async Task AddAsync(Profile profile)
    {
        _context.Profiles.Add(profile);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Profile profile)
    {
        _context.Profiles.Update(profile);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var profile = await GetByIdAsync(id);
        if (profile != null)
        {
            _context.Profiles.Remove(profile);
            await _context.SaveChangesAsync();
        }
    }
}
*/
