using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Punto.Venta.BC;
using Sistema.Punto.Venta.BE;

namespace Sistema_Punto_de_ventas.Formularios
{
    public partial class FrmMinMax : Form
    {
        public FrmMinMax()
        {
            InitializeComponent();
        }

        List<DatosMinMax> datosMinMax = new List<DatosMinMax>();
        string DescripcionProducto = "";
        string Categoria = "";
        decimal PrecioUnitario = 0;
        decimal PrecioProveedor = 0;
        int EnInventario = 0;
        int Minimo = 0;
        int Maximo = 0;
        string estatus = "";
        private void FrmMinMax_Load(object sender, EventArgs e)
        {
            MinMax minMax = new MinMax();
            datosMinMax = minMax.ObtenerMinMaxProductos();
            foreach (var datos in datosMinMax)
            {
                DescripcionProducto = datos.DescripcionProducto;
                Categoria = datos.Categoria;
                PrecioUnitario = datos.PrecioUnitario;
                PrecioProveedor = datos.PrecioProveedor;
                EnInventario = datos.EnInventario;
                Minimo = datos.Minimo;
                Maximo = datos.Maximo;
                estatus = datos.Estatus;
                dataGridViewMinMax.Rows.Add(DescripcionProducto, Categoria, PrecioUnitario, PrecioProveedor, EnInventario, Minimo, Maximo, estatus);
            }
            
            foreach (DataGridViewRow row in dataGridViewMinMax.Rows)
            {
                if (Convert.ToString(row.Cells[7].Value) == "Stock suficiente")
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                else if (Convert.ToString(row.Cells[7].Value) == "Comprar Materia prima / Bastante material")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
