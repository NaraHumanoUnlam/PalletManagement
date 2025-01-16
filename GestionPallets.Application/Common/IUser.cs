using GestionPallets.Domain.Entities;

namespace GestionPallets.Application.Common
{
    public interface IUser
    {
        Task<UserEntity> ValidateUserAsync(string username, string password);

        Task<int> CreateUser(UserEntity user);
        Task<int> UpdateUser(UserEntity user);
        Task<int> DeleteUser(int userId);
        Task<IEnumerable<UserEntity>> GetAllUsers();

    }
}
