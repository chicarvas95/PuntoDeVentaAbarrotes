using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Punto.Venta.BE;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace Sistema.Punto.Venta.BC
{
    public class VentasBC
    {
        List<DatosProducto> datosproducto = new List<DatosProducto>();
        public void RegistrarVentas(List<VentasBE> ventas,string conexion)
        {
            try
            {
                foreach (VentasBE DatosVenta in ventas)
                {
                    DatosVenta.IdVenta = 1;
                }
            }
            catch (Exception ex)
            {

            }            
        }
        
        public List<DatosProducto> ObtenerProducto(string CodigoProducto)
        {
            try
            {
                string Producto      = "";
                string descripcion   = "";
                decimal precio       = 0;
                DataSet dataset      = new DataSet();
                var conexion         = ConfigurationManager.ConnectionStrings["CSSQL"].ConnectionString;
                SqlConnection sql    = new SqlConnection(conexion);
                SqlCommand cmd       = new SqlCommand("spSelProductoById", sql);
                cmd.CommandType      = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoId", CodigoProducto);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                    return null;
                else
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Producto    = dt.Rows[i][0].ToString();
                        descripcion = dt.Rows[i][1].ToString();
                        precio = Convert.ToDecimal(dt.Rows[i][2].ToString());
                        datosproducto.Add(new DatosProducto() { CodigoProducto = Producto, Descripcion = descripcion, Precio = precio });
                    }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error, Favor de comunicarse al departamento de sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datosproducto;
        }

        public int ObtenerMaximoId(string conexion)
        {
            try
            {
                int MaxId = 0;
                SqlConnection sql = new SqlConnection(conexion);
                sql.Open();
                SqlCommand cmd = new SqlCommand("SpSelMaxId", sql);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    MaxId = Convert.ToInt16(dt.Rows[i][0]);
                }
                    sql.Close();

                return MaxId;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
