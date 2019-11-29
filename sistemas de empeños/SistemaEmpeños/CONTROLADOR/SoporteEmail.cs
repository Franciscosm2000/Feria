using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEmpeños.MODELO.Servicio_Correo_Electronico;

namespace SistemaEmpeños.CONTROLADOR
{
    class SoporteEmail:Servidor_correo_maestro
    {
        //colocar estos datos en la base de datos por si se cambia el correo o contrasena
        public SoporteEmail()
        {
            sendEmail = "franciscosm62000@gmail.com";
            password = "FJSMOKb2000";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            IniciarSmtpCliente();
        }
    }
}
