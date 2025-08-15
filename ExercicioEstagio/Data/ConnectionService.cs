using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace ExercicioEstagio.Data
{
    public class ConnectionService
    {
        private readonly string _connectionString;

        public ConnectionService()
        {
            string pathDB = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"auebd.mdb");
            pathDB = System.IO.Path.GetFullPath(pathDB);

            _connectionString = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={pathDB};";
        }

        public OleDbConnection GetConnection()
        {
            return new OleDbConnection(_connectionString);
        }
    }
}
