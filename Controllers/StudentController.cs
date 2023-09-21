using Microsoft.AspNetCore.Mvc;

namespace Lab2Web.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
