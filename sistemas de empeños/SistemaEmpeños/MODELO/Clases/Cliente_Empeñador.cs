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
        private int id;
        private string cedula;
        private string direccion;

        public Cliente_Empeñador(int id,string nom1, string nom2,
            string apell1, string apell2,
           string tel, string correo ,string cedula, string direccion)
        {
            this.Id = id;
            this.Nombre1 = nom1;
            this.Nombre2 = nom2;
            this.Apellido1 = apell1;
            this.Apellido2 = apell2;
            this.Tel = tel;
            this.Cedula = cedula;
            this.Direccion = direccion;
        }
        
        public string Cedula { get => cedula; set => cedula = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Id { get => id; set => id = value; }

        //Metodos

        /*REVISAR*/
        
        public bool ActualizarDatos(Cliente_Empeñador datos)
        {
            try
            {
                using (var coneccion = GetConnection())
                {
                    using (var comando = new SqlCommand())
                    {
                        comando.CommandText = "Actualizar_Cliente_Empleado";
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@tipo", "Cliente");
                        comando.Parameters.AddWithValue("@id_registro", datos.Id);
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
            }catch
            {
                return false;
            }
        }

        
        public DataTable BuscarDatos(Cliente_Empeñador datos)
        {
            throw new NotImplementedException();
        }


        public bool Deshabilitar(Cliente_Empeñador datos)
        {
            throw new NotImplementedException();
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

                        return true;
                    }//fin segundo using
                } //fin primer using

            }
            catch (Exception e) { return false;}
        }


        //Mostrar todos los datos
        public DataTable MostrarDatos()
        {
            DataTable res = new DataTable();
            using (var coneccion = GetConnection())
            {
                using (var comando = new SqlCommand())
                {
                    comando.CommandText = "sp_mostrarCliente_Empleado";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@tipo","Cliente");
                    comando.Parameters.Clear();

                    SqlDataAdapter adp = new SqlDataAdapter(comando);
                    adp.Fill(res);

                }//fin segundo using
            }//fin primer using

            return res;
        }
        
    }
}
