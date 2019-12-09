using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpeños.MODELO.Clases
{
    class Persona : ConnectionToSQL
    {
        private string nombre1;
        private string nombre2;
        private string apellido1;
        private string apellido2;
        private string tel;
        private string correo;

        public string Nombre1 { get => nombre1; set => nombre1 = value; }
        public string Nombre2 { get => nombre2; set => nombre2 = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Correo { get => correo; set => correo = value; }

        //Constructor con parametros
        public Persona(string nom1, string nom2,
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
        //contructor vacio
        public Persona() { }
    }
}
