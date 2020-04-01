using ContactApplication.Models;
using ContactApplication.Models.Entity;
using ContactApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ContactApplication.Controllers
{
    [Route("api/contact")]
    [ApiController]
    public class ContactsAPIController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactsAPIController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact([FromBody] ContactRequestDto contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(await _contactService.CreateContact(contact));
        }

        [HttpGet]
        public async Task<ActionResult> GetAllContact()
        {
            return Ok(await _contactService.GetAllContact());
        }

        //[HttpGet]
        //public async Task<ActionResult> GetAllContactById()
        //{
        //    return Ok(await _contactService.GetAllContact());
        //}
    }
}
