using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Additems()
        {
            ViewBag.Student = _context.tblStudent.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Listitems()
        {
            return View(_context.tblStudent.ToList());
        }

        [HttpGet]
        public IActionResult AddListitems()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddListitems([FromBody] List<tblStudent> rowData1)
        {
            return Json("Some message");
        }

        //[HttpPost]
        //public IActionResult AddListitems(stdVM rowData)
        //{
        //    return Json("Some message");
        //}
        //[HttpPost]
        //public IActionResult AddListitems([FromBody] string Name)
        //{
        //    return Json("Some message");
        //}

        //[HttpPost]
        //public IActionResult AddListitems([FromBody] stdVM vv)
        //{
        //    return Json("Some message");
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
