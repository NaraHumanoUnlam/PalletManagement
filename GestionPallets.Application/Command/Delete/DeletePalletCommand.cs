using GestionPallets.Application.Common;
using MediatR;

namespace GestionPallets.Application.Command.Delete
{
    public class DeletePalletCommand : IRequest<int>
    {
        public int StockId { get; set; }
    }

    public class DeleteStockCommandHandler : IRequestHandler<DeletePalletCommand, int>
    {

        private readonly IPalletManagementRepository _repository;

        public DeleteStockCommandHandler(IPalletManagementRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(DeletePalletCommand request, CancellationToken cancellationToken)
        {
            // Aquí va la lógica para eliminar el stock y retornar el resultado
            return await _repository.DeletePallet(request.StockId);
        }
    }
}
