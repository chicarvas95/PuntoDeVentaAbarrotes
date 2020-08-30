namespace Sistema_Punto_de_ventas
{
    partial class Embarque
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
            this.components = new System.ComponentModel.Container();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBoxDatosMaterialEntrante = new System.Windows.Forms.GroupBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboProveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboUnidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.lblDescripcionProducto = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.nCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadRecibida = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblMaterialEntrante = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnF1Regresar = new System.Windows.Forms.Button();
            this.btnEscSalir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioProveedor = new System.Windows.Forms.TextBox();
            this.groupBoxDatosMaterialEntrante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegresar.Location = new System.Drawing.Point(8, 10);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(180, 63);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrar.Location = new System.Drawing.Point(1269, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(52, 40);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBoxDatosMaterialEntrante
            // 
            this.groupBoxDatosMaterialEntrante.Controls.Add(this.txtPrecioProveedor);
            this.groupBoxDatosMaterialEntrante.Controls.Add(this.label5);
            this.groupBoxDatosMaterialEntrante.Controls.Add(this.txtPrecioUnitario);
            this.groupBoxDatosMaterialEntrante.Controls.Add(this.label4);
            this.groupBoxDatosMaterialEntrante.Controls.Add(this.comboCategoria);
            this.groupBoxDatosMaterialEntrante.Controls.Add(this.label3);
            this.groupBoxDatosMaterialEntrante.Controls.Add(this.comboProveedor);
            this.groupBoxDatosMaterialEntrante.Controls.Add(this.label2);
            this.groupBoxDatosMaterialEntrante.Controls.Add(this.comboUnidad);
            this.groupBoxDatosMaterialEntrante.Controls.Add(this.label1);
            this.groupBoxDatosMaterialEntrante.Controls.Add(this.btnCancelar);
            this.groupBoxDatosMaterialEntrante.Controls.Add(this.txtDescripcionProducto);
            this.groupBoxDatosMaterialEntrante.Controls.Add(this.lblDescripcionProducto);
            this.groupBoxDatosMaterialEntrante.Controls.Add(this.btnRegistrar);
            this.groupBoxDatosMaterialEntrante.Controls.Add(this.nCantidad);
            this.groupBoxDatosMaterialEntrante.Controls.Add(this.lblCantidadRecibida);
            this.groupBoxDatosMaterialEntrante.Controls.Add(this.txtCodigoProducto);
            this.groupBoxDatosMaterialEntrante.Controls.Add(this.lblProducto);
            this.groupBoxDatosMaterialEntrante.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatosMaterialEntrante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxDatosMaterialEntrante.Location = new System.Drawing.Point(259, 163);
            this.groupBoxDatosMaterialEntrante.Name = "groupBoxDatosMaterialEntrante";
            this.groupBoxDatosMaterialEntrante.Size = new System.Drawing.Size(882, 442);
            this.groupBoxDatosMaterialEntrante.TabIndex = 26;
            this.groupBoxDatosMaterialEntrante.TabStop = false;
            this.groupBoxDatosMaterialEntrante.Text = "Datos del recibo";
            this.groupBoxDatosMaterialEntrante.Enter += new System.EventHandler(this.groupBoxDatosMaterialEntrante_Enter);
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(405, 233);
            this.txtPrecioUnitario.Multiline = true;
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(228, 32);
            this.txtPrecioUnitario.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(219, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 22);
            this.label4.TabIndex = 47;
            this.label4.Text = "Precio Unitario";
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(405, 336);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(228, 34);
            this.comboCategoria.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(219, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 45;
            this.label3.Text = "Categoria";
            // 
            // comboProveedor
            // 
            this.comboProveedor.FormattingEnabled = true;
            this.comboProveedor.Items.AddRange(new object[] {
            "Proveedor 1",
            "Proveedor 2",
            "Proveedor 3",
            "Proveedor 4",
            "Proveedor 5",
            "Proveedor 6",
            "Proveedor 7",
            "Proveedor 8",
            "Proveedor 9",
            "Proveedor 10"});
            this.comboProveedor.Location = new System.Drawing.Point(405, 283);
            this.comboProveedor.Name = "comboProveedor";
            this.comboProveedor.Size = new System.Drawing.Size(228, 34);
            this.comboProveedor.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(219, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 43;
            this.label2.Text = "Proveedor";
            // 
            // comboUnidad
            // 
            this.comboUnidad.FormattingEnabled = true;
            this.comboUnidad.Items.AddRange(new object[] {
            "KG",
            "LT",
            "PZ"});
            this.comboUnidad.Location = new System.Drawing.Point(405, 128);
            this.comboUnidad.Name = "comboUnidad";
            this.comboUnidad.Size = new System.Drawing.Size(103, 34);
            this.comboUnidad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(219, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Unidad";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(689, 99);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 48);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(405, 388);
            this.txtDescripcionProducto.Multiline = true;
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(228, 32);
            this.txtDescripcionProducto.TabIndex = 8;
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.AutoSize = true;
            this.lblDescripcionProducto.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescripcionProducto.Location = new System.Drawing.Point(219, 394);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(120, 22);
            this.lblDescripcionProducto.TabIndex = 40;
            this.lblDescripcionProducto.Text = "Descripcion";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrar.Location = new System.Drawing.Point(689, 45);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(165, 48);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // nCantidad
            // 
            this.nCantidad.Location = new System.Drawing.Point(405, 80);
            this.nCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nCantidad.Name = "nCantidad";
            this.nCantidad.Size = new System.Drawing.Size(103, 33);
            this.nCantidad.TabIndex = 2;
            // 
            // lblCantidadRecibida
            // 
            this.lblCantidadRecibida.AutoSize = true;
            this.lblCantidadRecibida.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadRecibida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidadRecibida.Location = new System.Drawing.Point(219, 88);
            this.lblCantidadRecibida.Name = "lblCantidadRecibida";
            this.lblCantidadRecibida.Size = new System.Drawing.Size(180, 22);
            this.lblCantidadRecibida.TabIndex = 2;
            this.lblCantidadRecibida.Text = "Cantidad Recibida";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(405, 31);
            this.txtCodigoProducto.MaxLength = 10;
            this.txtCodigoProducto.Multiline = true;
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(228, 32);
            this.txtCodigoProducto.TabIndex = 1;
            this.txtCodigoProducto.TextChanged += new System.EventHandler(this.txtCodigoProducto_TextChanged);
            this.txtCodigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProducto_KeyPress);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProducto.Location = new System.Drawing.Point(219, 41);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(160, 22);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Codigo Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.lblFecha);
            this.groupBox2.Controls.Add(this.lblHora);
            this.groupBox2.Controls.Add(this.lblMaterialEntrante);
            this.groupBox2.Controls.Add(this.btnCerrar);
            this.groupBox2.Controls.Add(this.btnRegresar);
            this.groupBox2.Location = new System.Drawing.Point(4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1323, 100);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFecha.Location = new System.Drawing.Point(999, 48);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(110, 22);
            this.lblFecha.TabIndex = 38;
            this.lblFecha.Text = "--/--/----";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHora.Location = new System.Drawing.Point(1164, 48);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(90, 22);
            this.lblHora.TabIndex = 37;
            this.lblHora.Text = "--:--:--";
            // 
            // lblMaterialEntrante
            // 
            this.lblMaterialEntrante.AutoSize = true;
            this.lblMaterialEntrante.Font = new System.Drawing.Font("Copperplate Gothic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialEntrante.Location = new System.Drawing.Point(342, 34);
            this.lblMaterialEntrante.Name = "lblMaterialEntrante";
            this.lblMaterialEntrante.Size = new System.Drawing.Size(624, 39);
            this.lblMaterialEntrante.TabIndex = 26;
            this.lblMaterialEntrante.Text = "Registro de material entrante";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnF1Regresar);
            this.groupBox3.Controls.Add(this.btnEscSalir);
            this.groupBox3.Location = new System.Drawing.Point(4, 623);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1323, 56);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            // 
            // btnF1Regresar
            // 
            this.btnF1Regresar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnF1Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnF1Regresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF1Regresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnF1Regresar.Location = new System.Drawing.Point(183, 19);
            this.btnF1Regresar.Name = "btnF1Regresar";
            this.btnF1Regresar.Size = new System.Drawing.Size(165, 30);
            this.btnF1Regresar.TabIndex = 36;
            this.btnF1Regresar.Text = "F1 - REGRESAR";
            this.btnF1Regresar.UseVisualStyleBackColor = false;
            this.btnF1Regresar.Click += new System.EventHandler(this.btnF1Regresar_Click);
            // 
            // btnEscSalir
            // 
            this.btnEscSalir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEscSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEscSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEscSalir.Location = new System.Drawing.Point(12, 19);
            this.btnEscSalir.Name = "btnEscSalir";
            this.btnEscSalir.Size = new System.Drawing.Size(165, 30);
            this.btnEscSalir.TabIndex = 35;
            this.btnEscSalir.Text = "ESC- SALIR";
            this.btnEscSalir.UseVisualStyleBackColor = false;
            this.btnEscSalir.Click += new System.EventHandler(this.btnEscSalir_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(219, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 22);
            this.label5.TabIndex = 48;
            this.label5.Text = "Precio Proveedor";
            // 
            // txtPrecioProveedor
            // 
            this.txtPrecioProveedor.Location = new System.Drawing.Point(405, 179);
            this.txtPrecioProveedor.Multiline = true;
            this.txtPrecioProveedor.Name = "txtPrecioProveedor";
            this.txtPrecioProveedor.Size = new System.Drawing.Size(228, 32);
            this.txtPrecioProveedor.TabIndex = 4;
            // 
            // Embarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1334, 691);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxDatosMaterialEntrante);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Embarque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Embarque";
            this.Load += new System.EventHandler(this.Embarque_Load);
            this.groupBoxDatosMaterialEntrante.ResumeLayout(false);
            this.groupBoxDatosMaterialEntrante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBoxDatosMaterialEntrante;
        private System.Windows.Forms.Label lblCantidadRecibida;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMaterialEntrante;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnF1Regresar;
        private System.Windows.Forms.Button btnEscSalir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.NumericUpDown nCantidad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.Label lblDescripcionProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox comboUnidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TextBox txtPrecioProveedor;
        private System.Windows.Forms.Label label5;
    }
}