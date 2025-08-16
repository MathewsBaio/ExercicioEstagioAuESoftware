using ExercicioEstagio.Models;
using ExercicioEstagio.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEstagio.Services
{
    public class ContactService
    {
        private ContactRepo repo = new ContactRepo();

        public async Task InsertContactAsync(Contact newContact)
        { 
            await repo.InsertContactAsync(newContact);
        }

        public async Task UpdateContactAsync(Contact newContact)
        {
            await repo.UpdateContactAsync(newContact);
        }

        public async Task DeleteContactAsync(int id)
        {
            await repo.DeleteContactAsync(id);
        }

        public async Task<List<Contact>> GetAllContactsAsync()
        {
            return await repo.GetAllContactsAsync();
        }
    }
}
