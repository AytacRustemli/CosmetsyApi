using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CosmetsyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactManager _contactManager;

        public ContactController(IContactManager contactManager)
        {
            _contactManager = contactManager;
        }

        [HttpGet("getall")]
        public List<Contact> GetAll()
        {
            return _contactManager.GetAllContact();
        }


        [HttpPost("add")]
        public object AddContact(Contact contact)
        {
            _contactManager.Add(contact);
            return Ok("Contact added");
        }
    }
}
