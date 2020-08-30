using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Punto_de_ventas
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //MenuPrincipal menu = new MenuPrincipal();
            //menu.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             lblHora.Text  = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
             lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
