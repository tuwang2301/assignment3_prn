using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_Client.Controllers
{ 
    public class MyOrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
