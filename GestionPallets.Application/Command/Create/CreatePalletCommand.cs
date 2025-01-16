using GestionPallets.Application.Common;
using GestionPallets.Domain.Entities;
using MediatR;

namespace GestionPallets.Application.Command.Create
{
    public class CreatePalletCommand : IRequest<int>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }

        public int Price { get; set; }

        public string? Category { get; set; }
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
                    Name = request.Name,
                    Description = request.Description
                }


            };

            return await _repository.CreatePallet(palletEntity);
        }
    }
}
