
using metafos.Models.Users;

namespace metafos.Services.Users;

public interface IUserService {
    Task<List<User>> GetUsersAsync();

    Task<bool> CreateUser(User user);
}