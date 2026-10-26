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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
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
            panel1.Location = new Point(-9, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 742);
            panel1.TabIndex = 18;
            // 
            // AutorizarBtn
            // 
            AutorizarBtn.BackColor = Color.FromArgb(255, 128, 128);
            AutorizarBtn.Cursor = Cursors.Hand;
            AutorizarBtn.ForeColor = SystemColors.ButtonHighlight;
            AutorizarBtn.Location = new Point(335, 500);
            AutorizarBtn.Name = "AutorizarBtn";
            AutorizarBtn.Size = new Size(186, 54);
            AutorizarBtn.TabIndex = 32;
            AutorizarBtn.Text = "Autorizar";
            AutorizarBtn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(278, 355);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(512, 23);
            textBox1.TabIndex = 31;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Silver;
            lblUsuario.Location = new Point(213, 358);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(58, 17);
            lblUsuario.TabIndex = 30;
            lblUsuario.Text = "Usuario";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.RosyBrown;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(73, 579);
            btnLimpiar.Margin = new Padding(4, 3, 4, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(725, 54);
            btnLimpiar.TabIndex = 28;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarDevolucion
            // 
            btnRegistrarDevolucion.BackColor = Color.HotPink;
            btnRegistrarDevolucion.Cursor = Cursors.Hand;
            btnRegistrarDevolucion.FlatAppearance.BorderSize = 0;
            btnRegistrarDevolucion.FlatStyle = FlatStyle.Flat;
            btnRegistrarDevolucion.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnRegistrarDevolucion.ForeColor = Color.White;
            btnRegistrarDevolucion.Location = new Point(549, 500);
            btnRegistrarDevolucion.Margin = new Padding(4, 3, 4, 3);
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Size = new Size(246, 54);
            btnRegistrarDevolucion.TabIndex = 27;
            btnRegistrarDevolucion.Text = "Registrar devolución";
            btnRegistrarDevolucion.UseVisualStyleBackColor = false;
            // 
            // btnAutorizar
            // 
            btnAutorizar.Location = new Point(12, 10);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(75, 23);
            btnAutorizar.TabIndex = 29;
            // 
            // btnSolicitar
            // 
            btnSolicitar.BackColor = Color.Plum;
            btnSolicitar.Cursor = Cursors.Hand;
            btnSolicitar.FlatAppearance.BorderSize = 0;
            btnSolicitar.FlatStyle = FlatStyle.Flat;
            btnSolicitar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnSolicitar.ForeColor = Color.White;
            btnSolicitar.Location = new Point(73, 500);
            btnSolicitar.Margin = new Padding(4, 3, 4, 3);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(224, 54);
            btnSolicitar.TabIndex = 26;
            btnSolicitar.Text = "Solicitar";
            btnSolicitar.UseVisualStyleBackColor = false;
            btnSolicitar.Click += btnSolicitar_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Font = new Font("Georgia", 10F);
            label5.Location = new Point(176, 449);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(95, 17);
            label5.TabIndex = 25;
            label5.Text = "F. Devolucion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Font = new Font("Georgia", 10F);
            label4.Location = new Point(188, 395);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 17);
            label4.TabIndex = 24;
            label4.Text = "F. Prestamo";
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Font = new Font("Georgia", 10F);
            dtpFechaDevolucion.Location = new Point(278, 444);
            dtpFechaDevolucion.Margin = new Padding(4, 3, 4, 3);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(513, 23);
            dtpFechaDevolucion.TabIndex = 23;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Font = new Font("Georgia", 10F);
            dtpFechaPrestamo.Location = new Point(278, 390);
            dtpFechaPrestamo.Margin = new Padding(4, 3, 4, 3);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(513, 23);
            dtpFechaPrestamo.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Georgia", 10F);
            label2.Location = new Point(229, 323);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 21;
            label2.Text = "Libro";
            // 
            // cboLibro
            // 
            cboLibro.FormattingEnabled = true;
            cboLibro.Location = new Point(279, 320);
            cboLibro.Margin = new Padding(4, 3, 4, 3);
            cboLibro.Name = "cboLibro";
            cboLibro.Size = new Size(513, 24);
            cboLibro.TabIndex = 20;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(73, 99);
            dgvPrestamos.Margin = new Padding(4, 3, 4, 3);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.RowHeadersWidth = 62;
            dgvPrestamos.Size = new Size(719, 197);
            dgvPrestamos.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(335, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 31);
            label1.TabIndex = 18;
            label1.Text = "Prestamos";
            // 
            // Prestamos
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(841, 705);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Georgia", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimizeBox = false;
            Name = "Prestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prestamos";
            Load += Prestamos_Load;
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
    }
}