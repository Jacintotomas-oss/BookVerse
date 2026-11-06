namespace BookVerse.FORMS
{
    partial class Autores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autores));
            panel1 = new Panel();
            label1 = new Label();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            label2 = new Label();
            Nombre = new Label();
            txtPais = new TextBox();
            txtNombre = new TextBox();
            dgvAutores = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAutores).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Nombre);
            panel1.Controls.Add(txtPais);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(dgvAutores);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 520);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // label1 (Título "Gestión de Autores")
            // 
            label1.AutoSize = false;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 18);
            label1.Name = "label1";
            label1.Size = new Size(300, 35);
            label1.TabIndex = 19;
            label1.Text = "Gestión de Autores";
            label1.Click += label1_Click_2;
            // 
            // dgvAutores
            // 
            dgvAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAutores.BackColor = Color.FromArgb(31, 41, 55);
            dgvAutores.BackgroundColor = Color.FromArgb(31, 41, 55);
            dgvAutores.BorderStyle = BorderStyle.None;
            dgvAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutores.EnableHeadersVisualStyles = false;
            dgvAutores.GridColor = Color.FromArgb(55, 65, 81);
            headerStyle.BackColor = Color.FromArgb(30, 41, 59);
            headerStyle.ForeColor = Color.White;
            headerStyle.SelectionBackColor = Color.FromArgb(30, 41, 59);
            headerStyle.SelectionForeColor = Color.White;
            headerStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvAutores.ColumnHeadersDefaultCellStyle = headerStyle;
            cellStyle.BackColor = Color.FromArgb(31, 41, 55);
            cellStyle.ForeColor = Color.White;
            cellStyle.SelectionBackColor = Color.FromArgb(37, 99, 235);
            cellStyle.SelectionForeColor = Color.White;
            cellStyle.Font = new Font("Segoe UI", 9F);
            dgvAutores.DefaultCellStyle = cellStyle;
            dgvAutores.Location = new Point(30, 60);
            dgvAutores.Name = "dgvAutores";
            dgvAutores.RowHeadersVisible = false;
            dgvAutores.Size = new Size(660, 210);
            dgvAutores.TabIndex = 10;
            // 
            // Nombre (Label Nombre del Autor - Columna Izquierda)
            // 
            Nombre.AutoSize = true;
            Nombre.BackColor = Color.Transparent;
            Nombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Nombre.ForeColor = Color.White;
            Nombre.Location = new Point(30, 290);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(115, 15);
            Nombre.TabIndex = 13;
            Nombre.Text = "Nombre del Autor:";
            Nombre.Click += Nombre_Click_1;
            // 
            // txtNombre (Columna Izquierda)
            // 
            txtNombre.Font = new Font("Segoe UI", 9.5F);
            txtNombre.Location = new Point(30, 315);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(315, 28);
            txtNombre.TabIndex = 11;
            // 
            // label2 (Label País de Origen - Columna Derecha)
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(375, 290);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 14;
            label2.Text = "País de Origen:";
            label2.Click += label2_Click_2;
            // 
            // txtPais (Columna Derecha)
            // 
            txtPais.Font = new Font("Segoe UI", 9.5F);
            txtPais.Location = new Point(375, 315);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(315, 28);
            txtPais.TabIndex = 12;
            // 
            // btnAgregar (Fila 1)
            // 
            btnAgregar.BackColor = Color.FromArgb(37, 99, 235);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(30, 365);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(205, 40);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnActualizar (Fila 1)
            // 
            btnActualizar.BackColor = Color.FromArgb(16, 185, 129);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(257, 365);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(205, 40);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // btnEliminar (Fila 1)
            // 
            btnEliminar.BackColor = Color.FromArgb(220, 38, 38);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(485, 365);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(205, 40);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnLimpiar (Fila 2)
            // 
            btnLimpiar.BackColor = Color.FromArgb(55, 65, 81);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(30, 420);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(660, 38);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // Autores
            // 
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.FromArgb(17, 24, 39);
            this.BackgroundImage = null;
            this.ClientSize = new Size(720, 520);
            this.Controls.Add(panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new Size(700, 500);
            this.Name = "Autores";
            this.Size = new Size(740, 560);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Gestión de Autores - BookVerse";
            this.Load += Autores_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAutores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private Label label2;
        private Label Nombre;
        private TextBox txtPais;
        private TextBox txtNombre;
        private DataGridView dgvAutores;
    }
}
