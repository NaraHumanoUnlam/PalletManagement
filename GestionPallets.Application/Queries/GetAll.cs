using GestionPallets.Application.Common;
using GestionPallets.Domain.Entities;
using MediatR;

namespace GestionDepallet.Application.Queries
{
    public class GetAll : IRequest<IEnumerable<PalletEntity>>
    {
    }

    public class GetAllHandler : IRequestHandler<GetAll, IEnumerable<PalletEntity>>
    {
        private readonly IPalletManagementRepository _palletManagementRepository;

        public GetAllHandler(IPalletManagementRepository palletManagementRepository)
        {
            _palletManagementRepository = palletManagementRepository;
        }

        public async Task<IEnumerable<PalletEntity>> Handle(GetAll request, CancellationToken cancellationToken)
        {
            return await _palletManagementRepository.GetAllPallets();
        }
    }
}
