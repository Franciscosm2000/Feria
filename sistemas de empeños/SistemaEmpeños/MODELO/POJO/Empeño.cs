using SistemaEmpeños.MODELO.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmpeños.MODELO.POJO
{
    class Empeño : ConnectionToSQL
    {

        private int total_empeno;
        private int id_empeno;
        private int id_empleado;
        private double monto_empeno;
        private int cuota;
        private string frecuencia;
        private DateTime fechavencimiento;

        public Empeño(int id_empleado, double monto_empeno, int cuota, string frecuencia, DateTime fechavencimiento)
        {
            this.Id_empeno = id_empeno;
            this.Id_empleado = id_empleado;
            this.Monto_empeno = monto_empeno;
            this.Cuota = cuota;
            this.Frecuencia = frecuencia;
            this.Fechavencimiento = fechavencimiento;

        }

        public Empeño() { }

        public int Id_empeno { get => id_empeno; set => id_empeno = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public double Monto_empeno { get => monto_empeno; set => monto_empeno = value; }
        public int Cuota { get => cuota; set => cuota = value; }
        public string Frecuencia { get => frecuencia; set => frecuencia = value; }
        public DateTime Fechavencimiento { get => fechavencimiento; set => fechavencimiento = value; }
        public int Total_empeno { get => total_empeno; set => total_empeno = value; }



        //insertar los datos de empeño

        public void Insertar_Empeño(Empeño datos,string ced, int idpr,string nom)
        {
            Cliente_Empeñador cliente = new Cliente_Empeñador();

            int id = Convert.ToInt32(cliente.MostrarId(ced).Rows[0][0]);

            Producto pro = new Producto();

            int idP = Convert.ToInt32(pro.MostrarId(nom,idpr).Rows[0][0]);

            using (var connecion = GetConnection())
            {
                connecion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = connecion;

                    comando.CommandText = "sp_add_Empeno";
                    comando.CommandType = CommandType.StoredProcedure;

                    //empeño
                    comando.Parameters.AddWithValue("@idClient",id);
                    comando.Parameters.AddWithValue("@idEmpleado", datos.Id_empleado);
                    comando.Parameters.AddWithValue("@idP",idP );
                    comando.Parameters.AddWithValue("@Monto_Empeno", datos.Monto_empeno);
                    comando.Parameters.AddWithValue("Cuota", datos.Cuota);
                    comando.Parameters.AddWithValue("@frecuencia", datos.Frecuencia);
                    comando.Parameters.AddWithValue("@FechaVencimiento", datos.Fechavencimiento);
                    comando.ExecuteNonQuery();

                    comando.Parameters.Clear();
                }
            }
        }

        //PARA HACER LOS FILTROS DE EMPENOS

        public DataTable BuscarDato(string dato)
        {
            DataTable res = new DataTable();

            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = coneccion;

                    comando.CommandText = "sp_BuscarEmpeño";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@dato", dato);
                    comando.ExecuteNonQuery();
                    SqlDataAdapter leer = new SqlDataAdapter(comando);
                    leer.Fill(res);
                    comando.Parameters.Clear();

                    return res;
                }
            }//Primer fin usign
        }
        //TABLA DE AMORTIZACION
        public DataTable GenerarTablaAmortizacion(int mes, double principal)
        {
            DataTable res = new DataTable();
            double a = 0.15;
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = coneccion;
                    
                    comando.CommandText = "sp_prestamo ";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@meses", @mes);
                    comando.Parameters.AddWithValue("@tasa",a );
                    comando.Parameters.AddWithValue("@principal", @principal);
                    comando.Parameters.AddWithValue("@email", "asdf");
                    comando.ExecuteNonQuery();
                    SqlDataAdapter leer = new SqlDataAdapter(comando);
                    leer.Fill(res);
                    comando.Parameters.Clear();

                    return res;
                }
            }
        }
        
    }
}