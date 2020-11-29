using ContactsApp.Client.Entities;
using ContactsApp.Client.Helpers;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsApp.Client.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private string url = "https://localhost:44318/api/contacts";
        private readonly IHttpService httpService;

        public ContactRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Contact>> GetContacts()
        {
            return await httpService.GetHelper<List<Contact>>(url);
        }

        public async Task<Contact> GetContactById(int id)
        {
            return await httpService.GetHelper<Contact>($"{url}/{id}");
        }

        public async Task CreateContact(Contact contact)
        {
            var response = await httpService.Post(url, contact);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateContact(Contact contact)
        {
            var response = await httpService.Put(url, contact);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteContact(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
