using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SistemaEmpeños.CONTROLADOR;

namespace SistemaEmpeños.MODELO
{
    class AccesoDatoUsuario : ConnectionToSQL
    {
        //Metodo para verificar usuario
        public bool Login(String user, String pass)
        {
            //no se cierra conexion ya que el metodo using despues de ejecutar todas sus lineas libera los recursos
            using (var connection = GetConnection())
            {
                //Abrimos la coneccion
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //Ejecucion del proceso almacenado con los usuarios segun los parametros pasados
                    command.CommandText = "sp_BuscarUsuario ";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Usuario", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@Tipo","login");
                    SqlDataReader reader = command.ExecuteReader();
                    //si hay elementos el usuario existe
                    if (reader.HasRows)
                    {
                        //Mientras se leen las filas se agregaran los datos a las variables estatica de DatosInicio de secion

                        while (reader.Read())
                        {
                            //DatosInicioSecion.IdUser = reader.GetInt32(0);
                            DatosInicioSecion.nombre = reader.GetString(0);
                            DatosInicioSecion.cargo = reader.GetString(1);
                            DatosInicioSecion.correo = reader.GetString(2);
                        }

                        return true;
                    }
                    //No existe
                    else
                    {
                        return false;
                    }
            }
          }  
        }
        //Hacer metodo
        public void Privilegio_porCargo()
        {

        }
        //Metodo para cambiar clave en la bd cuando esta se olvida
        public string CambiarPass(string user)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "sp_BuscarUsuario";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Usuario",user);
                    command.Parameters.AddWithValue("@pass","");
                    command.Parameters.AddWithValue("@Tipo","RecuperarUsuario");
                    
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(0);
                        string password = reader.GetString(1);
                        string email = reader.GetString(2);
                        
                        var correo_ = new SoporteEmail();
                        correo_.EnviarEmail(sujeto: "Recuperación de contraseña",
                            cuerpo:"Hola, "+userName +" "+ "Su contraseña es :"+ password+ " ,Se recomienda cambiarla una vez que" +
                            " allá accedido al sistema", destinatario: new List<string> {email} );

                        return "Porfavor revice su correo.";
                    }

                    else
                    {
                        return "Lo sentimos, no cuenta con un correo electronico.";
                    }

                }
            }
        }

    }
}
