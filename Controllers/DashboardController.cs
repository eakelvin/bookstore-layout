using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace system.Controllers;

[Authorize]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}