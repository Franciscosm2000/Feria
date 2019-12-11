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

        public void InsertarDatos
            (string nom1, string nom2,
            string apell1, string apell2,
           string tel, string correo, string cedula, string direccion,
           //Producto
           int tipo, double valor
            , string descrip, string nom, double precioV
           , string estado,
           //Empeno
           int id_empleado, double monto_empeno, int cuota, string frecuencia, DateTime fechavencimiento
            )
        {
            Cliente_Empeñador c = new Cliente_Empeñador(nom1, nom2, apell1, apell2, tel, correo, cedula, direccion);
            Empeño e = new Empeño(id_empleado, monto_empeno, cuota, frecuencia, fechavencimiento);
            Producto p = new Producto(tipo,valor, descrip, nom, precioV, estado);

            e.Insertar_Empeño(e,p,c);
        }

        public static DataTable mostrarTablaAmortizacion(string meses,string principal)
        {
            Empeño e = new Empeño();
            return e.GenerarTablaAmortizacion(Convert.ToInt32( meses),Convert.ToDouble( principal));
        }
    }
}
