using SistemaEmpeños.MODELO.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpeños.CONTROLADOR
{
    class ControlProducto
    {
        public void InsertarDatos(int idTipo,string Valor, string Descripcion,
                string NombreProducto)
        {
            Producto p = new Producto(idTipo,Convert.ToDouble(Valor), Descripcion, NombreProducto, 0,"HABILITADO");
            p.Insertar(p);
        }
    }
}
