using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TennisApp.Controllers
{
    public class CoachesController : Controller
    {
        [Authorize(Roles = "Coach")]
        public IActionResult CoachDashboard()
        {
            return View();
        }
    }
}
