using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmpeños.MODELO.Clases
{
    class Empleado: Persona
    {

        private string cedula;
        private string direccion;   
        public Empleado(string nom1, string nom2,
            string apell1, string apell2,
           string tel, string correo, string cedula, string direccion)
        {
            this.Nombre1 = nom1;
            this.Nombre2 = nom2;
            this.Apellido1 = apell1;
            this.Apellido2 = apell2;
            this.Tel = tel;
            this.Correo = correo;
            this.Cedula = cedula;
            this.Direccion = direccion;
        }

        public Empleado() { }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        //Metodos

        public bool ActualizarDatos(Empleado datos)
        {
            try
            {
                using (var coneccion = GetConnection())
                {
                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = coneccion;

                        comando.CommandText = "Actualizar_Cliente_Empleado";
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@tipo", "Empleado");
                        comando.Parameters.AddWithValue("@id_Cedula",datos.Cedula);
                        comando.Parameters.AddWithValue("@p_nom", datos.Nombre1);
                        comando.Parameters.AddWithValue("@s_nom", datos.Nombre2);
                        comando.Parameters.AddWithValue("@p_apell", datos.Apellido1);
                        comando.Parameters.AddWithValue("@s_apell", datos.Apellido2);
                        comando.Parameters.AddWithValue("@dir", datos.Direccion);
                        comando.Parameters.AddWithValue("@tel", datos.Tel);
                        comando.Parameters.AddWithValue("@corr", datos.Correo);
                        comando.ExecuteNonQuery();

                        comando.Parameters.Clear();

                        return true;
                    }//fin segundo using 
                }//fin de primer using
            }
            catch
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
                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = coneccion;

                        comando.CommandText = "sp_buscarCliente_Empleado";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Tipo", "Empleado");
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
        public void InsertarDatos(Empleado datos)
        {

                using (var conection = GetConnection())
                {
                    conection.Open();

                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = conection;
                        comando.CommandText = "insertar_Empleado";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@p_nom", datos.Nombre1);
                        comando.Parameters.AddWithValue("@s_nom", datos.Nombre2);
                        comando.Parameters.AddWithValue("@p_apell", datos.Apellido1);
                        comando.Parameters.AddWithValue("@s_apell", datos.Apellido2);
                        comando.Parameters.AddWithValue("@telefono", datos.Tel);
                        comando.Parameters.AddWithValue("@cedula", datos.Cedula);
                        comando.Parameters.AddWithValue("@dir", datos.Direccion);
                        comando.Parameters.AddWithValue("@correo", datos.Correo);
                        comando.ExecuteNonQuery();

                    }//fin segundo using
                } //fin primer using
        }


        //Mostrar todos los datos
        public DataTable MostrarDatos()
        {
         
            DataTable res = new DataTable();
         
                using (var co = GetConnection())
                {
                     co.Open();
                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = co;
                        comando.CommandText = "sp_mostrarCliente_Empleado";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@tipo","Empleado");
                        comando.ExecuteNonQuery();
                    
                        SqlDataAdapter adp = new SqlDataAdapter(comando);
                        adp.Fill(res);
 
                    }//fin segundo using
                }//fin primer using

            return res;
        }

        //Agregar metodo cambiar estado
        public void CambiarEstado(string ced)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "sp_Cambiar_EstadoEmpleado";
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@Cedula", ced);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }
            }//ultimo using
        }


    }
}
