using Sistema.Punto.Venta.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Punto_de_ventas
{
    
    public partial class Embarque : Form
    {
        private List<Usuario> _ListaDatosUsuarioVentas;
        public Embarque(List<Usuario> listaDatosUsuario)
        {
            InitializeComponent();
            this._ListaDatosUsuarioVentas = listaDatosUsuario;
        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal(_ListaDatosUsuarioVentas);
            menu.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //MenuPrincipal Menu = new MenuPrincipal();
            //Menu.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void Embarque_Load(object sender, EventArgs e)
        {
            timer1.Start();
            comboCategoria.DisplayMember = "Text";
            comboCategoria.ValueMember = "Value";
            var items = new[]
            {
              new { Text= "Panaderia", Value="1"},
              new { Text = "Abarrotes", Value = "2" },
              new { Text = "Frutas", Value = "3" },
              new { Text = "Verduras", Value = "4" },
              new { Text = "Carniceria", Value = "5" }
            };
            comboCategoria.DataSource = items;
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = lblHora.Text = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnF1Regresar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //MenuPrincipal menu = new MenuPrincipal();
            //menu.Show();
        }

        private void btnEscSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            int numeroUno = 1;
            if (txtCodigoProducto.ContainsFocus && txtCodigoProducto.Text == "")
            {
                txtCodigoProducto.Text = Convert.ToString(numeroUno);
                txtCodigoProducto.SelectionStart = txtCodigoProducto.Text.Length;
                txtCodigoProducto.ScrollToCaret();
            }else
            {
                txtCodigoProducto.Text = txtCodigoProducto.Text + Convert.ToString(numeroUno);
                txtCodigoProducto.SelectionStart = txtCodigoProducto.Text.Length;
                txtCodigoProducto.ScrollToCaret();
            }

            
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            int numeroDos = 2;
            if (txtCodigoProducto.Focus())
            {
                txtCodigoProducto.Text = Convert.ToString(numeroDos);
            }
            
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            int numeroTres = 3;
            if (txtCodigoProducto.Focus())
            {
                txtCodigoProducto.Text = Convert.ToString(numeroTres);
            }

        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            int numeroCuatro = 4;
            if (txtCodigoProducto.Focus())
            {
                txtCodigoProducto.Text = Convert.ToString(numeroCuatro);
            }
            
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            int numeroCinco = 5;
            if (txtCodigoProducto.Focus())
            {
                txtCodigoProducto.Text = Convert.ToString(numeroCinco);
            }
          
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            int numeroSeis = 6;
            if (txtCodigoProducto.Focus())
            {
                txtCodigoProducto.Text = Convert.ToString(numeroSeis);
            }
           
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            int numeroSiete = 7;
            if (txtCodigoProducto.Focus())
            {
                txtCodigoProducto.Text = Convert.ToString(numeroSiete);
            }
           
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            int numeroOcho = 8;
            if (txtCodigoProducto.Focus())
            {
                txtCodigoProducto.Text = Convert.ToString(numeroOcho);
            }
          
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int numeroNueve = 9;
            if (txtCodigoProducto.Focus())
            {
                txtCodigoProducto.Text = Convert.ToString(numeroNueve);
            }
           
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            int numeroCero = 0;
            if (txtCodigoProducto.Focus())
            {
                txtCodigoProducto.Text = Convert.ToString(numeroCero);
            }
           
        }

        private void groupBoxDatosMaterialEntrante_Enter(object sender, EventArgs e)
        {

        }

        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var conexion = ConfigurationManager.ConnectionStrings["CSSQL"].ConnectionString;
            string CodigoProducto = txtCodigoProducto.Text;
            decimal Cantidad = nCantidad.Value;
            string Unidad = comboUnidad.Text;
            string Proveedor = comboProveedor.Text;
            string DescripcionProducto = txtDescripcionProducto.Text;
            if (txtCodigoProducto.Text == "")
            {
                MessageBox.Show("Favor de ingresar o escanear el codigo del producto","Campo requerido",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (nCantidad.Value == 0)
            {
                MessageBox.Show("Favor de ingresar una cantidad valida","Campo requerido", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else if (txtPrecioProveedor.Text == "")
            {
                MessageBox.Show("Favor de ingresar el precio del proveedor", "Campa requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPrecioUnitario.Text == "")
            {
                MessageBox.Show("Favor de ingresar un precio unitario para el producto","Campa requerido", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                
            }
            else if (comboUnidad.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Favor de seleccionar una unidad para el producto", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            else if (comboProveedor.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Favor de seleccionar un proveedor","Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (comboProveedor.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Favor de seleccionar una categoria para el producto", "Campo requerdio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtDescripcionProducto.Text == "")
            {
                MessageBox.Show("Favor de ingresar el producto a registrar", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    
                    SqlConnection sql = new SqlConnection(conexion);
                    sql.Open();
                    SqlCommand cmd = new SqlCommand("SpInsEmbarque", sql);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo", CodigoProducto);
                    cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                    cmd.Parameters.AddWithValue("@Unidad", Unidad);
                    cmd.Parameters.AddWithValue("@Proveedor", Proveedor);
                    cmd.Parameters.AddWithValue("@Descripcion", DescripcionProducto);
                    cmd.Parameters.AddWithValue("@PrecioProveedor", txtPrecioProveedor.Text);
                    cmd.Parameters.AddWithValue("@PrecioUnitario", txtPrecioUnitario.Text);
                    cmd.Parameters.AddWithValue("@Categoria", comboCategoria.SelectedIndex);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado correctamente","Registro almacenado en base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarDatos();
                    sql.Close();
                }
                catch (SqlException ex)
                {
                    ex.Message.ToString();
                }
            }
        }
        public void limpiarDatos()
        {
            txtCodigoProducto.Text = "";
            txtCodigoProducto.Focus();
            nCantidad.Value = 0;
            txtPrecioProveedor.Text = "";
            txtPrecioUnitario.Text = "";
            comboUnidad.SelectedItem = null;
            comboCategoria.SelectedItem = null;
            comboProveedor.SelectedItem = null;
            txtDescripcionProducto.Text = "";
        }
        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //MenuPrincipal menu = new MenuPrincipal();
            //menu.Show();
        }
    }
}
