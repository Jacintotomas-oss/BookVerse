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
            dgvAutores = new DataGridView();
            txtNombre = new TextBox();
            txtPais = new TextBox();
            Nombre = new Label();
            label2 = new Label();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAutores).BeginInit();
            SuspendLayout();
            // 
            // dgvAutores
            // 
            dgvAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutores.Location = new Point(86, 39);
            dgvAutores.Name = "dgvAutores";
            dgvAutores.RowHeadersWidth = 62;
            dgvAutores.Size = new Size(447, 314);
            dgvAutores.TabIndex = 0;
            dgvAutores.CellContentClick += dgvAutores_CellContentClick;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(171, 400);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(362, 31);
            txtNombre.TabIndex = 1;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(171, 450);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(362, 31);
            txtPais.TabIndex = 2;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(86, 403);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(78, 25);
            Nombre.TabIndex = 3;
            Nombre.Text = "Nombre";
            Nombre.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 453);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 4;
            label2.Text = "País";
            label2.Click += label2_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(86, 515);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(121, 47);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(252, 515);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(121, 47);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(421, 515);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(121, 47);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += button1_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(86, 590);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(456, 47);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Autores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 692);
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
    }
}