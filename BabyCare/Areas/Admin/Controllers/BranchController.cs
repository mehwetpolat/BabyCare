using BabyCare.Context;
using BabyCare.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow.ValueContentAnalysis;

namespace BabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BranchController : Controller
    {
        private readonly BabyCareContext _context;

        public BranchController(BabyCareContext context)
        {
            _context = context;
        }

        public IActionResult BranchList()
        {
            var values = _context.Branches.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateBranch()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBranch(Branch branch)
        {
            _context.Branches.Add(branch);
            _context.SaveChanges();
            return RedirectToAction("BranchList");
        }

        public IActionResult DeleteBranch(int id)
        {
            var value = _context.Branches.Find(id);
            _context.Branches.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("BranchList");
        }

        [HttpGet]
        public IActionResult UpdateBranch(int id)
        {
            var value = _context.Branches.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateBranch(Branch branch)
        {
            _context.Branches.Update(branch);
            _context.SaveChanges();
            return RedirectToAction("BranchList");
        }
    }
}
