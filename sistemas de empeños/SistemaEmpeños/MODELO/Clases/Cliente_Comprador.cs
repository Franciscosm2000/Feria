using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpeños.MODELO.Clases
{
    class Cliente_Comprador  : Persona
    {
        public Cliente_Comprador
        (string nom1, string nom2,
           string apell1, string apell2,
           string tel, string correo)
        {
            this.Nombre1 = nom1;
            this.Nombre2 = nom2;
            this.Apellido1 = apell1;
            this.Apellido2 = apell2;
            this.Tel = tel;
            this.Correo = correo;
        }

        //Metodos
       
        public DataTable BuscarDatos(string datos)
        {
            DataTable res = new DataTable();
            try
            {
                using (var coneccion = GetConnection())
                {
                    using (var comando = new SqlCommand())
                    {
                        comando.CommandText = "sp_buscarClienteComprador";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Dato", datos);
                        SqlDataAdapter leer = new SqlDataAdapter(comando);
                        leer.Fill(res);
                        comando.Parameters.Clear();
                    }//Termina 2do using
                }//Termina primer using
            }
            catch (Exception e) { }

            return res;
        }


        //insertar datos
        public bool InsertarDatos(Cliente_Empeñador datos)
        {
            try
            {

                using (var conection = GetConnection())
                {
                    conection.Open();

                    using (var comando = new SqlCommand())
                    {
                        comando.CommandText = "Insertar_Cliente_Comprador";
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@p_nom", datos.Nombre1);
                        comando.Parameters.AddWithValue("@s_nom", datos.Nombre2);
                        comando.Parameters.AddWithValue("@p_apell", datos.Apellido1);
                        comando.Parameters.AddWithValue("@s_apell", datos.Apellido2);
                        comando.Parameters.AddWithValue("@tel", datos.Tel);
                        comando.Parameters.AddWithValue("@correo", datos.Correo);
                        comando.ExecuteNonQuery();

                        comando.Parameters.Clear();

                        return true;
                    }//fin segundo using
                } //fin primer using

            }
            catch (Exception e) { return false; }
        }


        //Mostrar todos los datos
        public DataTable MostrarDatos()
        {
            DataTable res = new DataTable();
            try
            {
                using (var coneccion = GetConnection())
                {
                    using (var comando = new SqlCommand())
                    {
                        comando.CommandText = "sp_mostrarTodoClienteComprador";
                        comando.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adp = new SqlDataAdapter(comando);
                        adp.Fill(res);

                    }//fin segundo using
                }//fin primer using
            }
            catch (Exception e) { }

            return res;
        }
    }
}
