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
            label1 = new Label();
            dgvPrestamos = new DataGridView();
            cboLibro = new ComboBox();
            label2 = new Label();
            dtpFechaPrestamo = new DateTimePicker();
            dtpFechaDevolucion = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            btnSolicitar = new Button();
            btnAutorizar = new Button();
            btnRegistrarDevolucion = new Button();
            btnLimpiar = new Button();
            lblUsuario = new Label();
            textBox1 = new TextBox();
            AutorizarBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 20F, FontStyle.Bold);
            label1.Location = new Point(300, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 46);
            label1.TabIndex = 0;
            label1.Text = "Prestamos";
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(61, 89);
            dgvPrestamos.Margin = new Padding(4, 3, 4, 3);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.RowHeadersWidth = 62;
            dgvPrestamos.Size = new Size(719, 197);
            dgvPrestamos.TabIndex = 1;
            // 
            // cboLibro
            // 
            cboLibro.FormattingEnabled = true;
            cboLibro.Location = new Point(267, 310);
            cboLibro.Margin = new Padding(4, 3, 4, 3);
            cboLibro.Name = "cboLibro";
            cboLibro.Size = new Size(513, 32);
            cboLibro.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10F);
            label2.Location = new Point(191, 310);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 24);
            label2.TabIndex = 4;
            label2.Text = "Libro";
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Font = new Font("Georgia", 10F);
            dtpFechaPrestamo.Location = new Point(266, 380);
            dtpFechaPrestamo.Margin = new Padding(4, 3, 4, 3);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(513, 30);
            dtpFechaPrestamo.TabIndex = 6;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Font = new Font("Georgia", 10F);
            dtpFechaDevolucion.Location = new Point(266, 434);
            dtpFechaDevolucion.Margin = new Padding(4, 3, 4, 3);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(513, 30);
            dtpFechaDevolucion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10F);
            label4.Location = new Point(132, 385);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 24);
            label4.TabIndex = 8;
            label4.Text = "F. Prestamo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10F);
            label5.Location = new Point(115, 439);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(134, 24);
            label5.TabIndex = 9;
            label5.Text = "F. Devolucion";
            // 
            // btnSolicitar
            // 
            btnSolicitar.BackColor = Color.Plum;
            btnSolicitar.FlatAppearance.BorderSize = 0;
            btnSolicitar.FlatStyle = FlatStyle.Flat;
            btnSolicitar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnSolicitar.ForeColor = Color.White;
            btnSolicitar.Location = new Point(61, 490);
            btnSolicitar.Margin = new Padding(4, 3, 4, 3);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(224, 54);
            btnSolicitar.TabIndex = 10;
            btnSolicitar.Text = "Solicitar";
            btnSolicitar.UseVisualStyleBackColor = false;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // btnAutorizar
            // 
            btnAutorizar.Location = new Point(0, 0);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(75, 23);
            btnAutorizar.TabIndex = 14;
            // 
            // btnRegistrarDevolucion
            // 
            btnRegistrarDevolucion.BackColor = Color.HotPink;
            btnRegistrarDevolucion.FlatAppearance.BorderSize = 0;
            btnRegistrarDevolucion.FlatStyle = FlatStyle.Flat;
            btnRegistrarDevolucion.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnRegistrarDevolucion.ForeColor = Color.White;
            btnRegistrarDevolucion.Location = new Point(537, 490);
            btnRegistrarDevolucion.Margin = new Padding(4, 3, 4, 3);
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Size = new Size(246, 54);
            btnRegistrarDevolucion.TabIndex = 12;
            btnRegistrarDevolucion.Text = "Registrar devolución";
            btnRegistrarDevolucion.UseVisualStyleBackColor = false;
            btnRegistrarDevolucion.Click += btnRegistrarDevolucion_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.RosyBrown;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(61, 569);
            btnLimpiar.Margin = new Padding(4, 3, 4, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(725, 54);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(175, 348);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(81, 24);
            lblUsuario.TabIndex = 15;
            lblUsuario.Text = "Usuario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(266, 345);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(512, 30);
            textBox1.TabIndex = 16;
            // 
            // AutorizarBtn
            // 
            AutorizarBtn.BackColor = Color.FromArgb(255, 128, 128);
            AutorizarBtn.ForeColor = SystemColors.ButtonHighlight;
            AutorizarBtn.Location = new Point(323, 490);
            AutorizarBtn.Name = "AutorizarBtn";
            AutorizarBtn.Size = new Size(186, 54);
            AutorizarBtn.TabIndex = 17;
            AutorizarBtn.Text = "Autorizar";
            AutorizarBtn.UseVisualStyleBackColor = false;
            // 
            // Prestamos
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(841, 705);
            Controls.Add(AutorizarBtn);
            Controls.Add(textBox1);
            Controls.Add(lblUsuario);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrarDevolucion);
            Controls.Add(btnAutorizar);
            Controls.Add(btnSolicitar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpFechaDevolucion);
            Controls.Add(dtpFechaPrestamo);
            Controls.Add(label2);
            Controls.Add(cboLibro);
            Controls.Add(dgvPrestamos);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Georgia", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MinimizeBox = false;
            Name = "Prestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prestamos";
            Load += Prestamos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvPrestamos;
        private ComboBox cboLibro;
        //private ComboBox cboUsuario;
        private Label label2;
        private DateTimePicker dtpFechaPrestamo;
        private DateTimePicker dtpFechaDevolucion;
        private Label label4;
        private Label label5;
        private Button btnSolicitar;
        private Button btnAutorizar;
        private Button btnRegistrarDevolucion;
        private Button btnLimpiar;
        private Label lblUsuario;
        private TextBox textBox1;
        private Button AutorizarBtn;
    }
}