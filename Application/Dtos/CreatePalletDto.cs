
namespace Application.Dtos
{
    public class CreatePalletDto
    {
        public string CodeProduct { get; set; }

        public DateTime EntryDate { get; set; } = DateTime.Now;
    }
}
