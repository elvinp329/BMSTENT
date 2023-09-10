using Microsoft.AspNetCore.Mvc;

namespace BMSTENTAZ.MVC.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
