﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaEmpeños.MODELO
{
    abstract class ConnectionToSQL
    {
        //String solo lectura 
        private readonly string connectionString;

        //Constructor
        public ConnectionToSQL()
        {
            //Cadena servidor 
           // connectionString = @"server=tcp:FRANCISCO,12500; DataBase =PawnSystem; User Id = CasaDeEmpeño; Password=1320022077";
            //Cadena de Coneccion Fran
            connectionString = @"server= DESKTOP-3FB1R0I\SQLEXPRESS; Database = PawnSystem ; User Id =sa; Password = 1320022077";
            //Cadena de coneccion Saul
            //Cadena de coneccion Dylan
        }

        //Solo accedido de una clase eradada
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
