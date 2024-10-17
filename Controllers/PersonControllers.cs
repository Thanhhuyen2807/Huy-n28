using demomvc.Data;
using demomvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using demomvc.Data;
using demomvc.Models;
namespace demomvc.Controllers
{
    public class PersonControllers : Controller
    {
        private readonly ApplicationDbcontext _context;
        public PersonControllers(ApplicationDbcontext context){
            this._context = context;

        }
        public async Task<IActionResult> Index(){
            return View();
        }
        public IActionResult Create(){
        return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,FullName,Address")] Person person){
            return View();
        }
        public async Task<IActionResult> Edit(string id){
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonId,FullName,Address")] Person person)
        {
            return View();
        }
        public async Task<IActionResult> Delete(string id){
            return View();
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id){
            return View();
        }
        private bool PersonExists(string id){
            return true;
            
        }
    }



}