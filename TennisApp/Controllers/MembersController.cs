using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TennisApp.Controllers
{
    public class MembersController : Controller
    {
        [Authorize(Roles = "Member")]
        public IActionResult MemberDashboard()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
