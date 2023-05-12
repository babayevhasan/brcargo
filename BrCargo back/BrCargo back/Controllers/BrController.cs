

using Microsoft.AspNetCore.Mvc;

namespace BrCargo_back.Controllers
{
    public class BrController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
