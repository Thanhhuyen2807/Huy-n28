using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using demomvc.Data;
using demomvc.Controllers;
using demomvc.Models;
namespace demomvc.Controllers
{
    public class EmployeeController : Controller

    {
        //Khai bao ApplicationDbContext
        private readonly demomvc.Data.ApplicationDbcontext _context;

        public EmployeeController(ApplicationDbcontext context)
        {
            _context = context;
        }
        //Tra ve view index 1 list danh sach cac ban ghi
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employee.ToListAsync());
        }

        // GET: Student/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .FirstOrDefaultAsync(m => GetEmployeeID(m) == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        private static string GetEmployeeID(Person m)
        {
            return m.EmployeeID;
        }

        public IActionResult Create()
        {
            return View();
        }
         [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeID,FullName")] EmployeeController employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
            
        
        }
          




    


    }
}
       
    
