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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Libros));
            panel1 = new Panel();
            label6 = new Label();
            txtNumeroSerie = new TextBox();
            label5 = new Label();
            cboSerie = new ComboBox();
            chkBoxSeries = new CheckBox();
            lblStock = new Label();
            nudStock = new NumericUpDown();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            label4 = new Label();
            label3 = new Label();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtNumeroSerie);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cboSerie);
            panel1.Controls.Add(chkBoxSeries);
            panel1.Controls.Add(lblStock);
            panel1.Controls.Add(nudStock);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(lblDescripcion);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
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
            panel1.Size = new Size(1104, 721);
            panel1.TabIndex = 25;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(660, 530);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 53;
            label6.Text = "N. Serie";
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.BackColor = Color.FromArgb(31, 41, 55);
            txtNumeroSerie.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroSerie.Font = new Font("Segoe UI", 9.5F);
            txtNumeroSerie.ForeColor = Color.White;
            txtNumeroSerie.Location = new Point(660, 553);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(410, 24);
            txtNumeroSerie.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(660, 475);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 51;
            label5.Text = "Serie";
            // 
            // cboSerie
            // 
            cboSerie.BackColor = Color.FromArgb(31, 41, 55);
            cboSerie.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSerie.FlatStyle = FlatStyle.Flat;
            cboSerie.Font = new Font("Segoe UI", 9.5F);
            cboSerie.ForeColor = Color.White;
            cboSerie.FormattingEnabled = true;
            cboSerie.Location = new Point(660, 498);
            cboSerie.Name = "cboSerie";
            cboSerie.Size = new Size(410, 25);
            cboSerie.TabIndex = 50;
            // 
            // chkBoxSeries
            // 
            chkBoxSeries.AutoSize = true;
            chkBoxSeries.Cursor = Cursors.Hand;
            chkBoxSeries.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkBoxSeries.ForeColor = Color.White;
            chkBoxSeries.Location = new Point(246, 550);
            chkBoxSeries.Name = "chkBoxSeries";
            chkBoxSeries.Size = new Size(105, 19);
            chkBoxSeries.TabIndex = 49;
            chkBoxSeries.Text = "Series / Sagas ";
            chkBoxSeries.UseVisualStyleBackColor = true;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.Transparent;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStock.ForeColor = Color.White;
            lblStock.Location = new Point(660, 295);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(39, 15);
            lblStock.TabIndex = 48;
            lblStock.Text = "Stock";
            // 
            // nudStock
            // 
            nudStock.BackColor = Color.FromArgb(31, 41, 55);
            nudStock.BorderStyle = BorderStyle.FixedSingle;
            nudStock.Font = new Font("Segoe UI", 9.5F);
            nudStock.ForeColor = Color.White;
            nudStock.Location = new Point(660, 318);
            nudStock.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(410, 24);
            nudStock.TabIndex = 47;
            nudStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(31, 41, 55);
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI", 9F);
            txtDescripcion.ForeColor = Color.White;
            txtDescripcion.Location = new Point(660, 378);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(410, 85);
            txtDescripcion.TabIndex = 46;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescripcion.ForeColor = Color.White;
            lblDescripcion.Location = new Point(660, 355);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 45;
            lblDescripcion.Text = "Descripción";
            lblDescripcion.Click += lblDescripcion_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(240, 475);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 36;
            label4.Text = "Categoría";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(240, 415);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 35;
            label3.Text = "Editorial";
            // 
            // cboCategoria
            // 
            cboCategoria.BackColor = Color.FromArgb(31, 41, 55);
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FlatStyle = FlatStyle.Flat;
            cboCategoria.Font = new Font("Segoe UI", 9.5F);
            cboCategoria.ForeColor = Color.White;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(240, 498);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(390, 25);
            cboCategoria.TabIndex = 33;
            // 
            // cboEditorial
            // 
            cboEditorial.BackColor = Color.FromArgb(31, 41, 55);
            cboEditorial.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEditorial.FlatStyle = FlatStyle.Flat;
            cboEditorial.Font = new Font("Segoe UI", 9.5F);
            cboEditorial.ForeColor = Color.White;
            cboEditorial.FormattingEnabled = true;
            cboEditorial.Location = new Point(240, 438);
            cboEditorial.Name = "cboEditorial";
            cboEditorial.Size = new Size(390, 25);
            cboEditorial.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(240, 355);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 31;
            label2.Text = "Autor";
            // 
            // cboAutor
            // 
            cboAutor.BackColor = Color.FromArgb(31, 41, 55);
            cboAutor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAutor.FlatStyle = FlatStyle.Flat;
            cboAutor.Font = new Font("Segoe UI", 9.5F);
            cboAutor.ForeColor = Color.White;
            cboAutor.FormattingEnabled = true;
            cboAutor.Location = new Point(240, 378);
            cboAutor.Name = "cboAutor";
            cboAutor.Size = new Size(390, 25);
            cboAutor.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(240, 295);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 29;
            label1.Text = "Título";
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.FromArgb(31, 41, 55);
            txtTitulo.BorderStyle = BorderStyle.FixedSingle;
            txtTitulo.Font = new Font("Segoe UI", 9.5F);
            txtTitulo.ForeColor = Color.White;
            txtTitulo.Location = new Point(240, 318);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(390, 24);
            txtTitulo.TabIndex = 28;
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
            // dgvLibros
            // 
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.BackgroundColor = Color.FromArgb(31, 41, 55);
            dgvLibros.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLibros.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLibros.EnableHeadersVisualStyles = false;
            dgvLibros.GridColor = Color.FromArgb(55, 65, 81);
            dgvLibros.Location = new Point(30, 55);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersVisible = false;
            dgvLibros.Size = new Size(1040, 220);
            dgvLibros.TabIndex = 26;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(30, 15);
            label8.Name = "label8";
            label8.Size = new Size(300, 35);
            label8.TabIndex = 44;
            label8.Text = "Gestión de Libros";
            // 
            // Libros
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(17, 24, 39);
            ClientSize = new Size(1104, 721);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1100, 726);
            Name = "Libros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookVerse - Gestión de Libros";
            Load += Libros_Load;
            Scroll += True;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
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
        private Label label4;
        private Label label3;
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
        private CheckBox chkBoxSeries;
        private Label label6;
        private TextBox txtNumeroSerie;
        private Label label5;
        private ComboBox cboSerie;
    }
}