using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OfficeNova.Bestelportaal.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producten",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Categorie = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Omschrijving = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Prijs = table.Column<decimal>(type: "TEXT", nullable: false),
                    Voorraad = table.Column<int>(type: "INTEGER", nullable: false),
                    Tags = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producten", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Naam" },
                values: new object[,]
                {
                    { 1, "Muizen" },
                    { 2, "Toetsenborden" },
                    { 3, "Headsets" },
                    { 4, "Ergonomie" },
                    { 5, "Laptopstandaards" },
                    { 6, "Bureaustoelen" },
                    { 7, "Printerinkt" },
                    { 8, "Papier" },
                    { 9, "Pennen" },
                    { 10, "Monitorarmen" },
                    { 11, "IT Accessoires" },
                    { 12, "Thuiswerkpakketten" },
                    { 13, "Facilitair" }
                });

            migrationBuilder.InsertData(
                table: "Producten",
                columns: new[] { "Id", "Categorie", "Naam", "Omschrijving", "Prijs", "Tags", "Voorraad" },
                values: new object[,]
                {
                    { 1, "Muizen", "Logitech ERGO M575", "Ergonomische draadloze trackball muis", 49.99m, "ergonomisch,draadloos,premium", 25 },
                    { 2, "Muizen", "Trust Yvi Draadloze Muis", "Goedkope draadloze muis voor flexplekken", 12.99m, "goedkoop,draadloos,compact", 100 },
                    { 3, "Muizen", "Logitech MX Master 3S", "Premium draadloze muis voor professionals", 99.99m, "premium,draadloos,populair", 15 },
                    { 4, "Ergonomie", "Ergonomische Polssteun", "Polssteun tegen polsklachten bij computerwerk", 19.99m, "ergonomisch,thuiswerken", 40 },
                    { 5, "Toetsenborden", "Logitech K380 Toetsenbord", "Stil compact draadloos toetsenbord", 39.99m, "stil,compact,draadloos", 30 },
                    { 6, "Toetsenborden", "Microsoft Surface Keyboard", "Premium draadloos toetsenbord", 89.99m, "premium,draadloos", 10 },
                    { 7, "Toetsenborden", "Ergonomisch Toetsenbord Split", "Split-toetsenbord voor ergonomisch thuiswerken", 129.99m, "ergonomisch,thuiswerken,premium", 8 },
                    { 8, "Headsets", "Jabra Evolve2 40 Headset", "Stille headset voor gedeelde werkplek", 119.99m, "stil,premium,populair", 20 },
                    { 9, "Headsets", "Logitech Zone 300 Headset", "Goedkope headset voor thuiswerken", 49.99m, "goedkoop,thuiswerken", 35 },
                    { 10, "Facilitair", "Duurzame Koffiebeker RVS", "Herbruikbare koffiebeker van gerecycled RVS", 14.99m, "duurzaam,populair", 60 },
                    { 11, "Facilitair", "Bamboe Koffiebeker", "Duurzame koffiebeker van bamboe", 9.99m, "duurzaam,goedkoop", 80 },
                    { 12, "Laptopstandaards", "Laptopstandaard Verstelbaar", "Verstelbare aluminium laptopstandaard", 34.99m, "ergonomisch,thuiswerken", 25 },
                    { 13, "Laptopstandaards", "Laptopstandaard Compact", "Compacte laptopstandaard voor flexplekken", 19.99m, "compact,goedkoop", 45 },
                    { 14, "Bureaustoelen", "Bureaustoel Ergo Pro", "Ergonomische bureaustoel met lumbaalsteun", 299.99m, "ergonomisch,premium,thuiswerken", 12 },
                    { 15, "Bureaustoelen", "Bureaustoel Basic", "Eenvoudige bureaustoel voor kantoor", 99.99m, "goedkoop", 30 },
                    { 16, "Printerinkt", "Printerinkt Zwart Compatible", "Goedkope compatible printerinkt zwart", 12.99m, "goedkoop,populair", 100 },
                    { 17, "Printerinkt", "Printerinkt Kleur Origineel", "Originele printerinkt kleur", 34.99m, "premium", 50 },
                    { 18, "Papier", "A4 Papier 80 gram", "A4 papier 80 gram, 500 vel", 4.99m, "goedkoop,populair", 200 },
                    { 19, "Papier", "A4 Papier 90 gram", "A4 papier 90 gram, 500 vel", 6.99m, "premium", 150 },
                    { 20, "Pennen", "Balpen Zwart 10-pack", "Balpennen zwart, 10 stuks", 3.99m, "goedkoop,populair", 300 },
                    { 21, "Pennen", "Gelpen Blauw 5-pack", "Gelpennen blauw, 5 stuks", 5.99m, "goedkoop", 200 },
                    { 22, "Monitorarmen", "Monitorarm Verstelbaar", "Verstelbare monitorarm voor ergonomisch werken", 79.99m, "ergonomisch,premium", 18 },
                    { 23, "IT Accessoires", "USB-C Hub 7-in-1", "USB-C hub met HDMI, USB en SD", 39.99m, "populair,compact", 40 },
                    { 24, "IT Accessoires", "Webcam Full HD", "Full HD webcam voor thuiswerken", 59.99m, "thuiswerken,populair", 25 },
                    { 25, "Thuiswerkpakketten", "Thuiswerkpakket Starter", "Compleet thuiswerkpakket: toetsenbord, muis, headset, laptopstandaard", 149.99m, "thuiswerken,populair,premium", 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Producten");
        }
    }
}
