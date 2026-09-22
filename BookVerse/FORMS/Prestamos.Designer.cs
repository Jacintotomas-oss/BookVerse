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
            cboUsuario = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dtpFechaPrestamo = new DateTimePicker();
            dtpFechaDevolucion = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            btnSolicitar = new Button();
            btnAutorizar = new Button();
            btnRegistrarDevolucion = new Button();
            btnLimpiar = new Button();
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
            cboLibro.Location = new Point(266, 320);
            cboLibro.Margin = new Padding(4, 3, 4, 3);
            cboLibro.Name = "cboLibro";
            cboLibro.Size = new Size(513, 32);
            cboLibro.TabIndex = 2;
            // 
            // cboUsuario
            // 
            cboUsuario.FormattingEnabled = true;
            cboUsuario.Location = new Point(266, 370);
            cboUsuario.Margin = new Padding(4, 3, 4, 3);
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(513, 32);
            cboUsuario.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10F);
            label2.Location = new Point(191, 323);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 24);
            label2.TabIndex = 4;
            label2.Text = "Libro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10F);
            label3.Location = new Point(168, 373);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 24);
            label3.TabIndex = 5;
            label3.Text = "Usuario";
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Font = new Font("Georgia", 10F);
            dtpFechaPrestamo.Location = new Point(266, 428);
            dtpFechaPrestamo.Margin = new Padding(4, 3, 4, 3);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(513, 30);
            dtpFechaPrestamo.TabIndex = 6;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Font = new Font("Georgia", 10F);
            dtpFechaDevolucion.Location = new Point(266, 482);
            dtpFechaDevolucion.Margin = new Padding(4, 3, 4, 3);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(513, 30);
            dtpFechaDevolucion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10F);
            label4.Location = new Point(132, 433);
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
            label5.Location = new Point(115, 487);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(134, 24);
            label5.TabIndex = 9;
            label5.Text = "F. Devolucion";
            // 
            // btnSolicitar
            // 
            btnSolicitar.BackColor = Color.Teal;
            btnSolicitar.FlatAppearance.BorderSize = 0;
            btnSolicitar.FlatStyle = FlatStyle.Flat;
            btnSolicitar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnSolicitar.ForeColor = Color.White;
            btnSolicitar.Location = new Point(61, 548);
            btnSolicitar.Margin = new Padding(4, 3, 4, 3);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(224, 54);
            btnSolicitar.TabIndex = 10;
            btnSolicitar.Text = "Solicitar";
            btnSolicitar.UseVisualStyleBackColor = false;
            // 
            // btnAutorizar
            // 
            btnAutorizar.BackColor = Color.ForestGreen;
            btnAutorizar.FlatAppearance.BorderSize = 0;
            btnAutorizar.FlatStyle = FlatStyle.Flat;
            btnAutorizar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnAutorizar.ForeColor = Color.White;
            btnAutorizar.Location = new Point(298, 548);
            btnAutorizar.Margin = new Padding(4, 3, 4, 3);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(224, 54);
            btnAutorizar.TabIndex = 11;
            btnAutorizar.Text = "Autorizar";
            btnAutorizar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarDevolucion
            // 
            btnRegistrarDevolucion.BackColor = Color.Navy;
            btnRegistrarDevolucion.FlatAppearance.BorderSize = 0;
            btnRegistrarDevolucion.FlatStyle = FlatStyle.Flat;
            btnRegistrarDevolucion.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnRegistrarDevolucion.ForeColor = Color.White;
            btnRegistrarDevolucion.Location = new Point(537, 548);
            btnRegistrarDevolucion.Margin = new Padding(4, 3, 4, 3);
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Size = new Size(246, 54);
            btnRegistrarDevolucion.TabIndex = 12;
            btnRegistrarDevolucion.Text = "Registrar devolución";
            btnRegistrarDevolucion.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gray;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(61, 627);
            btnLimpiar.Margin = new Padding(4, 3, 4, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(725, 54);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Prestamos
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(841, 705);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrarDevolucion);
            Controls.Add(btnAutorizar);
            Controls.Add(btnSolicitar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpFechaDevolucion);
            Controls.Add(dtpFechaPrestamo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboUsuario);
            Controls.Add(cboLibro);
            Controls.Add(dgvPrestamos);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Georgia", 10F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Prestamos";
            Text = "Prestamos";
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvPrestamos;
        private ComboBox cboLibro;
        private ComboBox cboUsuario;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpFechaPrestamo;
        private DateTimePicker dtpFechaDevolucion;
        private Label label4;
        private Label label5;
        private Button btnSolicitar;
        private Button btnAutorizar;
        private Button btnRegistrarDevolucion;
        private Button btnLimpiar;
    }
}