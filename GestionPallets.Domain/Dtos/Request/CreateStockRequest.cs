using GestionPallets.Domain.Entities;

namespace GestionPallets.Domain.Dtos.Request
{
    public class CreateStockRequest
    {
        public StockEntity Stock { get; set; }
    }
}
