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

        public async Task UpdateContactAsync(Contact newContact)
        {
            using (var connection = conn.GetConnection())
            {
                await connection.OpenAsync();

                using (var command = new OleDbCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Contatos SET Cidade = ?, Nome = ?, Sexo = ? WHERE CodContato = ?";

                    command.Parameters.AddWithValue("Cidade", newContact.City);

                    command.Parameters.AddWithValue("Nome", newContact.Name);

                    string genderValue = newContact.Gender == GenderEnum.Masculino ? "M" : "F";
                    command.Parameters.AddWithValue("Sexo", genderValue);

                    command.Parameters.AddWithValue("CodContato", newContact.Id);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteContactAsync(int id)
        {
            using (var connection = conn.GetConnection())
            {
                await connection.OpenAsync();

                using (var command = new OleDbCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Contatos WHERE CodContato = ?";
                    command.Parameters.AddWithValue("CodContato", id);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<List<Contact>> GetAllContactsAsync()
        {
            using (var connection = conn.GetConnection())
            {
                await connection.OpenAsync();

                List<Contact> contacts = new List<Contact>();

                using (var command = new OleDbCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT CodContato, Cidade, Data, Nome, Sexo FROM Contatos";

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Contact c = new Contact
                            {
                                Id = reader.GetInt32(0),
                                City = reader.GetString(1),
                                RegisterDate = Convert.ToDateTime(reader["Data"]),
                                Name = reader.GetString(3),
                                Gender = reader.GetString(4) == "M" ? GenderEnum.Masculino : GenderEnum.Feminino
                            };

                            contacts.Add(c);
                        }
                    }
                }

                return contacts;
            }
        }

    }
}
