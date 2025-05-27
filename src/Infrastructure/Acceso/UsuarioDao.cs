using System.Data.SqlClient;
using WebApp.Models;

namespace SqlAccess.Acceso
{
    public class UsuarioDao
    {
        public List<UsuarioDao> Listado(){
            var usuarios = new List<Usuario>();
            var c = new DB.Database();
            using (var connection = new SqlConnection(c.GetConnection()))
            {
                connection.Open();
                var query = "SELECT * FROM Usuarios";
              
            }
        }
    }
}
