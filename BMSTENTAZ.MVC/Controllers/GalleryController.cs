using Microsoft.AspNetCore.Mvc;

namespace BMSTENTAZ.MVC.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
