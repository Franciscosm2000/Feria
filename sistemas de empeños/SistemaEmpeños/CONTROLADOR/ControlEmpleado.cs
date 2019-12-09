using SistemaEmpeños.MODELO.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmpeños.CONTROLADOR
{
    class ControlEmpleado
    {
        //Metodo Insertar
        public void AddEmpleado(string nom1, string nom2,
            string apell1, string apell2,
           string tel, string correo, string cedula, string direccion)
        {

            try
            {
                if (nom1 == null || nom1.Equals("") || nom2 == null || nom2.Equals("")
                  || apell1 == null || apell1.Equals("") || apell2 == null || apell2.Equals("")
                  || tel == null || tel.Equals("") || correo == null || correo.Equals("")
                  || cedula == null || cedula.Equals("") || direccion == null || direccion.Equals(""))
                {
                    MessageBox.Show("Rellene los campos");
                }
                else
                {
                    Empleado e = new Empleado(nom1, nom2, apell1, apell2, tel, correo, cedula, direccion);
                    e.InsertarDatos(e);
                }
   
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }

        public static DataTable MostrarDatos()
        {
            Empleado e = new Empleado();
            return e.MostrarDatos();
        }

        public void ActualizarDatos(string nom1, string nom2,
            string apell1, string apell2,
           string tel, string correo, string cedula, string direccion)
        {
            Empleado e = new Empleado(nom1,nom2,apell1,apell2,tel,correo,cedula,direccion);
            e.ActualizarDatos(e);
        }

        public void CambiarEstado(string ced)
        {
            Empleado e = new Empleado();
            e.CambiarEstado(ced);
        }

        public DataTable buscarDatos(string dat)
        {
            Empleado e = new Empleado();
            return e.BuscarDatos(dat);

        }
    }
}
