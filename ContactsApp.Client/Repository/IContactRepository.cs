using ContactsApp.Client.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactsApp.Client.Repositories
{
    public interface IContactRepository
    {
        Task CreateContact(Contact contact);
        Task DeleteContact(int Id);
        Task<Contact> GetContactById(int id);
        Task<List<Contact>> GetContacts();
        Task UpdateContact(Contact contact);
    }
}