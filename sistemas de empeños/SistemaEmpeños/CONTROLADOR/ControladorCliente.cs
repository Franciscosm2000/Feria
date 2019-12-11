using SistemaEmpeños.MODELO.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpeños.CONTROLADOR
{
    class ControladorCliente
    {
        public void ActualizarCliente(string nom1, string nom2,
            string apell1, string apell2,
           string tel, string correo, string cedula, string direccion)
        {
            Cliente_Empeñador clie = new Cliente_Empeñador(nom1,nom2,apell1,apell2,tel,correo,cedula,direccion);
            clie.ActualizarDatos(clie);

        }

        public static DataTable buscardato(string dato)
        {
            Cliente_Empeñador c = new Cliente_Empeñador();

            return c.BuscarDatos(dato);
        }

        public static DataTable MostrarDatos()
        {
            Cliente_Empeñador c = new Cliente_Empeñador();

            return c.MostrarDatos();
        }

        public void InsertarDatos(string nom1, string nom2,
            string apell1, string apell2,
           string tel, string correo, string cedula, string direccion)
        {
            Cliente_Empeñador cli = new Cliente_Empeñador();
            cli.InsertarDatos(cli);
        }
      
    }
}
