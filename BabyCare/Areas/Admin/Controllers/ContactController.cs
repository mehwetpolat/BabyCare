using BabyCare.Context;
using BabyCare.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly BabyCareContext _context;

        public ContactController(BabyCareContext context)
        {
            _context = context;
        }

        public IActionResult ContactList()
        {
            var values = _context.Contacts.ToList();
            return View(values);
        }

            public IActionResult DeleteContact(int id)
            {
                var value = _context.Contacts.Find(id);
                if (value != null)
                {
                    _context.Contacts.Remove(value);
                    _context.SaveChanges();
                }
                return RedirectToAction("ContactList");
            }
    }
}
