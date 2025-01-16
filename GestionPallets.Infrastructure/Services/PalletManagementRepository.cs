using GestionPallets.Application.Common;
using GestionPallets.Domain.Entities;
using GestionPallets.Infrastructure.Persistence;

namespace GestionPallets.Infrastructure.Services
{
    public class PalletManagementRepository : IPalletManagementRepository
    {
        private readonly AppDbContext _context;

        public PalletManagementRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<int> CreatePallet(PalletEntity Pallet)
        {
           var result = await _context.Pallets.AddAsync(Pallet);
            await _context.SaveChangesAsync();
            return result.Entity.Id;
        }

        public Task<int> DeletePallet(int PalletId)
        {
            var Pallet = _context.Pallets.FirstOrDefault(s => s.Id == PalletId);
            if (Pallet != null)
            {
                _context.Pallets.Remove(Pallet);
                return _context.SaveChangesAsync();
            }

            return Task.FromResult(PalletId);
        }

        public Task<IEnumerable<PalletEntity>> GetAllPallets()
        {
            var Pallets = _context.Pallets.ToList();
            return Task.FromResult(Pallets.AsEnumerable());
        }

        public Task<int> UpdatePallet(PalletEntity Pallet)
        {
            var existingPallet = _context.Pallets.FirstOrDefault(s => s.Id == Pallet.Id);
            if (existingPallet != null)
            {
                return _context.SaveChangesAsync();
            }
            return Task.FromResult(Pallet.Id);
        }
    }
}
