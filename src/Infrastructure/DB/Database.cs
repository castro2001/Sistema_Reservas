
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace SqlAccess.DB
{
    public class Database
    {
        private string _connectionString = string.Empty;   

        public Database()
        {
           var builder =  new  ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            _connectionString = builder.GetSection("ConnectionStrings:ConexionSQL").Value;
        }

        public string GetConnection()
        {
            return _connectionString;
        }
    }
}
