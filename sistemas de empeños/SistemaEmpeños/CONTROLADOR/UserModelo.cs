using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEmpeños.MODELO;
using System.Windows.Forms;
namespace SistemaEmpeños.CONTROLADOR
{
   public class UserModelo
    {
       
      
        public bool LoginUsser(string user, string pass)
        {
            try
            {
                AccesoDatoUsuario acceso = new AccesoDatoUsuario();

                return acceso.Login(user, pass);
            }
            catch (Exception e)
            {
                return false;
               
            }
             
           
        }

        public string restraurarPass(string nombre)
        {
            try
            {
                AccesoDatoUsuario acceso = new AccesoDatoUsuario();

                return acceso.CambiarPass(nombre);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            
        }
 
    }
}
