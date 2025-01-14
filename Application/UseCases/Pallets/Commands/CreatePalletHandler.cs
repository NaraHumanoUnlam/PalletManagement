using Application.Dtos;
using MediatR;

namespace Application.UseCases.Pallets.Commands
{
    public class CreatePalletHandler : IRequestHandler<CreatePalletCommand, CreatePalletDto>
    {
        public CreatePalletHandler() { }
        public Task<CreatePalletDto> Handle(CreatePalletCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
