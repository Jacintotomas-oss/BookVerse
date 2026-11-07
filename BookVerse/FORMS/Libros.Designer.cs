namespace BookVerse.FORMS
{
    partial class Libros
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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Libros));
            panel1 = new Panel();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            label6 = new Label();
            txtNumeroSerie = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cboSerie = new ComboBox();
            cboCategoria = new ComboBox();
            cboEditorial = new ComboBox();
            label2 = new Label();
            cboAutor = new ComboBox();
            label1 = new Label();
            txtTitulo = new TextBox();
            btnSeleccionarPortada = new Button();
            pnlPortada = new Panel();
            dgvLibros = new DataGridView();
            label8 = new Label();
            nudStock = new NumericUpDown();
            lblStock = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lblStock);
            panel1.Controls.Add(nudStock);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(lblDescripcion);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtNumeroSerie);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cboSerie);
            panel1.Controls.Add(cboCategoria);
            panel1.Controls.Add(cboEditorial);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboAutor);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTitulo);
            panel1.Controls.Add(btnSeleccionarPortada);
            panel1.Controls.Add(pnlPortada);
            panel1.Controls.Add(dgvLibros);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 720);
            panel1.TabIndex = 25;
            panel1.Paint += panel1_Paint;
            // 
            // label8 (Título "Gestión de Libros")
            // 
            label8.AutoSize = false;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(30, 15);
            label8.Name = "label8";
            label8.Size = new Size(300, 35);
            label8.TabIndex = 44;
            label8.Text = "Gestión de Libros";
            // 
            // dgvLibros
            // 
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.BackColor = Color.FromArgb(31, 41, 55);
            dgvLibros.BackgroundColor = Color.FromArgb(31, 41, 55);
            dgvLibros.BorderStyle = BorderStyle.None;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.EnableHeadersVisualStyles = false;
            dgvLibros.GridColor = Color.FromArgb(55, 65, 81);
            headerStyle.BackColor = Color.FromArgb(30, 41, 59);
            headerStyle.ForeColor = Color.White;
            headerStyle.SelectionBackColor = Color.FromArgb(30, 41, 59);
            headerStyle.SelectionForeColor = Color.White;
            headerStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvLibros.ColumnHeadersDefaultCellStyle = headerStyle;
            cellStyle.BackColor = Color.FromArgb(31, 41, 55);
            cellStyle.ForeColor = Color.White;
            cellStyle.SelectionBackColor = Color.FromArgb(37, 99, 235);
            cellStyle.SelectionForeColor = Color.White;
            cellStyle.Font = new Font("Segoe UI", 9F);
            dgvLibros.DefaultCellStyle = cellStyle;
            dgvLibros.Location = new System.Drawing.Point(30, 55);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersVisible = false;
            dgvLibros.Size = new System.Drawing.Size(1040, 220);
            dgvLibros.TabIndex = 26;
            // 
            // pnlPortada
            // 
            pnlPortada.BackColor = Color.FromArgb(31, 41, 55);
            pnlPortada.BackgroundImageLayout = ImageLayout.Zoom;
            pnlPortada.BorderStyle = BorderStyle.FixedSingle;
            pnlPortada.Location = new Point(30, 295);
            pnlPortada.Name = "pnlPortada";
            pnlPortada.Size = new Size(180, 240);
            pnlPortada.TabIndex = 27;
            // 
            // btnSeleccionarPortada
            // 
            btnSeleccionarPortada.BackColor = Color.FromArgb(55, 65, 81);
            btnSeleccionarPortada.Cursor = Cursors.Hand;
            btnSeleccionarPortada.FlatAppearance.BorderSize = 0;
            btnSeleccionarPortada.FlatStyle = FlatStyle.Flat;
            btnSeleccionarPortada.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSeleccionarPortada.ForeColor = Color.White;
            btnSeleccionarPortada.Location = new Point(30, 545);
            btnSeleccionarPortada.Name = "btnSeleccionarPortada";
            btnSeleccionarPortada.Size = new Size(180, 38);
            btnSeleccionarPortada.TabIndex = 25;
            btnSeleccionarPortada.Text = "Seleccionar Portada";
            btnSeleccionarPortada.UseVisualStyleBackColor = false;
            // 
            // label1 (Label Título - Columna 1)
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(240, 295);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 29;
            label1.Text = "Título";
            // 
            // txtTitulo (Columna 1)
            // 
            txtTitulo.BackColor = Color.FromArgb(31, 41, 55);
            txtTitulo.BorderStyle = BorderStyle.FixedSingle;
            txtTitulo.Font = new Font("Segoe UI", 9.5F);
            txtTitulo.ForeColor = Color.White;
            txtTitulo.Location = new Point(240, 318);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(390, 28);
            txtTitulo.TabIndex = 28;
            // 
            // label2 (Label Autor - Columna 1)
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(240, 355);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 31;
            label2.Text = "Autor";
            // 
            // cboAutor (Columna 1)
            // 
            cboAutor.BackColor = Color.FromArgb(31, 41, 55);
            cboAutor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAutor.FlatStyle = FlatStyle.Flat;
            cboAutor.Font = new Font("Segoe UI", 9.5F);
            cboAutor.ForeColor = Color.White;
            cboAutor.FormattingEnabled = true;
            cboAutor.Location = new Point(240, 378);
            cboAutor.Name = "cboAutor";
            cboAutor.Size = new Size(390, 28);
            cboAutor.TabIndex = 30;
            // 
            // label3 (Label Editorial - Columna 1)
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(240, 415);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 35;
            label3.Text = "Editorial";
            // 
            // cboEditorial (Columna 1)
            // 
            cboEditorial.BackColor = Color.FromArgb(31, 41, 55);
            cboEditorial.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEditorial.FlatStyle = FlatStyle.Flat;
            cboEditorial.Font = new Font("Segoe UI", 9.5F);
            cboEditorial.ForeColor = Color.White;
            cboEditorial.FormattingEnabled = true;
            cboEditorial.Location = new Point(240, 438);
            cboEditorial.Name = "cboEditorial";
            cboEditorial.Size = new Size(390, 28);
            cboEditorial.TabIndex = 32;
            // 
            // label4 (Label Categoría - Columna 1)
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(240, 475);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 36;
            label4.Text = "Categoría";
            // 
            // cboCategoria (Columna 1)
            // 
            cboCategoria.BackColor = Color.FromArgb(31, 41, 55);
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FlatStyle = FlatStyle.Flat;
            cboCategoria.Font = new Font("Segoe UI", 9.5F);
            cboCategoria.ForeColor = Color.White;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(240, 498);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(390, 28);
            cboCategoria.TabIndex = 33;
            // 
            // label5 (Label Serie - Columna 2)
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(660, 295);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 37;
            label5.Text = "Serie";
            // 
            // cboSerie (Columna 2)
            // 
            cboSerie.BackColor = Color.FromArgb(31, 41, 55);
            cboSerie.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSerie.FlatStyle = FlatStyle.Flat;
            cboSerie.Font = new Font("Segoe UI", 9.5F);
            cboSerie.ForeColor = Color.White;
            cboSerie.FormattingEnabled = true;
            cboSerie.Location = new Point(660, 318);
            cboSerie.Name = "cboSerie";
            cboSerie.Size = new Size(410, 28);
            cboSerie.TabIndex = 34;
            // 
            // label6 (Label N. Serie - Columna 2)
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(660, 355);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 39;
            label6.Text = "N. Serie";
            // 
            // txtNumeroSerie (Columna 2)
            // 
            txtNumeroSerie.BackColor = Color.FromArgb(31, 41, 55);
            txtNumeroSerie.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroSerie.Font = new Font("Segoe UI", 9.5F);
            txtNumeroSerie.ForeColor = Color.White;
            txtNumeroSerie.Location = new Point(660, 378);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(410, 28);
            txtNumeroSerie.TabIndex = 38;
            // 
            // lblStock (Label Stock - Columna 2)
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.Transparent;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStock.ForeColor = Color.White;
            lblStock.Location = new Point(660, 415);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(39, 15);
            lblStock.TabIndex = 48;
            lblStock.Text = "Stock";
            // 
            // nudStock (Columna 2)
            // 
            nudStock.BackColor = Color.FromArgb(31, 41, 55);
            nudStock.BorderStyle = BorderStyle.FixedSingle;
            nudStock.Font = new Font("Segoe UI", 9.5F);
            nudStock.ForeColor = Color.White;
            nudStock.Location = new Point(660, 438);
            nudStock.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(410, 28);
            nudStock.TabIndex = 47;
            nudStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDescripcion (Label Descripción - Columna 2)
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescripcion.ForeColor = Color.White;
            lblDescripcion.Location = new Point(660, 475);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(73, 15);
            lblDescripcion.TabIndex = 45;
            lblDescripcion.Text = "Descripción";
            lblDescripcion.Click += lblDescripcion_Click;
            // 
            // txtDescripcion (Columna 2)
            // 
            txtDescripcion.BackColor = Color.FromArgb(31, 41, 55);
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI", 9F);
            txtDescripcion.ForeColor = Color.White;
            txtDescripcion.Location = new Point(660, 498);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDescripcion.Size = new Size(410, 85);
            txtDescripcion.TabIndex = 46;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(37, 99, 235);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(30, 605);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(248, 42);
            btnAgregar.TabIndex = 40;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(16, 185, 129);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(294, 605);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(248, 42);
            btnActualizar.TabIndex = 41;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(220, 38, 38);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(558, 605);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(248, 42);
            btnEliminar.TabIndex = 42;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(55, 65, 81);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(822, 605);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(248, 42);
            btnLimpiar.TabIndex = 43;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // Libros
            // 
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.FromArgb(17, 24, 39);
            this.BackgroundImage = null;
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.Controls.Add(panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 740);
            this.Name = "Libros";
            this.Size = new System.Drawing.Size(1120, 760);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Gestión de Libros - BookVerse";
            this.Load += Libros_Load;
            this.Scroll += True;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private Label label6;
        private TextBox txtNumeroSerie;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cboSerie;
        private ComboBox cboCategoria;
        private ComboBox cboEditorial;
        private Label label2;
        private ComboBox cboAutor;
        private Label label1;
        private TextBox txtTitulo;
        private Button btnSeleccionarPortada;
        private Panel pnlPortada;
        private DataGridView dgvLibros;
        private Label label8;
        private Label lblStock;
        private NumericUpDown nudStock;
    }
}