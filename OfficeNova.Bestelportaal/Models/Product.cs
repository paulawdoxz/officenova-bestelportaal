using System.ComponentModel.DataAnnotations;

namespace OfficeNova.Bestelportaal.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Naam { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Categorie { get; set; } = string.Empty;

        [StringLength(500)]
        public string Omschrijving { get; set; } = string.Empty;

        [Range(0.01, 10000)]
        public decimal Prijs { get; set; }

        public int Voorraad { get; set; }

        public string Tags { get; set; } = string.Empty;
    }
}