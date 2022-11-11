using Microsoft.AspNetCore.Mvc;

namespace Bulkybookweb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
