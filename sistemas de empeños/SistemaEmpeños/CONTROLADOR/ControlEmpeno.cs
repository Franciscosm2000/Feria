using SistemaEmpeños.MODELO.Clases;
using SistemaEmpeños.MODELO.POJO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpeños.CONTROLADOR
{
    class ControlEmpeno
    {
        public static DataTable mostrar(string dato)
        {
            Empeño e = new Empeño();
            return e.BuscarDato(dato);
        }

        public void InsertarDatos( int id_empleado, double monto_empeno, int cuota, string frecuencia, 
            DateTime fechavencimiento, string ced, int idp, string NombreProducto
            )
        {
            
            Empeño e = new Empeño(id_empleado, monto_empeno, cuota, frecuencia, fechavencimiento);
            
            e.Insertar_Empeño(e,ced,idp,NombreProducto);
        }

        public static DataTable mostrarTablaAmortizacion(string meses,string principal)
        {
            Empeño e = new Empeño();
            return e.GenerarTablaAmortizacion(Convert.ToInt32( meses),Convert.ToDouble( principal));
        }
    }
}
