using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpeños.MODELO.Clases
{
    class Empleado: Persona
    {

        private string cedula;
        private string direccion;

        public Empleado(string nom1, string nom2,
            string apell1, string apell2,
           string tel, string correo, string cedula, string direccion)
        {
            this.Nombre1 = nom1;
            this.Nombre2 = nom2;
            this.Apellido1 = apell1;
            this.Apellido2 = apell2;
            this.Tel = tel;
            this.Cedula = cedula;
            this.Direccion = direccion;
        }


        public string Cedula { get => cedula; set => cedula = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        //Metodos
        public bool ActualizarDatos(object objeto)
        {
            throw new NotImplementedException();
            
        }

        public DataTable BuscarDatos(object objeto)
        {
            throw new NotImplementedException();
        }

        public bool Deshabilitar(object objeto)
        {
            throw new NotImplementedException();
        }

        public bool InsertarDatos(object objeto)
        {
            throw new NotImplementedException();
        }

        public DataTable MostrarDatos()
        {
            throw new NotImplementedException();
        }

        

    }
}
