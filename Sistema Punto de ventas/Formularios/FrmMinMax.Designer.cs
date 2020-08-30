namespace Sistema_Punto_de_ventas.Formularios
{
    partial class FrmMinMax
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewMinMax = new System.Windows.Forms.DataGridView();
            this.ColumnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecioProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMinMax)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMinMax
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMinMax.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMinMax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMinMax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProducto,
            this.ColumnCategoria,
            this.ColumnPrecio,
            this.ColumnPrecioProveedor,
            this.ColumnInventario,
            this.ColumnMinimo,
            this.ColumnMaximo,
            this.ColumnEstatus});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMinMax.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewMinMax.Location = new System.Drawing.Point(13, 253);
            this.dataGridViewMinMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewMinMax.Name = "dataGridViewMinMax";
            this.dataGridViewMinMax.Size = new System.Drawing.Size(1995, 239);
            this.dataGridViewMinMax.TabIndex = 0;
            // 
            // ColumnProducto
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnProducto.HeaderText = "Producto";
            this.ColumnProducto.Name = "ColumnProducto";
            this.ColumnProducto.Width = 250;
            // 
            // ColumnCategoria
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnCategoria.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnCategoria.HeaderText = "Categoria";
            this.ColumnCategoria.Name = "ColumnCategoria";
            this.ColumnCategoria.Width = 200;
            // 
            // ColumnPrecio
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnPrecio.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnPrecio.HeaderText = "Precio Unitario";
            this.ColumnPrecio.Name = "ColumnPrecio";
            // 
            // ColumnPrecioProveedor
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnPrecioProveedor.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnPrecioProveedor.HeaderText = "Precio Proveedor";
            this.ColumnPrecioProveedor.Name = "ColumnPrecioProveedor";
            // 
            // ColumnInventario
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnInventario.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnInventario.HeaderText = "Inventario";
            this.ColumnInventario.Name = "ColumnInventario";
            this.ColumnInventario.Width = 200;
            // 
            // ColumnMinimo
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnMinimo.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnMinimo.HeaderText = "Minimo";
            this.ColumnMinimo.Name = "ColumnMinimo";
            // 
            // ColumnMaximo
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnMaximo.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnMaximo.HeaderText = "Maximo";
            this.ColumnMaximo.Name = "ColumnMaximo";
            // 
            // ColumnEstatus
            // 
            this.ColumnEstatus.HeaderText = "Estatus";
            this.ColumnEstatus.Name = "ColumnEstatus";
            this.ColumnEstatus.Width = 400;
            // 
            // FrmMinMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(2021, 1122);
            this.Controls.Add(this.dataGridViewMinMax);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMinMax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minimos y maximos";
            this.Load += new System.EventHandler(this.FrmMinMax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMinMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMinMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecioProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstatus;
    }
}