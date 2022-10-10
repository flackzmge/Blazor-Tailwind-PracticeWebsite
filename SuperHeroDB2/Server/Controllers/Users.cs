using Microsoft.AspNetCore.Mvc;
using SuperHeroDB.Shared;

namespace SuperHeroDB.Server.Controllers
{
    public class Users : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
