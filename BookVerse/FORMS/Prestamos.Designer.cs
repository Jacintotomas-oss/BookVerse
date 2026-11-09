namespace BookVerse.FORMS
{
    partial class Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            panel1 = new Panel();
            btnGenerarPdf = new Button();
            AutorizarBtn = new Button();
            txtPrestatario = new TextBox();
            lblUsuario = new Label();
            btnLimpiar = new Button();
            btnRegistrarDevolucion = new Button();
            btnAutorizar = new Button();
            btnSolicitar = new Button();
            label5 = new Label();
            label4 = new Label();
            dtpFechaDevolucion = new DateTimePicker();
            dtpFechaPrestamo = new DateTimePicker();
            label2 = new Label();
            cboLibro = new ComboBox();
            dgvPrestamos = new DataGridView();
            label1 = new Label();
            txtTelefono = new TextBox();
            Telefono = new Label();
            txtDetalle = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtDetalle);
            panel1.Controls.Add(Telefono);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(btnGenerarPdf);
            panel1.Controls.Add(AutorizarBtn);
            panel1.Controls.Add(txtPrestatario);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnRegistrarDevolucion);
            panel1.Controls.Add(btnAutorizar);
            panel1.Controls.Add(btnSolicitar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtpFechaDevolucion);
            panel1.Controls.Add(dtpFechaPrestamo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboLibro);
            panel1.Controls.Add(dgvPrestamos);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 580);
            panel1.TabIndex = 18;
            // 
            // btnGenerarPdf
            // 
            btnGenerarPdf.BackColor = Color.FromArgb(220, 38, 38);
            btnGenerarPdf.Cursor = Cursors.Hand;
            btnGenerarPdf.FlatAppearance.BorderSize = 0;
            btnGenerarPdf.FlatStyle = FlatStyle.Flat;
            btnGenerarPdf.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGenerarPdf.ForeColor = Color.White;
            btnGenerarPdf.Location = new Point(480, 508);
            btnGenerarPdf.Name = "btnGenerarPdf";
            btnGenerarPdf.Size = new Size(430, 38);
            btnGenerarPdf.TabIndex = 33;
            btnGenerarPdf.Text = "Exportar PDF (Comprobante)";
            btnGenerarPdf.UseVisualStyleBackColor = false;
            // 
            // AutorizarBtn
            // 
            AutorizarBtn.BackColor = Color.FromArgb(16, 185, 129);
            AutorizarBtn.Cursor = Cursors.Hand;
            AutorizarBtn.FlatAppearance.BorderSize = 0;
            AutorizarBtn.FlatStyle = FlatStyle.Flat;
            AutorizarBtn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            AutorizarBtn.ForeColor = Color.White;
            AutorizarBtn.Location = new Point(325, 453);
            AutorizarBtn.Name = "AutorizarBtn";
            AutorizarBtn.Size = new Size(280, 40);
            AutorizarBtn.TabIndex = 32;
            AutorizarBtn.Text = "Autorizar";
            AutorizarBtn.UseVisualStyleBackColor = false;
            // 
            // txtPrestatario
            // 
            txtPrestatario.Font = new Font("Segoe UI", 9.5F);
            txtPrestatario.Location = new Point(500, 298);
            txtPrestatario.Name = "txtPrestatario";
            txtPrestatario.Size = new Size(420, 24);
            txtPrestatario.TabIndex = 31;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(500, 275);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(96, 15);
            lblUsuario.TabIndex = 30;
            lblUsuario.Text = "Usuario / Lector";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(55, 65, 81);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(20, 508);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(430, 38);
            btnLimpiar.TabIndex = 28;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarDevolucion
            // 
            btnRegistrarDevolucion.BackColor = Color.FromArgb(139, 92, 246);
            btnRegistrarDevolucion.Cursor = Cursors.Hand;
            btnRegistrarDevolucion.FlatAppearance.BorderSize = 0;
            btnRegistrarDevolucion.FlatStyle = FlatStyle.Flat;
            btnRegistrarDevolucion.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRegistrarDevolucion.ForeColor = Color.White;
            btnRegistrarDevolucion.Location = new Point(630, 453);
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Size = new Size(280, 40);
            btnRegistrarDevolucion.TabIndex = 27;
            btnRegistrarDevolucion.Text = "Registrar Devolución";
            btnRegistrarDevolucion.UseVisualStyleBackColor = false;
            // 
            // btnAutorizar
            // 
            btnAutorizar.Location = new Point(325, 453);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(280, 40);
            btnAutorizar.TabIndex = 29;
            btnAutorizar.Visible = false;
            // 
            // btnSolicitar
            // 
            btnSolicitar.BackColor = Color.FromArgb(37, 99, 235);
            btnSolicitar.Cursor = Cursors.Hand;
            btnSolicitar.FlatAppearance.BorderSize = 0;
            btnSolicitar.FlatStyle = FlatStyle.Flat;
            btnSolicitar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSolicitar.ForeColor = Color.White;
            btnSolicitar.Location = new Point(20, 453);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(280, 40);
            btnSolicitar.TabIndex = 26;
            btnSolicitar.Text = "Solicitar";
            btnSolicitar.UseVisualStyleBackColor = false;
            btnSolicitar.Click += btnSolicitar_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(500, 340);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 25;
            label5.Text = "Fecha Devolución";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 340);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 24;
            label4.Text = "Fecha Préstamo";
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Font = new Font("Segoe UI", 9.5F);
            dtpFechaDevolucion.Location = new Point(500, 363);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(420, 24);
            dtpFechaDevolucion.TabIndex = 23;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Font = new Font("Segoe UI", 9.5F);
            dtpFechaPrestamo.Location = new Point(30, 363);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(420, 24);
            dtpFechaPrestamo.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 275);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 21;
            label2.Text = "Libro";
            // 
            // cboLibro
            // 
            cboLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLibro.Font = new Font("Segoe UI", 9.5F);
            cboLibro.FormattingEnabled = true;
            cboLibro.Location = new Point(30, 298);
            cboLibro.Name = "cboLibro";
            cboLibro.Size = new Size(420, 25);
            cboLibro.TabIndex = 20;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.BackgroundColor = Color.FromArgb(31, 41, 55);
            dgvPrestamos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPrestamos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPrestamos.EnableHeadersVisualStyles = false;
            dgvPrestamos.GridColor = Color.FromArgb(55, 65, 81);
            dgvPrestamos.Location = new Point(30, 60);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.RowHeadersVisible = false;
            dgvPrestamos.Size = new Size(890, 200);
            dgvPrestamos.TabIndex = 19;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 16);
            label1.Name = "label1";
            label1.Size = new Size(200, 35);
            label1.TabIndex = 18;
            label1.Text = "Préstamos";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(32, 413);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(418, 23);
            txtTelefono.TabIndex = 34;
            // 
            // Telefono
            // 
            Telefono.AutoSize = true;
            Telefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Telefono.ForeColor = Color.White;
            Telefono.Location = new Point(35, 396);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(56, 15);
            Telefono.TabIndex = 35;
            Telefono.Text = "Telefono";
            // 
            // txtDetalle
            // 
            txtDetalle.Location = new Point(500, 413);
            txtDetalle.Multiline = true;
            txtDetalle.Name = "txtDetalle";
            txtDetalle.ReadOnly = true;
            txtDetalle.ScrollBars = ScrollBars.Vertical;
            txtDetalle.Size = new Size(420, 23);
            txtDetalle.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(501, 393);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 37;
            label3.Text = "Detalle";
            // 
            // Prestamos
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(17, 24, 39);
            ClientSize = new Size(950, 580);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Prestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookVerse - Préstamos";
            Load += Prestamos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button AutorizarBtn;
        private TextBox txtPrestatario;
        private Label lblUsuario;
        private Button btnLimpiar;
        private Button btnRegistrarDevolucion;
        private Button btnAutorizar;
        private Button btnSolicitar;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpFechaDevolucion;
        private DateTimePicker dtpFechaPrestamo;
        private Label label2;
        private ComboBox cboLibro;
        private DataGridView dgvPrestamos;
        private Label label1;
        private Button btnGenerarPdf;
        private Label Telefono;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtDetalle;
    }
}
