using Application.Dtos;
using Domain.Dtos;
using MediatR;

namespace Application.UseCases.Pallets.Commands
{
    public class CreatePalletCommand : IRequest<CreatePalletDto>
    {
        public string CodeProduct { get; set; }
    }
}
