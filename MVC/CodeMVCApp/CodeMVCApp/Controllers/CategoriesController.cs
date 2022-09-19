using CodeMVCApp.Data;
using CodeMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeMVCApp.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly CodeMVCAppContext _context;

        public CategoriesController(CodeMVCAppContext context)
        {
            _context = context;
        }
        List<Category> db = new List<Category>  {
              new Category {CategoryID = 1, CategoryName="Beverages",       Description="Soft drinks, coffees, teas, beers, and ales"},
              new Category {CategoryID = 2, CategoryName="Condiments",      Description="Sweet and savory sauces, relishes, spreads, and seasonings"},
              new Category {CategoryID = 3, CategoryName="Confections",     Description="Desserts, candies, and sweet breads"},
              new Category {CategoryID = 4, CategoryName="Dairy Products",  Description="Cheeses"},
              new Category {CategoryID = 5, CategoryName=@"Grains/Cereals", Description="Breads, crackers, pasta, and cereal"},
              new Category {CategoryID = 6, CategoryName=@"Meat/Poultry",   Description="Prepared meats"},
              new Category {CategoryID = 7, CategoryName="Produce",         Description="Dried fruit and bean curd"},
              new Category {CategoryID = 8, CategoryName="Seafood",         Description="Seaweed and fish"},
              new Category {CategoryID = 9, CategoryName="Seafood",         Description="Test"}
            };
        // GET: Categories
        public async Task<IActionResult> Index()
        {
            return View(db);
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category
                .FirstOrDefaultAsync(m => m.CategoryID == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryName,Description")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }




        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryID,CategoryName,Description")] Category category)
        {
            if (id != category.CategoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CategoryID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category
                .FirstOrDefaultAsync(m => m.CategoryID == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BuAlanAdiTamamenDegisikOlabilir(int id)
        {
            if (_context.Category == null)
            {
                return Problem("Entity set 'CodeMVCAppContext.Category'  is null.");
            }
            var category = await _context.Category.FindAsync(id);
            if (category != null)
            {
                _context.Category.Remove(category);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return _context.Category.Any(e => e.CategoryID == id);
        }

        // Get Post   -> Deneme
        [HttpGet]
        public IActionResult Deneme(int id) { return View(); }

        [HttpPost]
        [ActionName("Deneme")]
        public IActionResult Deneme_Post(int id) { return View(); }
    }
}
