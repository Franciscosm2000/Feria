using SistemaEmpeños.MODELO.POJO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpeños.CONTROLADOR
{
    class EmpenoFran
    {
        public static DataTable mostrar(string dato)
        {
            EmpeñoFran e = new EmpeñoFran();
            return e.BuscarDato(dato);
        }
    }
}
