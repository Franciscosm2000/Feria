using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpeños.MODELO.Clases
{
    class Cliente_Comprador  : Persona
    {
        public Cliente_Comprador
        (string nom1, string nom2,
           string apell1, string apell2,
           string tel, string correo)
        {
            this.Nombre1 = nom1;
            this.Nombre2 = nom2;
            this.Apellido1 = apell1;
            this.Apellido2 = apell2;
            this.Tel = tel;
            this.Correo = correo;
        }

        //Metodos
        public bool ActualizarDatos()
        {
            throw new NotImplementedException();
        }

        public DataTable BuscarDatos()
        {
            throw new NotImplementedException();
        }

        public bool Deshabilitar()
        {
            throw new NotImplementedException();
        }

        public bool InsertarDatos()
        {
            throw new NotImplementedException();
        }

        public DataTable MostrarDatos()
        {
            throw new NotImplementedException();
        }
    }
}
