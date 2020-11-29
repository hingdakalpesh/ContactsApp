using ContactsApi.Data;
using ContactsApi.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    [DisableCors]
    public class ContactsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ContactsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Contact>>> Get()
        {
            return await _context.Contacts.OrderBy(n=>(n.FirstName + n.LastName)).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> Get(int id)
        {
            var contact = await _context.Contacts.FirstOrDefaultAsync(x => x.Id == id);
            if (contact == null) { return NotFound(); }
            return contact;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Contact contact)
        {
            _context.Add(contact);
            await _context.SaveChangesAsync();
            return contact.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Contact contact)
        {

            var contactDB = await _context.Contacts.FirstOrDefaultAsync(x => x.Id == contact.Id);

            if (contactDB == null) { return NotFound(); }

            contactDB.FirstName = contact.FirstName;
            contactDB.LastName = contact.LastName;
            contactDB.Email = contact.Email;
            contactDB.PhoneNumber = contact.PhoneNumber;
            contactDB.Notes = contact.Notes;
            contactDB.Domain = contact.Domain;
            contactDB.Avtar = contact.Avtar;
            contactDB.Company = contact.Company;
            contactDB.JobTitle = contact.JobTitle;
            contactDB.Description = contact.Description;
            contactDB.Logo = contact.Logo;
            contactDB.Industry = contact.Industry;
            contactDB.Tags = contact.Tags;

            _context.Update(contactDB);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var contact = await _context.Contacts.FirstOrDefaultAsync(x => x.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            _context.Remove(contact);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

