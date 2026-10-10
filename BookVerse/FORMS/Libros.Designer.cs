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
            dataGridView1 = new DataGridView();
            pnlPortada = new Panel();
            btnSeleccionarPortada = new Button();
            txtTitulo = new TextBox();
            label1 = new Label();
            cboAutor = new ComboBox();
            label2 = new Label();
            cboEditorial = new ComboBox();
            cboCategoria = new ComboBox();
            cboSerie = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNumeroSerie = new TextBox();
            label6 = new Label();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnLeer = new Button();
            label8 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 71);
            dataGridView1.Margin = new Padding(5, 4, 5, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(867, 215);
            dataGridView1.TabIndex = 0;
            // 
            // pnlPortada
            // 
            pnlPortada.BackgroundImageLayout = ImageLayout.Zoom;
            pnlPortada.Location = new Point(72, 318);
            pnlPortada.Margin = new Padding(5, 4, 5, 4);
            pnlPortada.Name = "pnlPortada";
            pnlPortada.Size = new Size(177, 263);
            pnlPortada.TabIndex = 1;
            // 
            // btnSeleccionarPortada
            // 
            btnSeleccionarPortada.BackColor = Color.DarkGreen;
            btnSeleccionarPortada.FlatAppearance.BorderSize = 0;
            btnSeleccionarPortada.FlatStyle = FlatStyle.Flat;
            btnSeleccionarPortada.Font = new Font("Georgia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeleccionarPortada.ForeColor = Color.White;
            btnSeleccionarPortada.Location = new Point(47, 592);
            btnSeleccionarPortada.Margin = new Padding(5, 4, 5, 4);
            btnSeleccionarPortada.Name = "btnSeleccionarPortada";
            btnSeleccionarPortada.Size = new Size(227, 45);
            btnSeleccionarPortada.TabIndex = 0;
            btnSeleccionarPortada.Text = "Seleccionar Portada";
            btnSeleccionarPortada.UseVisualStyleBackColor = false;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(434, 318);
            txtTitulo.Margin = new Padding(5, 4, 5, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(479, 23);
            txtTitulo.TabIndex = 2;
            txtTitulo.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Georgia", 10F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(360, 321);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 3;
            label1.Text = "Titulo";
            // 
            // cboAutor
            // 
            cboAutor.FormattingEnabled = true;
            cboAutor.Location = new Point(434, 368);
            cboAutor.Margin = new Padding(5, 4, 5, 4);
            cboAutor.Name = "cboAutor";
            cboAutor.Size = new Size(479, 24);
            cboAutor.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Georgia", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(363, 371);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 5;
            label2.Text = "Autor";
            // 
            // cboEditorial
            // 
            cboEditorial.FormattingEnabled = true;
            cboEditorial.Location = new Point(434, 420);
            cboEditorial.Margin = new Padding(5, 4, 5, 4);
            cboEditorial.Name = "cboEditorial";
            cboEditorial.Size = new Size(479, 24);
            cboEditorial.TabIndex = 6;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(434, 481);
            cboCategoria.Margin = new Padding(5, 4, 5, 4);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(479, 24);
            cboCategoria.TabIndex = 7;
            // 
            // cboSerie
            // 
            cboSerie.FormattingEnabled = true;
            cboSerie.Location = new Point(434, 534);
            cboSerie.Margin = new Padding(5, 4, 5, 4);
            cboSerie.Name = "cboSerie";
            cboSerie.Size = new Size(479, 24);
            cboSerie.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Georgia", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(336, 423);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 9;
            label3.Text = "Editorial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Georgia", 10F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(329, 484);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 10;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Georgia", 10F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(369, 537);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(40, 17);
            label5.TabIndex = 11;
            label5.Text = "Serie";
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.Location = new Point(434, 589);
            txtNumeroSerie.Margin = new Padding(5, 4, 5, 4);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(479, 23);
            txtNumeroSerie.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Georgia", 10F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(344, 592);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 17);
            label6.TabIndex = 14;
            label6.Text = "N. Serie";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Teal;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(46, 716);
            btnAgregar.Margin = new Padding(5, 4, 5, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 60);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.ForestGreen;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(233, 716);
            btnActualizar.Margin = new Padding(5, 4, 5, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(150, 60);
            btnActualizar.TabIndex = 18;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(406, 716);
            btnEliminar.Margin = new Padding(5, 4, 5, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 60);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gray;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(593, 716);
            btnLimpiar.Margin = new Padding(5, 4, 5, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 60);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnLeer
            // 
            btnLeer.BackColor = Color.Teal;
            btnLeer.FlatAppearance.BorderSize = 0;
            btnLeer.FlatStyle = FlatStyle.Flat;
            btnLeer.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnLeer.ForeColor = Color.White;
            btnLeer.Location = new Point(770, 716);
            btnLeer.Margin = new Padding(5, 4, 5, 4);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(150, 60);
            btnLeer.TabIndex = 21;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.WhiteSmoke;
            label8.Font = new Font("Georgia", 20F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(402, 16);
            label8.Name = "label8";
            label8.Size = new Size(105, 31);
            label8.TabIndex = 22;
            label8.Text = "Libros";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(344, 630);
            label7.Name = "label7";
            label7.Size = new Size(46, 17);
            label7.TabIndex = 23;
            label7.Text = "label7";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(434, 630);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(479, 23);
            textBox1.TabIndex = 24;
            // 
            // Libros
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(968, 749);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(btnLeer);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(label6);
            Controls.Add(txtNumeroSerie);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cboSerie);
            Controls.Add(cboCategoria);
            Controls.Add(cboEditorial);
            Controls.Add(label2);
            Controls.Add(cboAutor);
            Controls.Add(label1);
            Controls.Add(txtTitulo);
            Controls.Add(btnSeleccionarPortada);
            Controls.Add(pnlPortada);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            DoubleBuffered = true;
            Font = new Font("Georgia", 10F);
            ForeColor = Color.Black;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Libros";
            Text = "Libros";
            Load += Libros_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel pnlPortada;
        private Button btnSeleccionarPortada;
        private TextBox txtTitulo;
        private Label label1;
        private ComboBox cboAutor;
        private Label label2;
        private ComboBox cboEditorial;
        private ComboBox cboCategoria;
        private ComboBox cboSerie;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNumeroSerie;
        private Label label6;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnLeer;
        private Label label8;
        private Label label7;
        private TextBox textBox1;
    }
}