using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Motion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Pallet Pallet { get; set; }

        public Product Product { get; set; }

        public Location Location { get; set; }

        public DateTime Date { get; set; }
    }
}
