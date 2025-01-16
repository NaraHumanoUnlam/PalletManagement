using GestionPallets.Domain.Entities;

namespace GestionPallets.Application.Common
{
    public interface IPalletManagementRepository
    {
        Task<int> CreatePallet(PalletEntity Pallet);
        Task<int> UpdatePallet(PalletEntity Pallet);
        Task<int> DeletePallet(int PalletId);
        Task<IEnumerable<PalletEntity>> GetAllPallets();
    }
}
