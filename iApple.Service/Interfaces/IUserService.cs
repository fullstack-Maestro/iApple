using iApple.Service.DTOs.Users;

namespace iApple.Service.Interfaces;

public interface IUserService
{
    ValueTask<bool> DeleteAsync(long id);
    ValueTask<UserViewModel> GetByIdAsync(long id);
    ValueTask<List<UserViewModel>> GetAllUsersAsync();
    ValueTask<UserViewModel> CreateAsync(UserCreationModel userCreation);
    ValueTask<UserViewModel> UpdatePasswordAsync(long id, string password);
    ValueTask<UserViewModel> UpdateAsync(long id, UserUpdateModel userUpdate);
}