namespace AppTienda
{
    partial class FrmAdministrador
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
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.nudNumeroVenta = new System.Windows.Forms.NumericUpDown();
            this.btmAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.gbBuscador = new System.Windows.Forms.GroupBox();
            this.chkNombre = new System.Windows.Forms.CheckBox();
            this.chkFechaDescendente = new System.Windows.Forms.CheckBox();
            this.chkFechaAscendente = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LvVentas = new System.Windows.Forms.ListView();
            this.NumeroVenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroVenta)).BeginInit();
            this.gbBuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(146, 127);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(200, 22);
            this.txtProducto.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(143, 164);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(203, 22);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_SoloNumeros);
            // 
            // nudNumeroVenta
            // 
            this.nudNumeroVenta.Location = new System.Drawing.Point(146, 87);
            this.nudNumeroVenta.Name = "nudNumeroVenta";
            this.nudNumeroVenta.Size = new System.Drawing.Size(200, 22);
            this.nudNumeroVenta.TabIndex = 3;
            // 
            // btmAgregar
            // 
            this.btmAgregar.Location = new System.Drawing.Point(271, 238);
            this.btmAgregar.Name = "btmAgregar";
            this.btmAgregar.Size = new System.Drawing.Size(75, 23);
            this.btmAgregar.TabIndex = 4;
            this.btmAgregar.Text = "Comprar";
            this.btmAgregar.UseVisualStyleBackColor = true;
            this.btmAgregar.Click += new System.EventHandler(this.btmAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(818, 419);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 40);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(384, 421);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(83, 40);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(146, 48);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 7;
            // 
            // gbBuscador
            // 
            this.gbBuscador.Controls.Add(this.chkNombre);
            this.gbBuscador.Controls.Add(this.chkFechaDescendente);
            this.gbBuscador.Controls.Add(this.chkFechaAscendente);
            this.gbBuscador.Controls.Add(this.btnBuscar);
            this.gbBuscador.Location = new System.Drawing.Point(107, 264);
            this.gbBuscador.Name = "gbBuscador";
            this.gbBuscador.Size = new System.Drawing.Size(239, 195);
            this.gbBuscador.TabIndex = 8;
            this.gbBuscador.TabStop = false;
            this.gbBuscador.Text = "Buscador";
            // 
            // chkNombre
            // 
            this.chkNombre.AutoSize = true;
            this.chkNombre.Location = new System.Drawing.Point(42, 121);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(78, 20);
            this.chkNombre.TabIndex = 12;
            this.chkNombre.Text = "Nombre";
            this.chkNombre.UseVisualStyleBackColor = true;
            this.chkNombre.CheckedChanged += new System.EventHandler(this.chkNombre_CheckedChanged);
            // 
            // chkFechaDescendente
            // 
            this.chkFechaDescendente.AutoSize = true;
            this.chkFechaDescendente.Location = new System.Drawing.Point(42, 82);
            this.chkFechaDescendente.Name = "chkFechaDescendente";
            this.chkFechaDescendente.Size = new System.Drawing.Size(148, 20);
            this.chkFechaDescendente.TabIndex = 11;
            this.chkFechaDescendente.Text = "FechaDescendente";
            this.chkFechaDescendente.UseVisualStyleBackColor = true;
            this.chkFechaDescendente.CheckedChanged += new System.EventHandler(this.chkFechaDescendente_CheckedChanged);
            // 
            // chkFechaAscendente
            // 
            this.chkFechaAscendente.AutoSize = true;
            this.chkFechaAscendente.Location = new System.Drawing.Point(42, 45);
            this.chkFechaAscendente.Name = "chkFechaAscendente";
            this.chkFechaAscendente.Size = new System.Drawing.Size(149, 20);
            this.chkFechaAscendente.TabIndex = 10;
            this.chkFechaAscendente.Text = "Fechas Ascendente";
            this.chkFechaAscendente.UseVisualStyleBackColor = true;
            this.chkFechaAscendente.CheckedChanged += new System.EventHandler(this.chkFechaAscendente_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(153, 166);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(143, 201);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(203, 22);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_SoloNumeros);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(488, 421);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(82, 40);
            this.btnMostrar.TabIndex = 10;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(25, 89);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(112, 16);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "Numero de Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total";
            // 
            // LvVentas
            // 
            this.LvVentas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumeroVenta,
            this.Fecha,
            this.Nombre,
            this.Cantidad,
            this.Total});
            this.LvVentas.FullRowSelect = true;
            this.LvVentas.HideSelection = false;
            this.LvVentas.Location = new System.Drawing.Point(384, 48);
            this.LvVentas.Name = "LvVentas";
            this.LvVentas.Size = new System.Drawing.Size(696, 337);
            this.LvVentas.TabIndex = 16;
            this.LvVentas.UseCompatibleStateImageBehavior = false;
            this.LvVentas.View = System.Windows.Forms.View.Details;
            this.LvVentas.SelectedIndexChanged += new System.EventHandler(this.lvVentas_SelectedIndexChanged);
            // 
            // NumeroVenta
            // 
            this.NumeroVenta.Text = "NumeroVenta";
            // 
            // Fecha
            // 
            this.Fecha.Text = "Fecha";
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            // 
            // Total
            // 
            this.Total.Text = "Total";
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 483);
            this.Controls.Add(this.LvVentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.gbBuscador);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btmAgregar);
            this.Controls.Add(this.nudNumeroVenta);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProducto);
            this.Name = "FrmAdministrador";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FrmAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroVenta)).EndInit();
            this.gbBuscador.ResumeLayout(false);
            this.gbBuscador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.NumericUpDown nudNumeroVenta;
        private System.Windows.Forms.Button btmAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox gbBuscador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.CheckBox chkNombre;
        private System.Windows.Forms.CheckBox chkFechaDescendente;
        private System.Windows.Forms.CheckBox chkFechaAscendente;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView LvVentas;
        private System.Windows.Forms.ColumnHeader NumeroVenta;
        private System.Windows.Forms.ColumnHeader Fecha;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Total;
    }
}