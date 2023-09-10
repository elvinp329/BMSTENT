using Microsoft.AspNetCore.Mvc;

namespace BMSTENTAZ.MVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
