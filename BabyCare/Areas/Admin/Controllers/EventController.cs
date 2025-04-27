using BabyCare.Context;
using BabyCare.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EventController : Controller
    {
        private readonly BabyCareContext _context;

        public EventController(BabyCareContext context)
        {
            _context = context;
        }

        public IActionResult EventList()
        {
            var values = _context.Events.ToList();
            return View(values);
        }
        public IActionResult DeleteEvent(int id)
        {
            var value = _context.Events.Find(id);
            _context.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("EventList");
        }

        [HttpGet]
        public IActionResult CreateEvent()
        {
            return View();
        }
        public IActionResult CreateEvent(Event events)
        {
            _context.Events.Add(events);
            _context.SaveChanges();
            return RedirectToAction("EventList");
        }

        [HttpGet]
        public IActionResult UpdateEvent(int id)
        {
            var value = _context.Events.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateEvent(Event events)
        {
            _context.Events.Update(events);
            _context.SaveChanges();
            return RedirectToAction("EventList");
        }

    }
}

