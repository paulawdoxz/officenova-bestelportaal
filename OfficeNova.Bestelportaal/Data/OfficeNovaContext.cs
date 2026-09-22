using Microsoft.EntityFrameworkCore;
using OfficeNova.Bestelportaal.Models;

namespace OfficeNova.Bestelportaal.Data
{
    public class OfficeNovaContext : DbContext
    {
        public OfficeNovaContext(DbContextOptions<OfficeNovaContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Producten { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed-data: 25 fictieve producten
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Naam = "Logitech ERGO M575", Categorie = "Muizen", Omschrijving = "Ergonomische draadloze trackball muis", Prijs = 49.99m, Voorraad = 25, Tags = "ergonomisch,draadloos,premium" },
                new Product { Id = 2, Naam = "Trust Yvi Draadloze Muis", Categorie = "Muizen", Omschrijving = "Goedkope draadloze muis voor flexplekken", Prijs = 12.99m, Voorraad = 100, Tags = "goedkoop,draadloos,compact" },
                new Product { Id = 3, Naam = "Logitech MX Master 3S", Categorie = "Muizen", Omschrijving = "Premium draadloze muis voor professionals", Prijs = 99.99m, Voorraad = 15, Tags = "premium,draadloos,populair" },
                new Product { Id = 4, Naam = "Ergonomische Polssteun", Categorie = "Ergonomie", Omschrijving = "Polssteun tegen polsklachten bij computerwerk", Prijs = 19.99m, Voorraad = 40, Tags = "ergonomisch,thuiswerken" },
                new Product { Id = 5, Naam = "Logitech K380 Toetsenbord", Categorie = "Toetsenborden", Omschrijving = "Stil compact draadloos toetsenbord", Prijs = 39.99m, Voorraad = 30, Tags = "stil,compact,draadloos" },
                new Product { Id = 6, Naam = "Microsoft Surface Keyboard", Categorie = "Toetsenborden", Omschrijving = "Premium draadloos toetsenbord", Prijs = 89.99m, Voorraad = 10, Tags = "premium,draadloos" },
                new Product { Id = 7, Naam = "Ergonomisch Toetsenbord Split", Categorie = "Toetsenborden", Omschrijving = "Split-toetsenbord voor ergonomisch thuiswerken", Prijs = 129.99m, Voorraad = 8, Tags = "ergonomisch,thuiswerken,premium" },
                new Product { Id = 8, Naam = "Jabra Evolve2 40 Headset", Categorie = "Headsets", Omschrijving = "Stille headset voor gedeelde werkplek", Prijs = 119.99m, Voorraad = 20, Tags = "stil,premium,populair" },
                new Product { Id = 9, Naam = "Logitech Zone 300 Headset", Categorie = "Headsets", Omschrijving = "Goedkope headset voor thuiswerken", Prijs = 49.99m, Voorraad = 35, Tags = "goedkoop,thuiswerken" },
                new Product { Id = 10, Naam = "Duurzame Koffiebeker RVS", Categorie = "Facilitair", Omschrijving = "Herbruikbare koffiebeker van gerecycled RVS", Prijs = 14.99m, Voorraad = 60, Tags = "duurzaam,populair" },
                new Product { Id = 11, Naam = "Bamboe Koffiebeker", Categorie = "Facilitair", Omschrijving = "Duurzame koffiebeker van bamboe", Prijs = 9.99m, Voorraad = 80, Tags = "duurzaam,goedkoop" },
                new Product { Id = 12, Naam = "Laptopstandaard Verstelbaar", Categorie = "Laptopstandaards", Omschrijving = "Verstelbare aluminium laptopstandaard", Prijs = 34.99m, Voorraad = 25, Tags = "ergonomisch,thuiswerken" },
                new Product { Id = 13, Naam = "Laptopstandaard Compact", Categorie = "Laptopstandaards", Omschrijving = "Compacte laptopstandaard voor flexplekken", Prijs = 19.99m, Voorraad = 45, Tags = "compact,goedkoop" },
                new Product { Id = 14, Naam = "Bureaustoel Ergo Pro", Categorie = "Bureaustoelen", Omschrijving = "Ergonomische bureaustoel met lumbaalsteun", Prijs = 299.99m, Voorraad = 12, Tags = "ergonomisch,premium,thuiswerken" },
                new Product { Id = 15, Naam = "Bureaustoel Basic", Categorie = "Bureaustoelen", Omschrijving = "Eenvoudige bureaustoel voor kantoor", Prijs = 99.99m, Voorraad = 30, Tags = "goedkoop" },
                new Product { Id = 16, Naam = "Printerinkt Zwart Compatible", Categorie = "Printerinkt", Omschrijving = "Goedkope compatible printerinkt zwart", Prijs = 12.99m, Voorraad = 100, Tags = "goedkoop,populair" },
                new Product { Id = 17, Naam = "Printerinkt Kleur Origineel", Categorie = "Printerinkt", Omschrijving = "Originele printerinkt kleur", Prijs = 34.99m, Voorraad = 50, Tags = "premium" },
                new Product { Id = 18, Naam = "A4 Papier 80 gram", Categorie = "Papier", Omschrijving = "A4 papier 80 gram, 500 vel", Prijs = 4.99m, Voorraad = 200, Tags = "goedkoop,populair" },
                new Product { Id = 19, Naam = "A4 Papier 90 gram", Categorie = "Papier", Omschrijving = "A4 papier 90 gram, 500 vel", Prijs = 6.99m, Voorraad = 150, Tags = "premium" },
                new Product { Id = 20, Naam = "Balpen Zwart 10-pack", Categorie = "Pennen", Omschrijving = "Balpennen zwart, 10 stuks", Prijs = 3.99m, Voorraad = 300, Tags = "goedkoop,populair" },
                new Product { Id = 21, Naam = "Gelpen Blauw 5-pack", Categorie = "Pennen", Omschrijving = "Gelpennen blauw, 5 stuks", Prijs = 5.99m, Voorraad = 200, Tags = "goedkoop" },
                new Product { Id = 22, Naam = "Monitorarm Verstelbaar", Categorie = "Monitorarmen", Omschrijving = "Verstelbare monitorarm voor ergonomisch werken", Prijs = 79.99m, Voorraad = 18, Tags = "ergonomisch,premium" },
                new Product { Id = 23, Naam = "USB-C Hub 7-in-1", Categorie = "IT Accessoires", Omschrijving = "USB-C hub met HDMI, USB en SD", Prijs = 39.99m, Voorraad = 40, Tags = "populair,compact" },
                new Product { Id = 24, Naam = "Webcam Full HD", Categorie = "IT Accessoires", Omschrijving = "Full HD webcam voor thuiswerken", Prijs = 59.99m, Voorraad = 25, Tags = "thuiswerken,populair" },
                new Product { Id = 25, Naam = "Thuiswerkpakket Starter", Categorie = "Thuiswerkpakketten", Omschrijving = "Compleet thuiswerkpakket: toetsenbord, muis, headset, laptopstandaard", Prijs = 149.99m, Voorraad = 20, Tags = "thuiswerken,populair,premium" }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Naam = "Muizen" },
                new Category { Id = 2, Naam = "Toetsenborden" },
                new Category { Id = 3, Naam = "Headsets" },
                new Category { Id = 4, Naam = "Ergonomie" },
                new Category { Id = 5, Naam = "Laptopstandaards" },
                new Category { Id = 6, Naam = "Bureaustoelen" },
                new Category { Id = 7, Naam = "Printerinkt" },
                new Category { Id = 8, Naam = "Papier" },
                new Category { Id = 9, Naam = "Pennen" },
                new Category { Id = 10, Naam = "Monitorarmen" },
                new Category { Id = 11, Naam = "IT Accessoires" },
                new Category { Id = 12, Naam = "Thuiswerkpakketten" },
                new Category { Id = 13, Naam = "Facilitair" }
            );
        }
    }
}