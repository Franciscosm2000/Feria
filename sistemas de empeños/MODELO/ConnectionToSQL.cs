using System;
using System.Collections.Generic;
using System.Text;

namespace MODELO
{
    public abstract class  ConnectionToSQL
    {
        private readonly String connectionString;
        public ConnectionToSQL()
        {
            connectionString = "Nombre servidor SQL, Database = ,integrated security";
        }
    }
}
