using GestionPallets.Application.Common;
using GestionPallets.Domain.Entities;
using MediatR;

namespace GestionPallets.Application.Command.Update
{
    public class UpdateStockCommand : IRequest<int>
    {
        public PalletEntity Pallet { get; set; }
    }

    public class UpdateStockCommandHandler : IRequestHandler<UpdateStockCommand, int>
    {
        private readonly IPalletManagementRepository _stockManagementRepository;

        public UpdateStockCommandHandler(IPalletManagementRepository stockManagementRepository)
        {
            _stockManagementRepository = stockManagementRepository;
        }

        public async Task<int> Handle(UpdateStockCommand request, CancellationToken cancellationToken)
        {
            return await _stockManagementRepository.UpdatePallet(request.Pallet);
        }
    }
}
