using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpeños.MODELO.POJO
{
    class TipoProducto : ConnectionToSQL{

            private int Id_Tipo_Producto;
            private string tipo;
            private string descripcion;

            public TipoProducto(int id_Tipo_Producto, string tipo, string descripcion)
            {
                Id_Tipo_Producto1 = id_Tipo_Producto;
                this.Tipo = tipo;
                this.Descripcion = descripcion;
            }

            public TipoProducto() { }

            public int Id_Tipo_Producto1 { get => Id_Tipo_Producto; set => Id_Tipo_Producto = value; }
            public string Tipo { get => tipo; set => tipo = value; }
            public string Descripcion { get => descripcion; set => descripcion = value; }

            //mostrar el tipo de producto
            public DataTable Mostrar_tipo_producto()
            {

                DataTable res = new DataTable();
                
                    using (var coneccion = GetConnection())
                    {
                            coneccion.Open();
                        using (var comando = new SqlCommand())
                        {
                            comando.Connection = coneccion;

                            comando.Connection = coneccion;

                            comando.CommandText = "MostrarTipoProducto";
                            comando.CommandType = CommandType.StoredProcedure;
                  

                            SqlDataAdapter adp = new SqlDataAdapter(comando);
                            adp.Fill(res);

                        return res;
                        }//2DO USING CERRADO
                    }//PRIMER USIGN CERRADO
                }
                
                
            }
        }



