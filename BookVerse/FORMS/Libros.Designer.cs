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
            txtRutaPdf = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnSeleccionarPdf = new Button();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnLeer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(73, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(668, 179);
            dataGridView1.TabIndex = 0;
            // 
            // pnlPortada
            // 
            pnlPortada.BackgroundImageLayout = ImageLayout.Zoom;
            pnlPortada.Location = new Point(90, 239);
            pnlPortada.Name = "pnlPortada";
            pnlPortada.Size = new Size(118, 164);
            pnlPortada.TabIndex = 1;
            // 
            // btnSeleccionarPortada
            // 
            btnSeleccionarPortada.Location = new Point(73, 420);
            btnSeleccionarPortada.Name = "btnSeleccionarPortada";
            btnSeleccionarPortada.Size = new Size(155, 31);
            btnSeleccionarPortada.TabIndex = 0;
            btnSeleccionarPortada.Text = "Seleccionar Portada";
            btnSeleccionarPortada.UseVisualStyleBackColor = true;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(345, 239);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(304, 27);
            txtTitulo.TabIndex = 2;
            txtTitulo.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 242);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 3;
            label1.Text = "Titulo";
            // 
            // cboAutor
            // 
            cboAutor.FormattingEnabled = true;
            cboAutor.Location = new Point(345, 282);
            cboAutor.Name = "cboAutor";
            cboAutor.Size = new Size(304, 28);
            cboAutor.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 285);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Autor";
            // 
            // cboEditorial
            // 
            cboEditorial.FormattingEnabled = true;
            cboEditorial.Location = new Point(345, 325);
            cboEditorial.Name = "cboEditorial";
            cboEditorial.Size = new Size(304, 28);
            cboEditorial.TabIndex = 6;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(345, 375);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(304, 28);
            cboCategoria.TabIndex = 7;
            // 
            // cboSerie
            // 
            cboSerie.FormattingEnabled = true;
            cboSerie.Location = new Point(345, 420);
            cboSerie.Name = "cboSerie";
            cboSerie.Size = new Size(304, 28);
            cboSerie.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 328);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 9;
            label3.Text = "Editorial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 378);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 10;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 423);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 11;
            label5.Text = "Serie";
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.Location = new Point(345, 466);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(304, 27);
            txtNumeroSerie.TabIndex = 12;
            // 
            // txtRutaPdf
            // 
            txtRutaPdf.Location = new Point(345, 513);
            txtRutaPdf.Name = "txtRutaPdf";
            txtRutaPdf.Size = new Size(225, 27);
            txtRutaPdf.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(259, 473);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 14;
            label6.Text = "N. Serie";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(274, 520);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 15;
            label7.Text = "PDF";
            // 
            // btnSeleccionarPdf
            // 
            btnSeleccionarPdf.Location = new Point(590, 513);
            btnSeleccionarPdf.Name = "btnSeleccionarPdf";
            btnSeleccionarPdf.Size = new Size(59, 29);
            btnSeleccionarPdf.TabIndex = 16;
            btnSeleccionarPdf.Text = "Sel.";
            btnSeleccionarPdf.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(149, 569);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(269, 569);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 18;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(389, 569);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(511, 569);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(631, 569);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(94, 29);
            btnLeer.TabIndex = 21;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = true;
            // 
            // Libros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 670);
            Controls.Add(btnLeer);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(btnSeleccionarPdf);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtRutaPdf);
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
            Name = "Libros";
            Text = "Libros";
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
        private TextBox txtRutaPdf;
        private Label label6;
        private Label label7;
        private Button btnSeleccionarPdf;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnLeer;
    }
}