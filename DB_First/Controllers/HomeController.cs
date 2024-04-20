
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DB_First.Controllers
{
    public class HomeController : Controller
    {
       
        
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
