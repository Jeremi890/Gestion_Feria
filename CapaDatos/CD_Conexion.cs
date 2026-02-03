using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Conexion
    {
        string cadenaConexionBD = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DB_GestionFeria;Integrated Security=True";
        //"Server=localhost;Database=DB_GestionFeria;Trusted_Connection=True;";

        public SqlConnection LeerCadena()
        {
            return new SqlConnection(cadenaConexionBD);
        }
    }
}
