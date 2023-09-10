using Microsoft.AspNetCore.Mvc;

namespace BMSTENTAZ.MVC.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
