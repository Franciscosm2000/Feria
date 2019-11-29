using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaEmpeños.MODELO
{
    abstract class ConnectionToSQL
    {
        //String solo lectura 
        private readonly string connectionString;

        //Constructor
        public ConnectionToSQL()
        {
            connectionString = "server = FRANCISCO; Database = Prueba ; integrated security = true";
        }

        //Solo accedido de una clase eradada
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
