using iApple.Domain.Entities.User;
using iApple.Service.DTOs.Users;
using iApple.Service.Interfaces;
using iApple.Service.Mappers;

namespace iApple.Service.Services;

public class UserService : IUserService
{
    /*
    private List<User> users = new List<User>();
    UserReader reader = new UserReader();
    UserWriter writer = new UserWriter();

    public async ValueTask<UserViewModel> CreateAsync(UserCreationModel userCreation)
    {
        // add exceptions later
        users = reader.Read();

        var user = Mapper.MapTo<User>(userCreation);
        user.Id = users.Count == 0 ? 1 : users.Last().Id + 1;
        users.Add(user);

        writer.Write(users);

        return Mapper.MapTo<UserViewModel>(user);
    }

    public async ValueTask<bool> DeleteAsync(long id)
    {
        users = reader.Read();

        var exist = users.FirstOrDefault(x => x.Id == id);
        if (exist is null)
        {
            throw new Exception("User is not found");
        }
        users.Add(exist);

        writer.Write(users);
        return true;
    }

    public async ValueTask<List<UserViewModel>> GetAllUsersAsync()
    {
        users = reader.Read();
        return Mapper.MapTo<UserViewModel>(users);
    }

    public async ValueTask<UserViewModel> GetByIdAsync(long id)
    {
        users = reader.Read();
        var exist = users.FirstOrDefault(x => x.Id == id);
        if (exist is null)
        {
            throw new Exception("User is not found");
        }
        return Mapper.MapTo<UserViewModel>(exist);
    }

    public async ValueTask<UserViewModel> UpdateAsync(long id, UserUpdateModel userUpdate)
    {
        users = reader.Read();
        var exist = users.FirstOrDefault(x => x.Id == id);
        if (exist is null)
        {
            throw new Exception("User is not found");
        }
        exist.Id = id;
        exist.Phone = userUpdate.Phone;
        exist.Email = userUpdate.Email;
        exist.Country = userUpdate.Country;
        exist.LastName = userUpdate.LastName;
        exist.FirstName = userUpdate.FirstName;
        exist.DateOfBirth = userUpdate.DateOfBirth;

        writer.Write(users);

        return Mapper.MapTo<UserViewModel>(exist);
    }

    public async ValueTask<UserViewModel> UpdatePasswordAsync(long id, string password)
    {
        users = reader.Read();
        var exist = users.FirstOrDefault(x => x.Id == id);
        if (exist is null)
        {
            throw new Exception("User is not found");
        }
        exist.Password = password;

        return Mapper.MapTo<UserViewModel>(exist);
    }
    */
    public ValueTask<UserViewModel> CreateAsync(UserCreationModel userCreation)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<List<UserViewModel>> GetAllUsersAsync()
    {
        throw new NotImplementedException();
    }

    public ValueTask<UserViewModel> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<UserViewModel> UpdateAsync(long id, UserUpdateModel userUpdate)
    {
        throw new NotImplementedException();
    }

    public ValueTask<UserViewModel> UpdatePasswordAsync(long id, string password)
    {
        throw new NotImplementedException();
    }
}