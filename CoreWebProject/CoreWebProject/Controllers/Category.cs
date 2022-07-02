using Microsoft.AspNetCore.Mvc;

namespace CoreWebProject.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
