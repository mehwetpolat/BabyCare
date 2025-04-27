using BabyCare.Context;
using BabyCare.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClassController : Controller
    {
        private readonly BabyCareContext _context;

        public ClassController(BabyCareContext context)
        {
            _context = context;
        }

        public IActionResult ClassList()
        {
            var values = _context.Classes.Include(x => x.Team).ToList();
            return View(values);
        }

        public IActionResult DeleteClass(int id)
        {
            var value = _context.Classes.Find(id);
            _context.Classes.Remove(value);
            _context.SaveChanges();

            return RedirectToAction("ClassList");
        }

        [HttpGet]
        public IActionResult UpdateClass(int id)
        {
            List<SelectListItem> values = (from x in _context.Teams.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.NameSurname,
                                               Value = x.TeamId.ToString()
                                           }).ToList();
            ViewBag.v = values;

            var value = _context.Classes.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateClass(Class classes)
        {
            _context.Classes.Update(classes);
            _context.SaveChanges();
            return RedirectToAction("ClassList");
        }

        [HttpGet]
        public IActionResult CreateClass()
        {
            List<SelectListItem> values = (from x in _context.Teams.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.NameSurname,
                                               Value = x.TeamId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult CreateClass(Class classes)
        {
            _context.Classes.Add(classes);
            _context.SaveChanges();
            return RedirectToAction("ClassList");
        }
    }
}
