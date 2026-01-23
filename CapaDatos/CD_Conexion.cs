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
        private string cadena = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DB_GestionFeria;Integrated Security=True";

        public SqlConnection LeerCadena()
        {
            return new SqlConnection(cadena);
        }
    }
}
