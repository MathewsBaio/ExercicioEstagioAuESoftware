using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ExercicioEstagio.Infra
{
    internal class IdGenerator
    {
        public async Task<int> GetNextId(string TableName, string IdRowName, OleDbConnection connection)
        {
            using (var command = new OleDbCommand())
            {
                command.Connection = connection;
                command.CommandText = $"SELECT MAX({IdRowName}) FROM {TableName}";
                var result = await command.ExecuteScalarAsync();
                if (result != DBNull.Value && result != null)
                {
                    return Convert.ToInt32(result) + 1;
                } else
                {
                    return 1;
                }
            }
        }
    }
}
