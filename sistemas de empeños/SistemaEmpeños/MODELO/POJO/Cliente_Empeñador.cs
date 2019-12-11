using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpeños.MODELO.Clases
{
    class Cliente_Empeñador : Persona
    {
        private string cedula;
        private string direccion;

        public Cliente_Empeñador(string nom1, string nom2,
            string apell1, string apell2,
           string tel, string correo, string cedula, string direccion)
        {
            this.Nombre1 = nom1;
            this.Nombre2 = nom2;
            this.Apellido1 = apell1;
            this.Apellido2 = apell2;
            this.Tel = tel;
            this.Cedula = cedula;
            this.Direccion = direccion;
        }

        public Cliente_Empeñador() { }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        
        //Metodos

        public bool ActualizarDatos(Cliente_Empeñador datos)
        {
            try
            {
                using (var coneccion = GetConnection())
                {
                    coneccion.Open();
                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = coneccion;
                        comando.CommandText = "Actualizar_Cliente_Empleado";
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@tipo", "Cliente");
                        comando.Parameters.AddWithValue("@p_nom", datos.Nombre1);
                        comando.Parameters.AddWithValue("@s_nom", datos.Nombre2);
                        comando.Parameters.AddWithValue("@p_apell", datos.Apellido1);
                        comando.Parameters.AddWithValue("@s_apell", datos.Apellido2);
                        comando.Parameters.AddWithValue("@id_cedula",datos.Cedula);
                        comando.Parameters.AddWithValue("@dir", datos.Direccion);
                        comando.Parameters.AddWithValue("@tel", datos.Tel);
                        comando.Parameters.AddWithValue("@corr", datos.Correo);
                        comando.ExecuteNonQuery();

                        comando.Parameters.Clear();

                        return true;
                    }//fin segundo using 
                }//fin de primer using
            } catch
            {
                return false;
            }
        }


        public DataTable BuscarDatos(string datos)
        {
            DataTable res = new DataTable();
            try
            {
                using (var coneccion = GetConnection())
                {
                    coneccion.Open();
                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = coneccion;
                        comando.CommandText = "sp_buscarCliente_Empleado";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Tipo", "Cliente");
                        comando.Parameters.AddWithValue("@Dato", datos);
                        SqlDataAdapter leer = new SqlDataAdapter(comando);
                        leer.Fill(res);
                        comando.Parameters.Clear();
                    }//Termina 2do using
                }//Termina primer using
            }catch (Exception e) { }

            return res;
        } 


        //insertar datos
        public void InsertarDatos(Cliente_Empeñador datos)
        {
                using (var conection = GetConnection())
                {
                    conection.Open();

                    using (var comando = new SqlCommand())
                    {
                    comando.Connection = conection;

                        comando.CommandText = "Insertar_Cliente_vendedor";
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@p_nom", datos.Nombre1);
                        comando.Parameters.AddWithValue("@s_nom", datos.Nombre2);
                        comando.Parameters.AddWithValue("@p_apell", datos.Apellido1);
                        comando.Parameters.AddWithValue("@s_apell", datos.Apellido2);
                        comando.Parameters.AddWithValue("@cedula", datos.Cedula);
                        comando.Parameters.AddWithValue("@dir", datos.Direccion);
                        comando.Parameters.AddWithValue("@tel", datos.Tel);
                        comando.Parameters.AddWithValue("@correo", datos.Correo);
                        comando.ExecuteNonQuery();

                        comando.Parameters.Clear();

                     
                    }//fin segundo using
                } //fin primer using
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
                        comando.CommandText = "sp_mostrarCliente_Empleado";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@tipo", "Cliente");
                        comando.Parameters.Clear();

                        SqlDataAdapter adp = new SqlDataAdapter(comando);
                        adp.Fill(res);

                    }//fin segundo using
                }//fin primer using
            }catch (Exception e) { }

            return res;
        }
        
    }
}
