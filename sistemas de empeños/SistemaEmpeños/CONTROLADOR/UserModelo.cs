using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEmpeños.MODELO;
namespace SistemaEmpeños.CONTROLADOR
{
   public class UserModelo
    {
        AccesoDatoUsuario acceso = new AccesoDatoUsuario();
      
        public bool LoginUsser(string user, string pass)
        {
            return acceso.Login(user,pass);  
           
        }
    }
}
