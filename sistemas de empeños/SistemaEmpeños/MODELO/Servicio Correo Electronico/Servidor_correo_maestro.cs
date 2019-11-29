using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace SistemaEmpeños.MODELO.Servicio_Correo_Electronico
{
   abstract class Servidor_correo_maestro
    {
        private SmtpClient smtpCliente;
        protected string sendEmail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        //ssl protocolo de conexion segura
        protected bool ssl { get; set; }

        //Metodo para iniciar el protocolo de correo electronico 
        protected void IniciarSmtpCliente()
        {
            //Credenciales 
            smtpCliente = new SmtpClient();
            smtpCliente.Credentials = new NetworkCredential(sendEmail,password);
            smtpCliente.Host = host;
            smtpCliente.Port = port;
            smtpCliente.EnableSsl = ssl;
          
        }

        //Enviar email
        public void EnviarEmail(string sujeto, string cuerpo, List <string> destinatario)
        {
            var Mensaje = new MailMessage();

            try
            {
                Mensaje.From = new MailAddress(sendEmail);
                //toda la lista de correo
                foreach (string mail in destinatario)
                {
                    Mensaje.To.Add(mail);
                }
                Mensaje.Subject = sujeto;
                Mensaje.Body = cuerpo;
                Mensaje.Priority = MailPriority.Normal;

                //protocolo de envio 

                smtpCliente.Send(Mensaje);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //Liberamos los recursos
                Mensaje.Dispose();
                smtpCliente.Dispose();
            }
        }
    }
}
