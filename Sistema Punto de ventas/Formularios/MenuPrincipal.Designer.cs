namespace Sistema_Punto_de_ventas
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEmbarques = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblUsuarioAutenticado = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btn_AsignarPrecios = new System.Windows.Forms.Button();
            this.btn_MinMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnVentas.Location = new System.Drawing.Point(866, 209);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(242, 211);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnInventario.Location = new System.Drawing.Point(602, 209);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(242, 211);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnClientes.Location = new System.Drawing.Point(1134, 209);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(242, 211);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnEmbarques
            // 
            this.btnEmbarques.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEmbarques.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmbarques.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmbarques.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnEmbarques.Location = new System.Drawing.Point(602, 475);
            this.btnEmbarques.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmbarques.Name = "btnEmbarques";
            this.btnEmbarques.Size = new System.Drawing.Size(242, 211);
            this.btnEmbarques.TabIndex = 3;
            this.btnEmbarques.Text = "Embarque";
            this.btnEmbarques.UseVisualStyleBackColor = false;
            this.btnEmbarques.Click += new System.EventHandler(this.btnEmbarques_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(1174, 960);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(167, 42);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblUsuarioAutenticado
            // 
            this.lblUsuarioAutenticado.AutoSize = true;
            this.lblUsuarioAutenticado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioAutenticado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuarioAutenticado.Location = new System.Drawing.Point(1350, 960);
            this.lblUsuarioAutenticado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioAutenticado.Name = "lblUsuarioAutenticado";
            this.lblUsuarioAutenticado.Size = new System.Drawing.Size(0, 42);
            this.lblUsuarioAutenticado.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblApellido.Location = new System.Drawing.Point(1479, 960);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(0, 42);
            this.lblApellido.TabIndex = 6;
            // 
            // btn_AsignarPrecios
            // 
            this.btn_AsignarPrecios.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_AsignarPrecios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AsignarPrecios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AsignarPrecios.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_AsignarPrecios.Location = new System.Drawing.Point(1134, 475);
            this.btn_AsignarPrecios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_AsignarPrecios.Name = "btn_AsignarPrecios";
            this.btn_AsignarPrecios.Size = new System.Drawing.Size(242, 211);
            this.btn_AsignarPrecios.TabIndex = 7;
            this.btn_AsignarPrecios.Text = "Asignar Precios";
            this.btn_AsignarPrecios.UseVisualStyleBackColor = false;
            // 
            // btn_MinMax
            // 
            this.btn_MinMax.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_MinMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MinMax.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MinMax.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_MinMax.Location = new System.Drawing.Point(866, 475);
            this.btn_MinMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_MinMax.Name = "btn_MinMax";
            this.btn_MinMax.Size = new System.Drawing.Size(242, 211);
            this.btn_MinMax.TabIndex = 8;
            this.btn_MinMax.Text = "Min Max";
            this.btn_MinMax.UseVisualStyleBackColor = false;
            this.btn_MinMax.Click += new System.EventHandler(this.btn_MinMax_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(2053, 1017);
            this.Controls.Add(this.btn_MinMax);
            this.Controls.Add(this.btn_AsignarPrecios);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblUsuarioAutenticado);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnEmbarques);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEmbarques;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblUsuarioAutenticado;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btn_AsignarPrecios;
        private System.Windows.Forms.Button btn_MinMax;
    }
}