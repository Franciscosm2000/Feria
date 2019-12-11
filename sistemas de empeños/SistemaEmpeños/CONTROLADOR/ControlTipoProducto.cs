using SistemaEmpeños.MODELO.POJO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpeños.CONTROLADOR
{
    class ControlTipoProducto
    {
        public static DataTable Most()
        {
            TipoProducto ti = new TipoProducto();

            return ti.Mostrar_tipo_producto();
        } 
    }
}
