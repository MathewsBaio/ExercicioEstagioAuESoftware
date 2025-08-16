using ExercicioEstagio.Data;
using ExercicioEstagio.Infra;
using ExercicioEstagio.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEstagio.Repositories
{
    public class ContactRepo
    {
        private ConnectionService conn = new ConnectionService();
        private IdGenerator idGen = new IdGenerator();

        public async Task InsertContactAsync(Contact newContact)
        {
            using (var connection = conn.GetConnection())
            {
                await connection.OpenAsync();

                int nextId = await idGen.GetNextId("Contatos", "CodContato", connection);

                using (var command = new OleDbCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Contatos (CodContato, Cidade, Data, Nome, Sexo) VALUES (?, ?, ?, ?, ?)";
                    
                    command.Parameters.AddWithValue("CodContato", nextId);

                    command.Parameters.AddWithValue("Cidade", newContact.City);

                    var dataParameter = new OleDbParameter("Data", DateTime.Now);
                    dataParameter.OleDbType = OleDbType.Date;
                    command.Parameters.Add(dataParameter);

                    command.Parameters.AddWithValue("Nome", newContact.Name);

                    string genderValue = newContact.Gender == GenderEnum.Masculino ? "M" : "F";
                    command.Parameters.AddWithValue("Sexo", genderValue);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task UpdateContactAsync(int id, Contact newContact)
        {
            using (var connection = conn.GetConnection())
            {
            }
        }

        public async Task DeleteContactAsync(int id)
        {
            using (var connection = conn.GetConnection())
            {
            }
        }

        public async Task<List<Contact>> GetAllContactsAsync()
        {
            using (var connection = conn.GetConnection())
            {
                List<Contact> contacts = new List<Contact>();
               
                return contacts;
            }
        }

        public async Task<List<Contact>> GetContactsFilterByNameAsync(int id)
        {
            using (var connection = conn.GetConnection())
            {
                List<Contact> contacts = new List<Contact>();
               
                return contacts;
            }
        }



    }
}
