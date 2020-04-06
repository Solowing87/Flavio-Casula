using Microsoft.AspNetCore.Mvc;

namespace src.Controllers
{
    public class CoursesController : Controller 
    {
        public IActionResult Index()
        {
            return Content("Sono Index");
        }

        public IActionResult Detail(string id)
        {
                return Content($"sono Detail. Ho ricevuto l'id {id}");
        }
    }
}