using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpeños.MODELO.POJO
{
    class Producto : ConnectionToSQL
    {

        private int idTipoProducto;
        private double valor;
        private string descripcion;
        private string nombre;
        private double precioVenta;
        private string estado;

        //Constructor
        public Producto( int tipo, double valor
            ,string descrip, string nom, double precioV
           ,string estado)
        {
            this.IdTipoProducto = tipo;
            this.Valor = valor;
            this.Descripcion = descrip;
            this.Nombre = nom;
            this.PrecioVenta = precioV;
            this.Estado = estado;
        }

        public Producto() { }

        //Get y set
        public int IdTipoProducto { get => idTipoProducto; set => idTipoProducto = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public string Estado { get => estado; set => estado = value; }

        //Metodos
        public void Insertar(Producto Datos)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = coneccion;

                    comando.CommandText="insertar_producto";
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@id_tipo_producto",Datos.IdTipoProducto);
                    comando.Parameters.AddWithValue("@valor",Datos.Valor);
                    comando.Parameters.AddWithValue("@descripcion",Datos.Descripcion);
                    comando.Parameters.AddWithValue("@nombre",Datos.Nombre);
                    comando.Parameters.AddWithValue("@precio_venta",0);

                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                   

                }//Segundo fin using 
            }//Primer fin using
        }
        public bool ActualizarDatos(Producto datos)
        {
            try
            {
                using (var coneccion = GetConnection())
                {
                    coneccion.Open();
                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = coneccion;
                        comando.CommandText = "Actualizar_Producto";
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@nombre", datos.Nombre);
                        comando.Parameters.AddWithValue("@descripcion", datos.Descripcion);
                        comando.Parameters.AddWithValue("@valor", datos.Valor);
                        comando.ExecuteNonQuery();

                        comando.Parameters.Clear();

                        return true;
                    }//fin segundo using 
                }//fin de primer using
            }
            catch
            {
                return false;
            }
        }

        public DataTable Mostrar()
        {
            DataTable res = new DataTable();
            using (var coneccion = GetConnection())
            {
                using (var comando = new SqlCommand())
                {
                    comando.CommandText = "MostrarProducto";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Connection = coneccion;

                    SqlDataAdapter adp = new SqlDataAdapter(comando);
                    adp.Fill(res);

                }//2do Cierre using
            }//1er Cierre using

            return res;
        }

        public DataTable BuscarDatos(string datos)
        {
            DataTable res = new DataTable();
            try
            {
                using (var coneccion = GetConnection())
                {
                    coneccion.Open();
                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = coneccion;
                        comando.CommandText = "BuscarProducto";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Dato", datos);
                        SqlDataAdapter leer = new SqlDataAdapter(comando);
                        leer.Fill(res);
                        comando.Parameters.Clear();
                    }//Termina 2do using
                }//Termina primer using
            }
            catch (Exception e) { }

            return res;
        }

        //Mostrar ID
        public DataTable MostrarId(string Nombre, int tipo)
        {
            DataTable res = new DataTable();

            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "sp_IdProducto";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@tipo", tipo);

                    SqlDataAdapter adp = new SqlDataAdapter(comando);
                    adp.Fill(res);

                    return res;
                }
            }


        }
      }
}
