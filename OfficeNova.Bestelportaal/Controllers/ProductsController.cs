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

        // GET: /Products
        public IActionResult Index()
        {
            var producten = _context.Producten.ToList();
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