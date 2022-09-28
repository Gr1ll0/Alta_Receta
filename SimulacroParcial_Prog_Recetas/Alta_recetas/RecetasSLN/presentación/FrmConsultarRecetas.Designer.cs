
namespace RecetasSLN.presentación
{
    partial class FrmConsultarRecetas
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
            this.lblTotalIngredientes = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboIngrediente = new System.Windows.Forms.ComboBox();
            this.txtCheff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNro = new System.Windows.Forms.Label();
            this.acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalIngredientes
            // 
            this.lblTotalIngredientes.AutoSize = true;
            this.lblTotalIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIngredientes.Location = new System.Drawing.Point(320, 335);
            this.lblTotalIngredientes.Name = "lblTotalIngredientes";
            this.lblTotalIngredientes.Size = new System.Drawing.Size(109, 13);
            this.lblTotalIngredientes.TabIndex = 35;
            this.lblTotalIngredientes.Text = "Total de ingredientes:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(310, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Ingrese nombre de su receta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tipo de receta:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "1-Comida china",
            "2-Comida rápida",
            "3-Comida tradicional",
            "4-Pastas",
            "5-Recetas de carne",
            "6-Recetas de mariscos"});
            this.cboTipo.Location = new System.Drawing.Point(82, 107);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(199, 21);
            this.cboTipo.TabIndex = 2;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(229, 153);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(136, 20);
            this.nudCantidad.TabIndex = 4;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(245, 381);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(166, 381);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(374, 152);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboIngrediente
            // 
            this.cboIngrediente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIngrediente.FormattingEnabled = true;
            this.cboIngrediente.Items.AddRange(new object[] {
            "seleccionar"});
            this.cboIngrediente.Location = new System.Drawing.Point(12, 152);
            this.cboIngrediente.Name = "cboIngrediente";
            this.cboIngrediente.Size = new System.Drawing.Size(213, 21);
            this.cboIngrediente.TabIndex = 3;
            // 
            // txtCheff
            // 
            this.txtCheff.Location = new System.Drawing.Point(82, 81);
            this.txtCheff.Name = "txtCheff";
            this.txtCheff.Size = new System.Drawing.Size(310, 20);
            this.txtCheff.TabIndex = 1;
            this.txtCheff.Text = "Ingrese el nombre del cheff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cheff:";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.Location = new System.Drawing.Point(78, 14);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(102, 20);
            this.lblNro.TabIndex = 23;
            this.lblNro.Text = "Receta #: 1";
            // 
            // acciones
            // 
            this.acciones.HeaderText = "Acciones";
            this.acciones.MinimumWidth = 6;
            this.acciones.Name = "acciones";
            this.acciones.ReadOnly = true;
            this.acciones.Text = "Quitar";
            this.acciones.UseColumnTextForButtonValue = true;
            this.acciones.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // ingrediente
            // 
            this.ingrediente.HeaderText = "Ingrediente";
            this.ingrediente.MinimumWidth = 6;
            this.ingrediente.Name = "ingrediente";
            this.ingrediente.ReadOnly = true;
            this.ingrediente.Width = 125;
            // 
            // detalle
            // 
            this.detalle.HeaderText = "Column1";
            this.detalle.MinimumWidth = 6;
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Visible = false;
            this.detalle.Width = 125;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalle,
            this.ingrediente,
            this.Cantidad,
            this.acciones});
            this.dgvDetalles.Location = new System.Drawing.Point(34, 181);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.Size = new System.Drawing.Size(429, 140);
            this.dgvDetalles.TabIndex = 30;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // FrmConsultarRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 416);
            this.Controls.Add(this.lblTotalIngredientes);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboIngrediente);
            this.Controls.Add(this.txtCheff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNro);
            this.Name = "FrmConsultarRecetas";
            this.Text = "Consultar recetas";
            this.Load += new System.EventHandler(this.FrmConsultarRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalIngredientes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboIngrediente;
        private System.Windows.Forms.TextBox txtCheff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.DataGridViewButtonColumn acciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridView dgvDetalles;
    }
}