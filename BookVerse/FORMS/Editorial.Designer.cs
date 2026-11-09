namespace BookVerse.FORMS
{
    partial class Editorial
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grpEditoriales = new GroupBox();
            btnLimpiar = new Button();
            btnBorrar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            txtPais = new TextBox();
            label3 = new Label();
            dgvEditoriales = new DataGridView();
            label1 = new Label();
            TxtEditorial = new TextBox();
            groupBox2 = new GroupBox();
            buttonAgregar = new Button();
            buttonActualizar = new Button();
            buttonLimpiar = new Button();
            dgvSeries = new DataGridView();
            TxtNombreSerie = new TextBox();
            LblNombreSerie = new Label();
            buttonBorrar = new Button();
            grpEditoriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeries).BeginInit();
            SuspendLayout();
            // 
            // grpEditoriales
            // 
            grpEditoriales.Controls.Add(btnLimpiar);
            grpEditoriales.Controls.Add(btnBorrar);
            grpEditoriales.Controls.Add(btnActualizar);
            grpEditoriales.Controls.Add(btnAgregar);
            grpEditoriales.Controls.Add(txtPais);
            grpEditoriales.Controls.Add(label3);
            grpEditoriales.Controls.Add(dgvEditoriales);
            grpEditoriales.Controls.Add(label1);
            grpEditoriales.Controls.Add(TxtEditorial);
            grpEditoriales.Location = new Point(12, 12);
            grpEditoriales.Name = "grpEditoriales";
            grpEditoriales.Size = new Size(839, 195);
            grpEditoriales.TabIndex = 0;
            grpEditoriales.TabStop = false;
            grpEditoriales.Text = "Editoriales";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(263, 149);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(117, 23);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(182, 149);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 14;
            btnBorrar.Text = "borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(101, 149);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(20, 149);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(120, 45);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(319, 23);
            txtPais.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 94);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 9;
            label3.Text = "Editorial ";
            // 
            // dgvEditoriales
            // 
            dgvEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditoriales.Location = new Point(456, 22);
            dgvEditoriales.Name = "dgvEditoriales";
            dgvEditoriales.Size = new Size(361, 150);
            dgvEditoriales.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 42);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 6;
            label1.Text = "Pais ";
            // 
            // TxtEditorial
            // 
            TxtEditorial.Location = new Point(120, 91);
            TxtEditorial.Name = "TxtEditorial";
            TxtEditorial.Size = new Size(319, 23);
            TxtEditorial.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonBorrar);
            groupBox2.Controls.Add(buttonAgregar);
            groupBox2.Controls.Add(buttonActualizar);
            groupBox2.Controls.Add(buttonLimpiar);
            groupBox2.Controls.Add(dgvSeries);
            groupBox2.Controls.Add(TxtNombreSerie);
            groupBox2.Controls.Add(LblNombreSerie);
            groupBox2.Location = new Point(12, 230);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(839, 164);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Series";
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(20, 100);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 6;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Location = new Point(101, 100);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(75, 23);
            buttonActualizar.TabIndex = 5;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(263, 100);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(117, 23);
            buttonLimpiar.TabIndex = 3;
            buttonLimpiar.Text = "Limpiar Campos";
            buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvSeries
            // 
            dgvSeries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeries.Location = new Point(456, 22);
            dgvSeries.Name = "dgvSeries";
            dgvSeries.Size = new Size(361, 128);
            dgvSeries.TabIndex = 2;
            // 
            // TxtNombreSerie
            // 
            TxtNombreSerie.Location = new Point(120, 45);
            TxtNombreSerie.Name = "TxtNombreSerie";
            TxtNombreSerie.Size = new Size(319, 23);
            TxtNombreSerie.TabIndex = 1;
            // 
            // LblNombreSerie
            // 
            LblNombreSerie.AutoSize = true;
            LblNombreSerie.Location = new Point(20, 45);
            LblNombreSerie.Name = "LblNombreSerie";
            LblNombreSerie.Size = new Size(94, 15);
            LblNombreSerie.TabIndex = 0;
            LblNombreSerie.Text = "Nombre de serie";
            // 
            // buttonBorrar
            // 
            buttonBorrar.Location = new Point(182, 100);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(75, 23);
            buttonBorrar.TabIndex = 7;
            buttonBorrar.Text = "borrar";
            buttonBorrar.UseVisualStyleBackColor = true;
            // 
            // Editorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(888, 406);
            Controls.Add(groupBox2);
            Controls.Add(grpEditoriales);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MinimizeBox = false;
            Name = "Editorial";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editorial";
            grpEditoriales.ResumeLayout(false);
            grpEditoriales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeries).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grpEditoriales;
        private Label label2;
        private Label label1;
        private TextBox TxtEditorial;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox TxtNombreSerie;
        private Label LblNombreSerie;
        private DataGridView dgvEditoriales;
        private DataGridView dgvSeries;
        private TextBox txtPais;
        private Label label3;
        private Button btnBorrar;
        private Button btnActualizar;
        private Button button2;
        private Button btnAgregar;
        private Button buttonAgregar;
        private Button buttonActualizar;
        private Button button6;
        private Button buttonLimpiar;
        private Button btnLimpiar;
        private Button buttonBorrar;
    }
}