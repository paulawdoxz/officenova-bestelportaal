using Microsoft.AspNetCore.Mvc;
using OfficeNova.Bestelportaal.Data;
using OfficeNova.Bestelportaal.Models;

namespace OfficeNova.Bestelportaal.Controllers
{
    public class ProductsController : Controller
    {
        private readonly OfficeNovaContext _context;

        public ProductsController(OfficeNovaContext context)
        {
            _context = context;
        }

        // GET: /Products?zoekterm=...&categorie=...
        public IActionResult Index(string? zoekterm, string? categorie)
        {
            var query = _context.Producten.AsQueryable();

            // Filter op zoekterm (naam + omschrijving)
            if (!string.IsNullOrWhiteSpace(zoekterm))
            {
                query = query.Where(p =>
                    p.Naam.Contains(zoekterm) ||
                    p.Omschrijving.Contains(zoekterm) ||
                    p.Tags.Contains(zoekterm));
            }

            // Filter op categorie
            if (!string.IsNullOrWhiteSpace(categorie))
            {
                query = query.Where(p => p.Categorie == categorie);
            }

            // Lijst met alle categorieën voor het dropdown-menu
            ViewBag.Categories = _context.Producten
                .Select(p => p.Categorie)
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            // Onthoud de huidige zoekterm en categorie
            ViewBag.Zoekterm = zoekterm;
            ViewBag.HuidigeCategorie = categorie;

            var producten = query.ToList();
            return View(producten);
        }

        // GET: /Products/Details/5
        public IActionResult Details(int id)
        {
            var product = _context.Producten.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}