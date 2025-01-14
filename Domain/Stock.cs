using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Stock
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public int ProductCode { get; set; }

    [ForeignKey("ProductCode")]
    public Product Product { get; set; }

    [Required]
    public int PalletId { get; set; }

    [ForeignKey("PalletId")]
    public Pallet Pallet { get; set; }

    [Required]
    public DateTime EntryDate { get; set; }

    public DateTime? ExitDate { get; set; }

    [Required]
    public Location Location { get; set; }

    public string Status { get; set; }

    public ICollection<Motion> StockMovements { get; set; }
}
