using Microsoft.AspNetCore.Mvc;

namespace SocialAnalytics.Controllers
{
    public class Empty : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
