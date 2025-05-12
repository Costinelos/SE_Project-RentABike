using Project_SE.Models;
public interface IProfileService
{
    Task<Profile> GetProfileByUserIdAsync(string userId);
    Task UpdateProfileAsync(Profile profile);
    Task CreateProfileAsync(Profile profile);
    Task DeleteProfileAsync(int id);
}
