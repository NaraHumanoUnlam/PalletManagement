using GestionPallets.Domain.Entities;

namespace GestionPallets.Application.Common
{
    public interface IToken
    {
        string GenerateToken(UserEntity user);
    }
}
