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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            panel1 = new Panel();
            AutorizarBtn = new Button();
            textBox1 = new TextBox();
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
            btnGenerarPdf = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnGenerarPdf);
            panel1.Controls.Add(AutorizarBtn);
            panel1.Controls.Add(textBox1);
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
            panel1.Padding = new Padding(0);
            panel1.Size = new Size(950, 580);
            panel1.TabIndex = 18;
            // 
            // label1 (Título "Préstamos")
            // 
            label1.AutoSize = false;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 16);
            label1.Name = "label1";
            label1.Size = new Size(200, 35);
            label1.TabIndex = 18;
            label1.Text = "Préstamos";
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.BackColor = Color.FromArgb(31, 41, 55);
            dgvPrestamos.BackgroundColor = Color.FromArgb(31, 41, 55);
            dgvPrestamos.BorderStyle = BorderStyle.None;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.EnableHeadersVisualStyles = false;
            dgvPrestamos.GridColor = Color.FromArgb(55, 65, 81);
            headerStyle.BackColor = Color.FromArgb(30, 41, 59);
            headerStyle.ForeColor = Color.White;
            headerStyle.SelectionBackColor = Color.FromArgb(30, 41, 59);
            headerStyle.SelectionForeColor = Color.White;
            headerStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvPrestamos.ColumnHeadersDefaultCellStyle = headerStyle;
            cellStyle.BackColor = Color.FromArgb(31, 41, 55);
            cellStyle.ForeColor = Color.White;
            cellStyle.SelectionBackColor = Color.FromArgb(37, 99, 235);
            cellStyle.SelectionForeColor = Color.White;
            cellStyle.Font = new Font("Segoe UI", 9F);
            dgvPrestamos.DefaultCellStyle = cellStyle;
            dgvPrestamos.Location = new Point(30, 60);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.RowHeadersVisible = false;
            dgvPrestamos.Size = new Size(890, 200);
            dgvPrestamos.TabIndex = 19;
            // 
            // label2 (Label Libro - Columna Izquierda)
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 275);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 21;
            label2.Text = "Libro";
            // 
            // cboLibro (Columna Izquierda)
            // 
            cboLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLibro.Font = new Font("Segoe UI", 9.5F);
            cboLibro.FormattingEnabled = true;
            cboLibro.Location = new Point(30, 298);
            cboLibro.Name = "cboLibro";
            cboLibro.Size = new Size(420, 28);
            cboLibro.TabIndex = 20;
            // 
            // label4 (Label Fecha Préstamo - Columna Izquierda)
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 340);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 24;
            label4.Text = "Fecha Préstamo";
            // 
            // dtpFechaPrestamo (Columna Izquierda)
            // 
            dtpFechaPrestamo.Font = new Font("Segoe UI", 9.5F);
            dtpFechaPrestamo.Location = new Point(30, 363);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(420, 28);
            dtpFechaPrestamo.TabIndex = 22;
            // 
            // lblUsuario (Label Lector / Usuario - Columna Derecha)
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(500, 275);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(95, 15);
            lblUsuario.TabIndex = 30;
            lblUsuario.Text = "Usuario / Lector";
            // 
            // textBox1 (Columna Derecha)
            // 
            textBox1.Font = new Font("Segoe UI", 9.5F);
            textBox1.Location = new Point(500, 298);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(420, 28);
            textBox1.TabIndex = 31;
            // 
            // label5 (Label Fecha Devolución - Columna Derecha)
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(500, 340);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 25;
            label5.Text = "Fecha Devolución";
            // 
            // dtpFechaDevolucion (Columna Derecha)
            // 
            dtpFechaDevolucion.Font = new Font("Segoe UI", 9.5F);
            dtpFechaDevolucion.Location = new Point(500, 363);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(420, 28);
            dtpFechaDevolucion.TabIndex = 23;
            // 
            // btnSolicitar (Fila 1)
            // 
            btnSolicitar.BackColor = Color.FromArgb(37, 99, 235);
            btnSolicitar.Cursor = Cursors.Hand;
            btnSolicitar.FlatAppearance.BorderSize = 0;
            btnSolicitar.FlatStyle = FlatStyle.Flat;
            btnSolicitar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSolicitar.ForeColor = Color.White;
            btnSolicitar.Location = new Point(30, 415);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(280, 40);
            btnSolicitar.TabIndex = 26;
            btnSolicitar.Text = "Solicitar";
            btnSolicitar.UseVisualStyleBackColor = false;
            btnSolicitar.Click += btnSolicitar_Click_1;
            // 
            // AutorizarBtn (Fila 1)
            // 
            AutorizarBtn.BackColor = Color.FromArgb(16, 185, 129);
            AutorizarBtn.Cursor = Cursors.Hand;
            AutorizarBtn.FlatAppearance.BorderSize = 0;
            AutorizarBtn.FlatStyle = FlatStyle.Flat;
            AutorizarBtn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            AutorizarBtn.ForeColor = Color.White;
            AutorizarBtn.Location = new Point(335, 415);
            AutorizarBtn.Name = "AutorizarBtn";
            AutorizarBtn.Size = new Size(280, 40);
            AutorizarBtn.TabIndex = 32;
            AutorizarBtn.Text = "Autorizar";
            AutorizarBtn.UseVisualStyleBackColor = false;
            // 
            // btnAutorizar (Oculto para evitar botón fantasma)
            // 
            btnAutorizar.Location = new Point(335, 415);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(280, 40);
            btnAutorizar.TabIndex = 29;
            btnAutorizar.Visible = false;
            // 
            // btnRegistrarDevolucion (Fila 1)
            // 
            btnRegistrarDevolucion.BackColor = Color.FromArgb(139, 92, 246);
            btnRegistrarDevolucion.Cursor = Cursors.Hand;
            btnRegistrarDevolucion.FlatAppearance.BorderSize = 0;
            btnRegistrarDevolucion.FlatStyle = FlatStyle.Flat;
            btnRegistrarDevolucion.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRegistrarDevolucion.ForeColor = Color.White;
            btnRegistrarDevolucion.Location = new Point(640, 415);
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Size = new Size(280, 40);
            btnRegistrarDevolucion.TabIndex = 27;
            btnRegistrarDevolucion.Text = "Registrar Devolución";
            btnRegistrarDevolucion.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar (Fila 2)
            // 
            btnLimpiar.BackColor = Color.FromArgb(55, 65, 81);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(30, 470);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(430, 38);
            btnLimpiar.TabIndex = 28;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnGenerarPdf (Fila 2)
            // 
            btnGenerarPdf.BackColor = Color.FromArgb(220, 38, 38);
            btnGenerarPdf.Cursor = Cursors.Hand;
            btnGenerarPdf.FlatAppearance.BorderSize = 0;
            btnGenerarPdf.FlatStyle = FlatStyle.Flat;
            btnGenerarPdf.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGenerarPdf.ForeColor = Color.White;
            btnGenerarPdf.Location = new Point(490, 470);
            btnGenerarPdf.Name = "btnGenerarPdf";
            btnGenerarPdf.Size = new Size(430, 38);
            btnGenerarPdf.TabIndex = 33;
            btnGenerarPdf.Text = "Exportar PDF (Comprobante)";
            btnGenerarPdf.UseVisualStyleBackColor = false;
            // 
            // Prestamos
            // 
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.FromArgb(17, 24, 39);
            this.BackgroundImage = null;
            this.ClientSize = new Size(950, 580);
            this.Controls.Add(panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Prestamos";
            this.Size = new Size(966, 619);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Préstamos - BookVerse";
            this.Load += Prestamos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button AutorizarBtn;
        private TextBox textBox1;
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
    }
}
