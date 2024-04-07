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

        //[HttpPost]
        //public IActionResult AddListitems([FromBody] List<tblStudent> rowData1)
        //{
        //    return Json("Some message");
        //}

        //[HttpPost]
        //public IActionResult AddListitems([FromBody] string Name)
        //{
        //    return Json("Some message");
        //}

        [HttpPost]
        public IActionResult AddListitems([FromBody] stdVM vv)
        {
            if (vv != null)
            {
                try
                {
                    int[] intArr = new int[vv.Students.Count];
                    //List<int> StidList = new List<int>();
                    int ctr = 0;
                    foreach (var student in vv.Students)
                    {
                        _context.tblStudent.Add(student);
                        _context.SaveChanges();
                        intArr[ctr] = student.Id;
                        //StidList.Add(_context.SaveChanges());
                        ctr++;
                    }
                                        
                    foreach (var stid in intArr)
                    {
                        StudentClass stud = new StudentClass();
                        stud.StudId = stid;
                        stud.ClassId = vv.ClassId;
                        _context.StudentClass.Add(stud);
                        _context.SaveChanges();
                    }                    
                    return Json("Data saved successfully");
                }
                catch (Exception ex)
                {
                    // Log the exception or handle it appropriately
                    return BadRequest("Error saving data: " + ex.Message);
                }
            }
            return BadRequest("No data received");
        }

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
