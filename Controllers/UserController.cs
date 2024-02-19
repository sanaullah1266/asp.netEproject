using E_project_book_mangement_system.context;
using E_project_book_mangement_system.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace E_project_book_mangement_system.Controllers
{
    public class UserController : Controller
    {
       SqlContext sc;

        public UserController(SqlContext sc)
        {
            this.sc = sc;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult about()
        {
            return View();
        }
        public IActionResult cart()
        {
            return View();
        }
        public IActionResult checkout()
        {
            return View();
        }
        public IActionResult register() {
        
            return View();
        }
        [HttpPost]
        public IActionResult register(Register ins)
        {
            sc.registers.Add(ins);
            sc.SaveChanges();
            ModelState.Clear();
            return View();

        }
        public IActionResult login()
        {
            return View();
        }
        public IActionResult shop()
        {
            return View();
        }
        public IActionResult shoplist()
        {
            return View();
        }
        public IActionResult wishlist()
        {

            return View();
        }
        
        public IActionResult productlist()
        {
            return View();
        }

    }
}
