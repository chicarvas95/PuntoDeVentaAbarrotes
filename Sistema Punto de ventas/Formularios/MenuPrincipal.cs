using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Punto_de_ventas.Formularios;
using Sistema.Punto.Venta.BE;

namespace Sistema_Punto_de_ventas
{
    public partial class MenuPrincipal : Form
    {
        private List<Usuario> _ListaDatosUsuario;
        public MenuPrincipal(List<Usuario> listaDatosUsuario)
        {
            InitializeComponent();
            this._ListaDatosUsuario = listaDatosUsuario;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas ventas = new Ventas(_ListaDatosUsuario);
            ventas.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario inventario = new Inventario();
            inventario.Show();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnEmbarques_Click(object sender, EventArgs e)
        {
            this.Hide();
            Embarque embarque = new Embarque(_ListaDatosUsuario);
            embarque.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            foreach (var item in _ListaDatosUsuario)
            {
                lblUsuarioAutenticado.Text = item.Nombre;
                lblApellido.Text = item.ApellidoPaterno;
            }
            
        }

        private void btn_MinMax_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMinMax mimax = new FrmMinMax();
            mimax.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
