using GestionPallets.Application.Common;
using GestionPallets.Domain.Dtos.Request;
using GestionPallets.Domain.Entities;
using MediatR;

namespace GestionPallets.Application.Command.Create
{
    public class CreatePalletCommand : IRequest<int>
    {
        public string CodeProduct { get; set; }

        public DateTime Date { get; set; }

        public LocationRequest? Location { get; set; }
    }

    public class CreatePalletCommandHandler : IRequestHandler<CreatePalletCommand, int>
    {
        private readonly IPalletManagementRepository _repository;

        public CreatePalletCommandHandler(IPalletManagementRepository repository) => _repository = repository;

        public async Task<int> Handle(CreatePalletCommand request, CancellationToken cancellationToken)
        {
            var palletEntity = new PalletEntity
            {
               Date = DateTime.Now,
                Product = new ProductEntity
                {
                    Code = request.CodeProduct
                },
                Location = request.Location != null ? new LocationEntity
                {
                    Column = request.Location.Column,
                    Row = request.Location.Row
                } : null


            };

            return await _repository.CreatePallet(palletEntity);
        }
    }
}
