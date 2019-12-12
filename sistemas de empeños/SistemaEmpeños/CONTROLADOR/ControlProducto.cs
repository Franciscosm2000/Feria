using SistemaEmpeños.MODELO.POJO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public void ActualizarProductos(string nombre, string descripcion,
            double valor)
        {
            Producto p = new Producto {
                Nombre = nombre,
                Descripcion = descripcion,
                Valor = valor
            };
            p.ActualizarDatos(p);

        }

        public static DataTable MostarDatos()
        {
            Producto p = new Producto();
            return p.Mostrar();
        }

        public static DataTable buscardato(string dato)
        {
            Producto p = new Producto();
            return p.BuscarDatos(dato);
        }
    }
}
