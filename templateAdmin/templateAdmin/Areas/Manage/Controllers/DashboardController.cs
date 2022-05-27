using Microsoft.AspNetCore.Mvc;

namespace templateAdmin.Areas.Manage.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
