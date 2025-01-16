using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionPallets.Domain.Entities
{
    public class MotionEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public PalletEntity Pallet { get; set; }

        public ProductEntity Product { get; set; }

        public LocationEntity Location { get; set; }

        public DateTime Date { get; set; }
    }
}
