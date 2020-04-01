using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactApplication.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task<ActionResult> Index()
        {
            return View(await _contactService.GetAllContact());
        }

        public async Task<ActionResult> Delete(int id)
        {
            await _contactService.RemoveContact(id);
            return RedirectToAction("Index");

        }

        public async Task<ActionResult> Details(int id)
        {
            return View(await _contactService.GetContact(id));
        }

    }
}
