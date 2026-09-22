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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autores));
            dgvAutores = new DataGridView();
            txtNombre = new TextBox();
            txtPais = new TextBox();
            Nombre = new Label();
            label2 = new Label();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAutores).BeginInit();
            SuspendLayout();
            // 
            // dgvAutores
            // 
            dgvAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutores.Location = new Point(76, 90);
            dgvAutores.Name = "dgvAutores";
            dgvAutores.RowHeadersWidth = 62;
            dgvAutores.Size = new Size(456, 314);
            dgvAutores.TabIndex = 0;
            dgvAutores.CellContentClick += dgvAutores_CellContentClick;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(161, 451);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(371, 31);
            txtNombre.TabIndex = 1;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(161, 501);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(371, 31);
            txtPais.TabIndex = 2;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(76, 454);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(78, 25);
            Nombre.TabIndex = 3;
            Nombre.Text = "Nombre";
            Nombre.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 504);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 4;
            label2.Text = "País";
            label2.Click += label2_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Teal;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(76, 566);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(121, 47);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.ForestGreen;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(241, 566);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(126, 47);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(411, 566);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(121, 47);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += button1_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gray;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(76, 641);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(456, 47);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 20F, FontStyle.Bold);
            label1.Location = new Point(213, 24);
            label1.Name = "label1";
            label1.Size = new Size(183, 46);
            label1.TabIndex = 9;
            label1.Text = "Autores";
            label1.Click += label1_Click_1;
            // 
            // Autores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(609, 733);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Controls.Add(txtPais);
            Controls.Add(txtNombre);
            Controls.Add(dgvAutores);
            Name = "Autores";
            Text = "Autores";
            ((System.ComponentModel.ISupportInitialize)dgvAutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAutores;
        private TextBox txtNombre;
        private TextBox txtPais;
        private Label Nombre;
        private Label label2;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label label1;
    }
}