using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sistema.Punto.Venta.BE;
using Sistema.Punto.Venta.BC;

namespace Sistema_Punto_de_ventas
{
    public partial class FrmLogin : Form
    {
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
       
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
           
        }

        private void btn9_Click(object sender, EventArgs e)
        {
          
        }

        private void btnRetroceso_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
        
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUno_Click_1(object sender, EventArgs e)
        {
            int numeroUno = 1;
            if (txtContrasena.Text == "")
            {

                txtContrasena.Text = Convert.ToString(numeroUno);
            }
            else
            {
                txtContrasena.Text = txtContrasena.Text + Convert.ToString(numeroUno);
            }
        }

        private void btnDos_Click_1(object sender, EventArgs e)
        {
            int numeroDos = 2;
            if (txtContrasena.Text == "")
            {

                txtContrasena.Text = Convert.ToString(numeroDos);
            }
            else
            {
                txtContrasena.Text = txtContrasena.Text + Convert.ToString(numeroDos);
            }
        }

        private void btnTres_Click_1(object sender, EventArgs e)
        {
            int numeroTres = 3;
            if (txtContrasena.Text == "")
            {

                txtContrasena.Text = Convert.ToString(numeroTres);
            }
            else
            {
                txtContrasena.Text = txtContrasena.Text + Convert.ToString(numeroTres);
            }
        }

        private void btnCuatro_Click_1(object sender, EventArgs e)
        {
            int numeroCuatro = 4;
            if (txtContrasena.Text == "")
            {

                txtContrasena.Text = Convert.ToString(numeroCuatro);
            }
            else
            {
                txtContrasena.Text = txtContrasena.Text + Convert.ToString(numeroCuatro);
            }
        }

        private void btnCinco_Click_1(object sender, EventArgs e)
        {
            int numeroCinco = 5;
            if (txtContrasena.Text == "")
            {

                txtContrasena.Text = Convert.ToString(numeroCinco);
            }
            else
            {
                txtContrasena.Text = txtContrasena.Text + Convert.ToString(numeroCinco);
            }
        }

        private void btnSeis_Click_1(object sender, EventArgs e)
        {
            int numeroSeis = 6;
            if (txtContrasena.Text == "")
            {

                txtContrasena.Text = Convert.ToString(numeroSeis);
            }
            else
            {
                txtContrasena.Text = txtContrasena.Text + Convert.ToString(numeroSeis);
            }
        }

        private void btnSiete_Click_1(object sender, EventArgs e)
        {
            int numeroSiete = 7;
            if (txtContrasena.Text == "")
            {

                txtContrasena.Text = Convert.ToString(numeroSiete);
            }
            else
            {
                txtContrasena.Text = txtContrasena.Text + Convert.ToString(numeroSiete);
            }
        }

        private void btnOcho_Click_1(object sender, EventArgs e)
        {
            int numeroOcho = 8;
            if (txtContrasena.Text == "")
            {

                txtContrasena.Text = Convert.ToString(numeroOcho);
            }
            else
            {
                txtContrasena.Text = txtContrasena.Text + Convert.ToString(numeroOcho);
            }
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            int numeroNueve = 9;
            if (txtContrasena.Text == "")
            {

                txtContrasena.Text = Convert.ToString(numeroNueve);
            }
            else
            {
                txtContrasena.Text = txtContrasena.Text + Convert.ToString(numeroNueve);
            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var conexion            = ConfigurationManager.ConnectionStrings["CSSQL"].ConnectionString;
                string appProcedimiento = ConfigurationManager.AppSettings["ProcedimientoAutenticacion"];
                Usuario DatosUsuario    = new Usuario();
                List<Usuario> ListaDatosUsuario = new List<Usuario>();
                Autenticacion auth      = new Autenticacion();
                DatosUsuario.Contrasena = txtContrasena.Text;
                ListaDatosUsuario = auth.ObtenerUsuarioAutenticado(conexion, DatosUsuario.Contrasena,appProcedimiento);
                if (ListaDatosUsuario.Any())
                {
                    MenuPrincipal menu = new MenuPrincipal(ListaDatosUsuario);
                    this.Hide();
                    menu.Show();
                }else
                {
                    MessageBox.Show("Favor de verificar tu numero de empleado", "Verificar tu numero de empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRetroceso_Click_1(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Equals(""))
            {
                MessageBox.Show("No hay números que borra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtContrasena.Text = txtContrasena.Text.Substring(0, txtContrasena.Text.Count() - 1);
            }
        }

        private void btnCero_Click_1(object sender, EventArgs e)
        {
            int numeroCero = 0;
            if (txtContrasena.Text == "")
            {

                txtContrasena.Text = Convert.ToString(numeroCero);
            }
            else
            {
                txtContrasena.Text = txtContrasena.Text + Convert.ToString(numeroCero);
            }
        }
    }
}
