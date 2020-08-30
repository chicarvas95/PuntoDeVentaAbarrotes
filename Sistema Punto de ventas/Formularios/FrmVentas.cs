using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using Sistema.Punto.Venta.BE;
using Sistema.Punto.Venta.BC;


namespace Sistema_Punto_de_ventas
{
    public partial class Ventas : Form
    {
        private List<Usuario> _ListaDatosUsuarioVentas;
        string descripcion        = "";
        string Producto           = "";
        decimal UltimoprecioLabel = 0;
        decimal PrecioTotal       = 0;
        decimal IVA               = 0;
        decimal precio            = 0;
        int cantidad              = 0;
        private int contador      = 0;
        public Ventas(List<Usuario> listaDatosUsuario)
        {
            InitializeComponent();
            this._ListaDatosUsuarioVentas = listaDatosUsuario;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            timer1.Start();
            txtCodigoProducto.Focus();
            dgvInformacionCompra.ClearSelection();
            foreach (var item in _ListaDatosUsuarioVentas)
            {
                lblUsuarioAutenticadoVentas.Text = item.Nombre;
                lblApellidoVentas.Text = item.ApellidoPaterno;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //MenuPrincipal menu = new MenuPrincipal();
            //menu.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            int numeroUno = 1;
            if (txtCodigoProducto.Text == "")
            {
                
                txtCodigoProducto.Text = Convert.ToString(numeroUno);
            }
            else
            {
                txtCodigoProducto.Text = txtCodigoProducto.Text + Convert.ToString(numeroUno);
            }
            
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            int numeroDos = 2;
            if (txtCodigoProducto.Text == "")
            {

                txtCodigoProducto.Text = Convert.ToString(numeroDos);
            }
            else
            {
                txtCodigoProducto.Text = txtCodigoProducto.Text + Convert.ToString(numeroDos);
            }
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            int numeroTres = 3;
            if (txtCodigoProducto.Text == "")
            {

                txtCodigoProducto.Text = Convert.ToString(numeroTres);
            }
            else
            {
                txtCodigoProducto.Text = txtCodigoProducto.Text + Convert.ToString(numeroTres);
            }
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            int numeroCuatro = 4;
            if (txtCodigoProducto.Text == "")
            {

                txtCodigoProducto.Text = Convert.ToString(numeroCuatro);
            }
            else
            {
                txtCodigoProducto.Text = txtCodigoProducto.Text + Convert.ToString(numeroCuatro);
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            int numeroCinco = 5;
            if (txtCodigoProducto.Text == "")
            {

                txtCodigoProducto.Text = Convert.ToString(numeroCinco);
            }
            else
            {
                txtCodigoProducto.Text = txtCodigoProducto.Text + Convert.ToString(numeroCinco);
            }
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            int numeroSeis = 6;
            if (txtCodigoProducto.Text == "")
            {

                txtCodigoProducto.Text = Convert.ToString(numeroSeis);
            }
            else
            {
                txtCodigoProducto.Text = txtCodigoProducto.Text + Convert.ToString(numeroSeis);
            }
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            int numeroSiete = 7;
            if (txtCodigoProducto.Text == "")
            {

                txtCodigoProducto.Text = Convert.ToString(numeroSiete);
            }
            else
            {
                txtCodigoProducto.Text = txtCodigoProducto.Text + Convert.ToString(numeroSiete);
            }
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            int numeroOcho = 8;
            if (txtCodigoProducto.Text == "")
            {

                txtCodigoProducto.Text = Convert.ToString(numeroOcho);
            }
            else
            {
                txtCodigoProducto.Text = txtCodigoProducto.Text + Convert.ToString(numeroOcho);
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int numeroNueve = 9;
            if (txtCodigoProducto.Text == "")
            {

                txtCodigoProducto.Text = Convert.ToString(numeroNueve);
            }
            else
            {
                txtCodigoProducto.Text = txtCodigoProducto.Text + Convert.ToString(numeroNueve);
            }
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            int numeroCero = 0;
            if (txtCodigoProducto.Text == "")
            {

                txtCodigoProducto.Text = Convert.ToString(numeroCero);
            }
            else
            {
                txtCodigoProducto.Text = txtCodigoProducto.Text + Convert.ToString(numeroCero);
            }
        }

        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnRetroceso_Click(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text.Equals(""))
            {
                MessageBox.Show("No hay números que borra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtCodigoProducto.Text = txtCodigoProducto.Text.Substring(0, txtCodigoProducto.Text.Count() - 1);
            }
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int CodigoProducto = 0;
            string descripcion = "";
            decimal precio = 0;
            decimal UltimoprecioLabel = 0;
            decimal PrecioTotal = 0;

            decimal IVA = 0;
            int cantidad = 0;
            
            DataSet dataset = new DataSet();
            var conexion = ConfigurationManager.ConnectionStrings["CSSQL"].ConnectionString;
            string codigoProducto = txtCodigoProducto.Text;
            try
            {
                SqlConnection sql = new SqlConnection(conexion);
                SqlCommand    cmd = new SqlCommand("spSelProductoById", sql);
                cmd.CommandType   = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoId", codigoProducto);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt      = new DataTable();
                da.Fill(dt);
                
                int rowEscribir = dgvInformacionCompra.Rows.Count - 1;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontro ningun producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        CodigoProducto = Convert.ToInt32(dt.Rows[i][0].ToString());
                        descripcion = dt.Rows[i][1].ToString();
                        precio = Convert.ToDecimal(dt.Rows[i][2].ToString());
                        IVA = decimal.Parse(lblPorcentaje.Text) / 100;

                        if (lblSubTotalDinero.Text != "0")
                        {
                            UltimoprecioLabel = Convert.ToDecimal(lblSubTotalDinero.Text);
                            PrecioTotal = UltimoprecioLabel + precio;
                            lblSubTotalDinero.Text = Convert.ToString(PrecioTotal);
                            lblTotalDinero.Text = Convert.ToString(PrecioTotal + IVA);
                            dgvInformacionCompra.Rows.Add(1);
                        }
                        else
                        {
                            lblSubTotalDinero.Text = Convert.ToString(precio);
                            lblTotalDinero.Text = Convert.ToString(precio + IVA);
                            dgvInformacionCompra.Rows.Add(1);
                        }
                    }
                    dgvInformacionCompra.Rows[rowEscribir].Cells[0].Value = descripcion;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[1].Value = precio;
                    cantidad += 1;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[2].Value = cantidad;
                    txtCodigoProducto.Text = "";
                }
            }
            
            catch (SqlException ex)
            {
                ex.Message.ToString();
            }
        }

        private void Ventas_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            
            printDocument1.Print();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point); 
            e.Graphics.DrawString("Prueba ",font,Brushes.Black, new RectangleF(0,10,120,20));
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var conexion = ConfigurationManager.ConnectionStrings["CSSQL"].ConnectionString;
            VentasBE Entidadventas     = new VentasBE();
            VentasBC VentasController  = new VentasBC();
            List<VentasBE> ListaVentas = new List<VentasBE>();
            DataGridView Gridview      = new DataGridView();
            try
            {
                if (Convert.ToDecimal(lblTotalDinero.Text) == 0)
                {
                    MessageBox.Show("Favor de escanear algun producto", "No se puede cobrar, debido a que no hay registros de productos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("El total de la venta es: " + lblTotalDinero.Text, "Total de la venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                    int rowEscribir = dgvInformacionCompra.Rows.Count - 1;
                    SqlConnection sql = new SqlConnection(conexion);
                    sql.Open();
                    SqlCommand cmd = new SqlCommand("SpInsVentas", sql);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Cajero", lblUsuarioAutenticadoVentas.Text + " " + lblApellidoVentas.Text);
                    cmd.Parameters.AddWithValue("@Iva", Convert.ToInt16(lblPorcentaje.Text));
                    cmd.Parameters.AddWithValue("@Subtotal", Convert.ToDouble(lblSubTotalDinero.Text));
                    cmd.Parameters.AddWithValue("@Total", Convert.ToDouble(lblTotalDinero.Text));
                    cmd.ExecuteNonQuery();
              

                    foreach (DataGridViewRow row in dgvInformacionCompra.Rows)
                    {
                        if (row.Cells[0].Value == null || string.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                        {
                            /*SI UNA FILA NO TIENE DATOS ENTONCES: */
                        }else
                        {
                            SqlCommand cmd2 = new SqlCommand("SpInsDetalleVenta", sql);
                            cmd2.CommandType = CommandType.StoredProcedure;
                            //ResultadoMax= VentasController.ObtenerMaximoId(conexion);
                            cmd2.Parameters.AddWithValue("@CodigoProducto", row.Cells[0].Value.ToString());
                            cmd2.Parameters.AddWithValue("@DescripcionProducto", row.Cells[1].Value.ToString());
                            cmd2.Parameters.AddWithValue("@Precio", Convert.ToDouble(row.Cells[2].Value));
                            cmd2.Parameters.AddWithValue("@Cantidad", Convert.ToInt16(row.Cells[3].Value));
                            cmd2.ExecuteNonQuery();
                        }
                    }
                    sql.Close();
                    //VentasController.RegistrarVentas(ListaVentas, conexion);
                    dgvInformacionCompra.Rows.Clear();
                    lblSubTotalDinero.Text = "0";
                    lblTotalDinero.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //public void ImprimirTicket()
        //{
        //    Ticket ticket = new Ticket();
        //    Double subtotal = 0.0, total = 0.0;
        //    //Image image = Image.FromFile("~\\SaludDeAcero\\Imagenes\\logoSA.png");
        //    // Set the position  on the form.
        //    //ticket.HeaderImage = image; //esta propiedad no es obligatoria

        //    ticket.AddHeaderLine("SALUD DE ACERO");
        //    ticket.AddHeaderLine("EXPEDIDO EN:");
        //    ticket.AddHeaderLine("CALLE PALOMAR NO. 1 LOC. 1");
        //    ticket.AddHeaderLine("MEXICO, FRESNILLO ZACATECAS");
        //    ticket.AddHeaderLine("RFC: CSI-020226-MV4");

        //    //El metodo AddSubHeaderLine es lo mismo al de AddHeaderLine con la diferencia
        //    //de que al final de cada linea agrega una linea punteada "=========="
        //    ticket.AddSubHeaderLine("Caja # 1 - Ticket #" + 1);
        //    ticket.AddSubHeaderLine("Le atendió: " + "Carlos Rodriguez");
        //    ticket.AddSubHeaderLine("Fecha de venta: " + DateTime.Now.ToString());
        //    ticket.AddSubHeaderLine(" ");
        //    // ticket.AddSubHeaderLine("Num. Socio: " + numSocio + " Socio:" + nombreSocio);

        //    //El metodo AddItem requeire 3 parametros, el primero es cantidad, el segundo es la descripcion
        //    //del producto y el tercero es el precio
        //    foreach (DataRow item in datos.Rows)
        //    {
        //        ticket.AddItem(item["Clave"].ToString(), item["Clave"].ToString(), item["Costo"].ToString());
        //        subtotal = Convert.ToDouble(item["Subtotal"].ToString());
        //        total = Convert.ToDouble(item["Total"].ToString());
        //    }
        //    ticket.AddItem(" ", " ", " ");

        //    //El metodo AddTotal requiere 2 parametros, la descripcion del total, y el precio
        //    ticket.AddTotal("SUBTOTAL", subtotal.ToString());
        //    ticket.AddTotal("IVA", "0");
        //    ticket.AddTotal("TOTAL", total.ToString());
        //    ticket.AddTotal("", ""); //Ponemos un total en blanco que sirve de espacio
        //                             // ticket.AddTotal("RECIBIDO", recibido);
        //                             //  ticket.AddTotal("CAMBIO", (Convert.ToDouble(recibido) - Convert.ToDouble(Costo)).ToString());
        //    ticket.AddTotal("", "");//Ponemos un total en blanco que sirve de espacio
        //    ticket.AddTotal("USTED AHORRO", "0.00");

        //    //El metodo AddFooterLine funciona igual que la cabecera
        //    ticket.AddFooterLine("TU SALUD ES NUESTRA PASION...");
        //    ticket.AddFooterLine("VIVE LA EXPERIENCIA SALUD DE ACERO");
        //    ticket.AddFooterLine("GRACIAS POR SU PREFERENCIA");

        //}
        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<DatosProducto> ResultadoDatosProducto = new List<DatosProducto>();
            int rowEscribir = dgvInformacionCompra.Rows.Count - 1;
            try
            {
                VentasBC Ventas = new VentasBC();
                DataSet dataset = new DataSet();
                string CodigoProducto = "1478529639";
                ResultadoDatosProducto = Ventas.ObtenerProducto(CodigoProducto);
                if (ResultadoDatosProducto == null)
                {
                    MessageBox.Show("Este codigo no se encuentra registrado", "No se encontro algún producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (DatosProducto Datos in ResultadoDatosProducto)
                    {
                        Producto = Datos.CodigoProducto;
                        descripcion = Datos.Descripcion;
                        precio = Datos.Precio;
                    }
                    IVA = decimal.Parse(lblPorcentaje.Text) / 100;

                    if (lblSubTotalDinero.Text != "0")
                    {
                        UltimoprecioLabel = Convert.ToDecimal(lblSubTotalDinero.Text);
                        PrecioTotal = UltimoprecioLabel + precio;
                        lblSubTotalDinero.Text = Convert.ToString(PrecioTotal);
                        lblTotalDinero.Text = Convert.ToString(PrecioTotal + IVA);
                        dgvInformacionCompra.Rows.Add(1);
                    }
                    else
                    {
                        lblSubTotalDinero.Text = Convert.ToString(precio);
                        lblTotalDinero.Text = Convert.ToString(precio + IVA);
                        dgvInformacionCompra.Rows.Add(1);
                    }

                    dgvInformacionCompra.Rows[rowEscribir].Cells[0].Value = Producto;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[1].Value = descripcion;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[2].Value = precio;
                  
                    dgvInformacionCompra.Rows[rowEscribir].Cells[3].Value = cantidad;
                    txtCodigoProducto.Text = "";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error, Favor de comunicarse al departamento de sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInformacionCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAzucarZulka_Click(object sender, EventArgs e)
        {
            
            List<DatosProducto> ResultadoDatosProducto = new List<DatosProducto>();
            int rowEscribir = dgvInformacionCompra.Rows.Count - 1;
            try
            {
                VentasBC Ventas = new VentasBC();
                DataSet dataset = new DataSet();
                string CodigoProducto = "1478529648";
                ResultadoDatosProducto = Ventas.ObtenerProducto(CodigoProducto);
                if (ResultadoDatosProducto == null)
                {
                    MessageBox.Show("Este codigo no se encuentra registrado", "No se encontro algún producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    foreach (DatosProducto Datos in ResultadoDatosProducto)
                    {
                        Producto = Datos.CodigoProducto;
                        descripcion = Datos.Descripcion;
                        precio = Datos.Precio;
                    }
                    IVA = decimal.Parse(lblPorcentaje.Text) / 100;

                    if (lblSubTotalDinero.Text != "0")
                    {
                        UltimoprecioLabel = Convert.ToDecimal(lblSubTotalDinero.Text);
                        PrecioTotal = UltimoprecioLabel + precio;
                        lblSubTotalDinero.Text = Convert.ToString(PrecioTotal);
                        lblTotalDinero.Text = Convert.ToString(PrecioTotal + IVA);
                        dgvInformacionCompra.Rows.Add(1);
                    }
                    else
                    {
                        lblSubTotalDinero.Text = Convert.ToString(precio);
                        lblTotalDinero.Text = Convert.ToString(precio + IVA);
                        dgvInformacionCompra.Rows.Add(1);
                    }

                    dgvInformacionCompra.Rows[rowEscribir].Cells[0].Value = Producto;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[1].Value = descripcion;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[2].Value = precio;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[3].Value = cantidad;
                    txtCodigoProducto.Text = "";
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error, Favor de comunicarse al departamento de sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Fritos_Click(object sender, EventArgs e)
        {
            List<DatosProducto> ResultadoDatosProducto = new List<DatosProducto>();
            int rowEscribir = dgvInformacionCompra.Rows.Count - 1;
            try
            {
                VentasBC Ventas = new VentasBC();
                DataSet dataset = new DataSet();
                string CodigoProducto = "1478529642";
                ResultadoDatosProducto = Ventas.ObtenerProducto(CodigoProducto);
                if (ResultadoDatosProducto == null)
                {
                    MessageBox.Show("Este codigo no se encuentra registrado", "No se encontro algún producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (DatosProducto Datos in ResultadoDatosProducto)
                    {
                        Producto = Datos.CodigoProducto;
                        descripcion = Datos.Descripcion;
                        precio = Datos.Precio;
                    }
                    IVA = decimal.Parse(lblPorcentaje.Text) / 100;

                    if (lblSubTotalDinero.Text != "0")
                    {
                        UltimoprecioLabel = Convert.ToDecimal(lblSubTotalDinero.Text);
                        PrecioTotal = UltimoprecioLabel + precio;
                        lblSubTotalDinero.Text = Convert.ToString(PrecioTotal);
                        lblTotalDinero.Text = Convert.ToString(PrecioTotal + IVA);
                        dgvInformacionCompra.Rows.Add(1);
                    }
                    else
                    {
                        lblSubTotalDinero.Text = Convert.ToString(precio);
                        lblTotalDinero.Text = Convert.ToString(precio + IVA);
                        dgvInformacionCompra.Rows.Add(1);
                    }

                    dgvInformacionCompra.Rows[rowEscribir].Cells[0].Value = Producto;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[1].Value = descripcion;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[2].Value = precio;
                    
                    dgvInformacionCompra.Rows[rowEscribir].Cells[3].Value = cantidad;
                    txtCodigoProducto.Text = "";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error, Favor de comunicarse al departamento de sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sabritas_Click(object sender, EventArgs e)
        {
            List<DatosProducto> ResultadoDatosProducto = new List<DatosProducto>();
            int rowEscribir = dgvInformacionCompra.Rows.Count - 1;
            try
            {
                VentasBC Ventas = new VentasBC();
                DataSet dataset = new DataSet();
                string CodigoProducto = "1478529640";
                ResultadoDatosProducto = Ventas.ObtenerProducto(CodigoProducto);
                if (ResultadoDatosProducto == null)
                {
                    MessageBox.Show("Este codigo no se encuentra registrado", "No se encontro algún producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (DatosProducto Datos in ResultadoDatosProducto)
                    {
                        Producto = Datos.CodigoProducto;
                        descripcion = Datos.Descripcion;
                        precio = Datos.Precio;
                    }
                    IVA = decimal.Parse(lblPorcentaje.Text) / 100;

                    if (lblSubTotalDinero.Text != "0")
                    {
                        UltimoprecioLabel = Convert.ToDecimal(lblSubTotalDinero.Text);
                        PrecioTotal = UltimoprecioLabel + precio;
                        lblSubTotalDinero.Text = Convert.ToString(PrecioTotal);
                        lblTotalDinero.Text = Convert.ToString(PrecioTotal + IVA);
                        dgvInformacionCompra.Rows.Add(1);
                    }
                    else
                    {
                        lblSubTotalDinero.Text = Convert.ToString(precio);
                        lblTotalDinero.Text = Convert.ToString(precio + IVA);
                        dgvInformacionCompra.Rows.Add(1);
                    }

                    dgvInformacionCompra.Rows[rowEscribir].Cells[0].Value = Producto;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[1].Value = descripcion;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[2].Value = precio;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[3].Value = cantidad;
                    txtCodigoProducto.Text = "";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error, Favor de comunicarse al departamento de sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Chetos_Click(object sender, EventArgs e)
        {
            List<DatosProducto> ResultadoDatosProducto = new List<DatosProducto>();
            int rowEscribir = dgvInformacionCompra.Rows.Count - 1;
            try
            {
                VentasBC Ventas = new VentasBC();
                DataSet dataset = new DataSet();
                string CodigoProducto = "1478529641";
                ResultadoDatosProducto = Ventas.ObtenerProducto(CodigoProducto);
                if (ResultadoDatosProducto == null)
                {
                    MessageBox.Show("Este codigo no se encuentra registrado", "No se encontro algún producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (DatosProducto Datos in ResultadoDatosProducto)
                    {
                        Producto = Datos.CodigoProducto;
                        descripcion = Datos.Descripcion;
                        precio = Datos.Precio;
                    }
                    IVA = decimal.Parse(lblPorcentaje.Text) / 100;

                    if (lblSubTotalDinero.Text != "0")
                    {
                        UltimoprecioLabel = Convert.ToDecimal(lblSubTotalDinero.Text);
                        PrecioTotal = UltimoprecioLabel + precio;
                        lblSubTotalDinero.Text = Convert.ToString(PrecioTotal);
                        lblTotalDinero.Text = Convert.ToString(PrecioTotal + IVA);
                        dgvInformacionCompra.Rows.Add(1);
                    }
                    else
                    {
                        lblSubTotalDinero.Text = Convert.ToString(precio);
                        lblTotalDinero.Text = Convert.ToString(precio + IVA);
                        dgvInformacionCompra.Rows.Add(1);
                    }

                    dgvInformacionCompra.Rows[rowEscribir].Cells[0].Value = Producto;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[1].Value = descripcion;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[2].Value = precio;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[3].Value = cantidad;
                    txtCodigoProducto.Text = "";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error, Favor de comunicarse al departamento de sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Fabuloso_Click(object sender, EventArgs e)
        {
            List<DatosProducto> ResultadoDatosProducto = new List<DatosProducto>();
            int rowEscribir = dgvInformacionCompra.Rows.Count - 1;
            try
            {
                VentasBC Ventas = new VentasBC();
                DataSet dataset = new DataSet();
                string CodigoProducto = "1478529638";
                ResultadoDatosProducto = Ventas.ObtenerProducto(CodigoProducto);
                if (ResultadoDatosProducto == null)
                {
                    MessageBox.Show("Este codigo no se encuentra registrado", "No se encontro algún producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (DatosProducto Datos in ResultadoDatosProducto)
                    {
                        Producto = Datos.CodigoProducto;
                        descripcion = Datos.Descripcion;
                        precio = Datos.Precio;
                    }
                    IVA = decimal.Parse(lblPorcentaje.Text) / 100;

                    if (lblSubTotalDinero.Text != "0")
                    {
                        UltimoprecioLabel = Convert.ToDecimal(lblSubTotalDinero.Text);
                        PrecioTotal = UltimoprecioLabel + precio;
                        lblSubTotalDinero.Text = Convert.ToString(PrecioTotal);
                        lblTotalDinero.Text = Convert.ToString(PrecioTotal + IVA);
                        dgvInformacionCompra.Rows.Add(1);
                    }
                    else
                    {
                        lblSubTotalDinero.Text = Convert.ToString(precio);
                        lblTotalDinero.Text = Convert.ToString(precio + IVA);
                        dgvInformacionCompra.Rows.Add(1);
                    }

                    dgvInformacionCompra.Rows[rowEscribir].Cells[0].Value = Producto;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[1].Value = descripcion;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[2].Value = precio;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[3].Value = cantidad;
                    txtCodigoProducto.Text = "";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error, Favor de comunicarse al departamento de sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Rajas_Click(object sender, EventArgs e)
        {
            List<DatosProducto> ResultadoDatosProducto = new List<DatosProducto>();
            int rowEscribir = dgvInformacionCompra.Rows.Count - 1;
            try
            {
                VentasBC Ventas = new VentasBC();
                DataSet dataset = new DataSet();
                string CodigoProducto = "1478529637";
                ResultadoDatosProducto = Ventas.ObtenerProducto(CodigoProducto);
                if (ResultadoDatosProducto == null)
                {
                    MessageBox.Show("Este codigo no se encuentra registrado", "No se encontro algún producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (DatosProducto Datos in ResultadoDatosProducto)
                    {
                        Producto = Datos.CodigoProducto;
                        descripcion = Datos.Descripcion;
                        precio = Datos.Precio;
                    }
                    IVA = decimal.Parse(lblPorcentaje.Text) / 100;

                    if (lblSubTotalDinero.Text != "0")
                    {
                        UltimoprecioLabel = Convert.ToDecimal(lblSubTotalDinero.Text);
                        PrecioTotal = UltimoprecioLabel + precio;
                        lblSubTotalDinero.Text = Convert.ToString(PrecioTotal);
                        lblTotalDinero.Text = Convert.ToString(PrecioTotal + IVA);
                        dgvInformacionCompra.Rows.Add(1);
                    }
                    else
                    {
                        lblSubTotalDinero.Text = Convert.ToString(precio);
                        lblTotalDinero.Text = Convert.ToString(precio + IVA);
                        dgvInformacionCompra.Rows.Add(1);
                    }

                    dgvInformacionCompra.Rows[rowEscribir].Cells[0].Value = Producto;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[1].Value = descripcion;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[2].Value = precio;
                    dgvInformacionCompra.Rows[rowEscribir].Cells[3].Value = cantidad;
                    txtCodigoProducto.Text = "";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error, Favor de comunicarse al departamento de sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            decimal suma = 0;
            decimal IVA = 0;
             IVA = decimal.Parse(lblPorcentaje.Text) / 100;
            if (dgvInformacionCompra.Rows.Count == 1)
            {
                MessageBox.Show("No hay productos escaneados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
           
             if (this.dgvInformacionCompra.SelectedRows.Count > 0)
            {
                dgvInformacionCompra.Rows.RemoveAt(this.dgvInformacionCompra.SelectedRows[0].Index);

                foreach (DataGridViewRow row in dgvInformacionCompra.Rows)
                {
                    if (row.Cells[2].Value != null)
                        suma += Convert.ToDecimal(row.Cells[2].Value);
                }

                lblTotalDinero.Text = Convert.ToDecimal(suma + IVA).ToString();
                lblSubTotalDinero.Text = suma.ToString();
            }
            else
            {
                MessageBox.Show("Tienes que seleccionar un producto para poder eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgvInformacionCompra_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }
    }
}
