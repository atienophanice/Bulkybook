using Bulkybookweb.Data;
using Bulkybookweb.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bulkybookweb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
        // Get
        public IActionResult Create()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View();
        }
        // POST

        public IActionResult Create(Category obj)
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View();
        }
    }
}
