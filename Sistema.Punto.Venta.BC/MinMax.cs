using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Threading.Tasks;
using Sistema.Punto.Venta.BE;
using System.Windows.Forms;

namespace Sistema.Punto.Venta.BC
{
    public class MinMax
    {
        List<DatosMinMax> datosMinMax = new List<DatosMinMax>();
        string DescripcionProducto = "";
        string Categoria = "";
        decimal PrecioUnitario = 0;
        decimal PrecioProveedor = 0;
        int EnInventario = 0;
        int Minimo = 0;
        int Maximo = 0;
        string estatus = "";

        public List<DatosMinMax> ObtenerMinMaxProductos()
        {
            try
            {
                DataSet dataset = new DataSet();
                var conexion = ConfigurationManager.ConnectionStrings["CSSQL"].ConnectionString;
                SqlConnection sql = new SqlConnection(conexion);
                SqlCommand cmd = new SqlCommand("SpSelInformacionMinMax", sql);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                    return null;
                else
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DescripcionProducto = dt.Rows[i][0].ToString();
                        Categoria = dt.Rows[i][1].ToString();
                        PrecioUnitario = Convert.ToDecimal(dt.Rows[i][2].ToString());
                        PrecioProveedor = Convert.ToDecimal(dt.Rows[i][3].ToString());
                        EnInventario = Convert.ToInt32(dt.Rows[i][4].ToString());
                        Minimo = Convert.ToInt32(dt.Rows[i][5].ToString());
                        Maximo = Convert.ToInt32(dt.Rows[i][6].ToString());
                        estatus = dt.Rows[i][7].ToString();
                        datosMinMax.Add(new DatosMinMax() { DescripcionProducto = DescripcionProducto, Categoria = Categoria, EnInventario= EnInventario, Maximo = Maximo, Minimo = Minimo, PrecioProveedor = PrecioProveedor,PrecioUnitario= PrecioUnitario,Estatus = estatus });
                    }

               }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return datosMinMax;
        }
    }
}
