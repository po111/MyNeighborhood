using Microsoft.AspNetCore.Mvc;

namespace MyNeighborhood.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
