using Microsoft.AspNetCore.Mvc;

namespace RestauranteDashboard.Presentation.Controllers
{
    public class RestauranteDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
