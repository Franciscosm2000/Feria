using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpeños.CONTROLADOR
{

    //se crea de manera estatica ya que cuando es estatico, los datos siempre se mantiene fijos mientras se este ejecutando la aplicacion
    public static class DatosInicioSecion
    {
        public static int IdUser { get; set;}
        public static string nombre { get; set; }
        public static string apellido { get; set; }
        public static string cargo { get; set; }
        public static string correo { get; set; }
    }
}
