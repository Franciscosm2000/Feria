using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpeños.MODELO.POJO
{
    class EmpeñoFran : ConnectionToSQL
    {
        public DataTable BuscarDato(string dato)
        {
            DataTable res = new DataTable();

            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = coneccion;

                    comando.CommandText = "sp_BuscarEmpeño";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@dato", dato);
                    SqlDataAdapter leer = new SqlDataAdapter(comando);
                    leer.Fill(res);
                    comando.Parameters.Clear();

                    return res;
                }
            }//Primer fin usign
        }
    }
}
