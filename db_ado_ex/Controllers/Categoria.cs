using Microsoft.AspNetCore.Mvc;

namespace db_ado_ex.Controllers
{
    public class Categoria : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
