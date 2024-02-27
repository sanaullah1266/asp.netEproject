using Microsoft.AspNetCore.Mvc;

namespace E_project_book_mangement_system.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult dashboard()
        {
            return View();
        }

    }
}
