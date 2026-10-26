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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
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
            panel1.Location = new Point(-10, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 764);
            panel1.TabIndex = 25;
            panel1.Paint += panel1_Paint;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gray;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(769, 674);
            btnLimpiar.Margin = new Padding(5, 4, 5, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 60);
            btnLimpiar.TabIndex = 43;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(521, 674);
            btnEliminar.Margin = new Padding(5, 4, 5, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 60);
            btnEliminar.TabIndex = 42;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.ForestGreen;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(288, 674);
            btnActualizar.Margin = new Padding(5, 4, 5, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(150, 60);
            btnActualizar.TabIndex = 41;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Teal;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(62, 673);
            btnAgregar.Margin = new Padding(5, 4, 5, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 60);
            btnAgregar.TabIndex = 40;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(449, 644);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(479, 23);
            txtDescripcion.TabIndex = 46;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.White;
            lblDescripcion.Location = new Point(344, 644);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(83, 17);
            lblDescripcion.TabIndex = 45;
            lblDescripcion.Text = "Descripción";
            lblDescripcion.Click += lblDescripcion_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Georgia", 10F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(359, 606);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 17);
            label6.TabIndex = 39;
            label6.Text = "N. Serie";
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.Location = new Point(449, 603);
            txtNumeroSerie.Margin = new Padding(5, 4, 5, 4);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(479, 23);
            txtNumeroSerie.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Georgia", 10F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(384, 551);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(40, 17);
            label5.TabIndex = 37;
            label5.Text = "Serie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Georgia", 10F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(344, 498);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 36;
            label4.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Georgia", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(351, 437);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 35;
            label3.Text = "Editorial";
            // 
            // cboSerie
            // 
            cboSerie.FormattingEnabled = true;
            cboSerie.Location = new Point(449, 548);
            cboSerie.Margin = new Padding(5, 4, 5, 4);
            cboSerie.Name = "cboSerie";
            cboSerie.Size = new Size(479, 24);
            cboSerie.TabIndex = 34;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(449, 495);
            cboCategoria.Margin = new Padding(5, 4, 5, 4);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(479, 24);
            cboCategoria.TabIndex = 33;
            // 
            // cboEditorial
            // 
            cboEditorial.FormattingEnabled = true;
            cboEditorial.Location = new Point(449, 434);
            cboEditorial.Margin = new Padding(5, 4, 5, 4);
            cboEditorial.Name = "cboEditorial";
            cboEditorial.Size = new Size(479, 24);
            cboEditorial.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Georgia", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(378, 385);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 31;
            label2.Text = "Autor";
            // 
            // cboAutor
            // 
            cboAutor.FormattingEnabled = true;
            cboAutor.Location = new Point(449, 382);
            cboAutor.Margin = new Padding(5, 4, 5, 4);
            cboAutor.Name = "cboAutor";
            cboAutor.Size = new Size(479, 24);
            cboAutor.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Georgia", 10F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(375, 335);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 29;
            label1.Text = "Titulo";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(449, 332);
            txtTitulo.Margin = new Padding(5, 4, 5, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(479, 23);
            txtTitulo.TabIndex = 28;
            // 
            // btnSeleccionarPortada
            // 
            btnSeleccionarPortada.BackColor = Color.DarkOrchid;
            btnSeleccionarPortada.FlatAppearance.BorderSize = 0;
            btnSeleccionarPortada.FlatStyle = FlatStyle.Flat;
            btnSeleccionarPortada.Font = new Font("Georgia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeleccionarPortada.ForeColor = Color.White;
            btnSeleccionarPortada.Location = new Point(62, 606);
            btnSeleccionarPortada.Margin = new Padding(5, 4, 5, 4);
            btnSeleccionarPortada.Name = "btnSeleccionarPortada";
            btnSeleccionarPortada.Size = new Size(227, 45);
            btnSeleccionarPortada.TabIndex = 25;
            btnSeleccionarPortada.Text = "Seleccionar Portada";
            btnSeleccionarPortada.UseVisualStyleBackColor = false;
            // 
            // pnlPortada
            // 
            pnlPortada.BackColor = Color.DarkGray;
            pnlPortada.BackgroundImageLayout = ImageLayout.Zoom;
            pnlPortada.Location = new Point(87, 332);
            pnlPortada.Margin = new Padding(5, 4, 5, 4);
            pnlPortada.Name = "pnlPortada";
            pnlPortada.Size = new Size(177, 263);
            pnlPortada.TabIndex = 27;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(61, 85);
            dgvLibros.Margin = new Padding(5, 4, 5, 4);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.Size = new Size(867, 215);
            dgvLibros.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.WhiteSmoke;
            label8.Font = new Font("Georgia", 20F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(417, 30);
            label8.Name = "label8";
            label8.Size = new Size(105, 31);
            label8.TabIndex = 44;
            label8.Text = "Libros";
            // 
            // Libros
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(968, 749);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Georgia", 10F);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MinimizeBox = false;
            Name = "Libros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Libros";
            Load += Libros_Load;
            Scroll += True;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}