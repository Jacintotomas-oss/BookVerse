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
            System.Windows.Forms.DataGridViewCellStyle headerStyleEditoriales = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyleEditoriales = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle headerStyleSeries = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyleSeries = new System.Windows.Forms.DataGridViewCellStyle();
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
            grpEditoriales.BackColor = System.Drawing.Color.Transparent;
            grpEditoriales.Controls.Add(btnLimpiar);
            grpEditoriales.Controls.Add(btnBorrar);
            grpEditoriales.Controls.Add(btnActualizar);
            grpEditoriales.Controls.Add(btnAgregar);
            grpEditoriales.Controls.Add(txtPais);
            grpEditoriales.Controls.Add(label3);
            grpEditoriales.Controls.Add(dgvEditoriales);
            grpEditoriales.Controls.Add(label1);
            grpEditoriales.Controls.Add(TxtEditorial);
            grpEditoriales.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            grpEditoriales.ForeColor = System.Drawing.Color.White;
            grpEditoriales.Location = new System.Drawing.Point(20, 15);
            grpEditoriales.Name = "grpEditoriales";
            grpEditoriales.Size = new System.Drawing.Size(848, 200);
            grpEditoriales.TabIndex = 0;
            grpEditoriales.TabStop = false;
            grpEditoriales.Text = "Editoriales";
            // 
            // label1 (País)
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.FromArgb(229, 231, 235);
            label1.Location = new System.Drawing.Point(20, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(36, 17);
            label1.TabIndex = 6;
            label1.Text = "País:";
            // 
            // txtPais
            // 
            txtPais.BackColor = System.Drawing.Color.FromArgb(31, 41, 55);
            txtPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPais.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtPais.ForeColor = System.Drawing.Color.White;
            txtPais.Location = new System.Drawing.Point(120, 41);
            txtPais.Name = "txtPais";
            txtPais.Size = new System.Drawing.Size(319, 25);
            txtPais.TabIndex = 10;
            // 
            // label3 (Editorial)
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.FromArgb(229, 231, 235);
            label3.Location = new System.Drawing.Point(20, 92);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 17);
            label3.TabIndex = 9;
            label3.Text = "Editorial:";
            // 
            // TxtEditorial
            // 
            TxtEditorial.BackColor = System.Drawing.Color.FromArgb(31, 41, 55);
            TxtEditorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TxtEditorial.Font = new System.Drawing.Font("Segoe UI", 10F);
            TxtEditorial.ForeColor = System.Drawing.Color.White;
            TxtEditorial.Location = new System.Drawing.Point(120, 89);
            TxtEditorial.Name = "TxtEditorial";
            TxtEditorial.Size = new System.Drawing.Size(319, 25);
            TxtEditorial.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnAgregar.ForeColor = System.Drawing.Color.White;
            btnAgregar.Location = new System.Drawing.Point(20, 144);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(90, 34);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnActualizar.ForeColor = System.Drawing.Color.White;
            btnActualizar.Location = new System.Drawing.Point(118, 144);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(100, 34);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBorrar.FlatAppearance.BorderSize = 0;
            btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBorrar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnBorrar.ForeColor = System.Drawing.Color.White;
            btnBorrar.Location = new System.Drawing.Point(226, 144);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new System.Drawing.Size(85, 34);
            btnBorrar.TabIndex = 14;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.Color.FromArgb(55, 65, 81);
            btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            btnLimpiar.ForeColor = System.Drawing.Color.White;
            btnLimpiar.Location = new System.Drawing.Point(319, 144);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(120, 34);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // dgvEditoriales
            // 
            dgvEditoriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvEditoriales.BackgroundColor = System.Drawing.Color.FromArgb(17, 24, 39);
            dgvEditoriales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvEditoriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditoriales.EnableHeadersVisualStyles = false;
            dgvEditoriales.GridColor = System.Drawing.Color.FromArgb(55, 65, 81);
            headerStyleEditoriales.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            headerStyleEditoriales.ForeColor = System.Drawing.Color.White;
            headerStyleEditoriales.SelectionBackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            headerStyleEditoriales.SelectionForeColor = System.Drawing.Color.White;
            headerStyleEditoriales.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dgvEditoriales.ColumnHeadersDefaultCellStyle = headerStyleEditoriales;
            cellStyleEditoriales.BackColor = System.Drawing.Color.FromArgb(31, 41, 55);
            cellStyleEditoriales.ForeColor = System.Drawing.Color.White;
            cellStyleEditoriales.SelectionBackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            cellStyleEditoriales.SelectionForeColor = System.Drawing.Color.White;
            cellStyleEditoriales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            dgvEditoriales.DefaultCellStyle = cellStyleEditoriales;
            dgvEditoriales.Location = new System.Drawing.Point(456, 26);
            dgvEditoriales.Name = "dgvEditoriales";
            dgvEditoriales.RowHeadersVisible = false;
            dgvEditoriales.Size = new System.Drawing.Size(372, 154);
            dgvEditoriales.TabIndex = 8;
            // 
            // groupBox2 (Series)
            // 
            groupBox2.BackColor = System.Drawing.Color.Transparent;
            groupBox2.Controls.Add(buttonBorrar);
            groupBox2.Controls.Add(buttonAgregar);
            groupBox2.Controls.Add(buttonActualizar);
            groupBox2.Controls.Add(buttonLimpiar);
            groupBox2.Controls.Add(dgvSeries);
            groupBox2.Controls.Add(TxtNombreSerie);
            groupBox2.Controls.Add(LblNombreSerie);
            groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            groupBox2.ForeColor = System.Drawing.Color.White;
            groupBox2.Location = new System.Drawing.Point(20, 230);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(848, 175);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Series";
            // 
            // LblNombreSerie
            // 
            LblNombreSerie.AutoSize = true;
            LblNombreSerie.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            LblNombreSerie.ForeColor = System.Drawing.Color.FromArgb(229, 231, 235);
            LblNombreSerie.Location = new System.Drawing.Point(20, 48);
            LblNombreSerie.Name = "LblNombreSerie";
            LblNombreSerie.Size = new System.Drawing.Size(113, 17);
            LblNombreSerie.TabIndex = 0;
            LblNombreSerie.Text = "Nombre de serie:";
            // 
            // TxtNombreSerie
            // 
            TxtNombreSerie.BackColor = System.Drawing.Color.FromArgb(31, 41, 55);
            TxtNombreSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TxtNombreSerie.Font = new System.Drawing.Font("Segoe UI", 10F);
            TxtNombreSerie.ForeColor = System.Drawing.Color.White;
            TxtNombreSerie.Location = new System.Drawing.Point(140, 45);
            TxtNombreSerie.Name = "TxtNombreSerie";
            TxtNombreSerie.Size = new System.Drawing.Size(299, 25);
            TxtNombreSerie.TabIndex = 1;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            buttonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonAgregar.FlatAppearance.BorderSize = 0;
            buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAgregar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            buttonAgregar.ForeColor = System.Drawing.Color.White;
            buttonAgregar.Location = new System.Drawing.Point(20, 118);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new System.Drawing.Size(90, 34);
            buttonAgregar.TabIndex = 6;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = false;
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            buttonActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonActualizar.FlatAppearance.BorderSize = 0;
            buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonActualizar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            buttonActualizar.ForeColor = System.Drawing.Color.White;
            buttonActualizar.Location = new System.Drawing.Point(118, 118);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new System.Drawing.Size(100, 34);
            buttonActualizar.TabIndex = 5;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = false;
            // 
            // buttonBorrar
            // 
            buttonBorrar.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            buttonBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonBorrar.FlatAppearance.BorderSize = 0;
            buttonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonBorrar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            buttonBorrar.ForeColor = System.Drawing.Color.White;
            buttonBorrar.Location = new System.Drawing.Point(226, 118);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new System.Drawing.Size(85, 34);
            buttonBorrar.TabIndex = 7;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = false;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = System.Drawing.Color.FromArgb(55, 65, 81);
            buttonLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonLimpiar.FlatAppearance.BorderSize = 0;
            buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            buttonLimpiar.ForeColor = System.Drawing.Color.White;
            buttonLimpiar.Location = new System.Drawing.Point(319, 118);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new System.Drawing.Size(120, 34);
            buttonLimpiar.TabIndex = 3;
            buttonLimpiar.Text = "Limpiar Campos";
            buttonLimpiar.UseVisualStyleBackColor = false;
            // 
            // dgvSeries
            // 
            dgvSeries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSeries.BackgroundColor = System.Drawing.Color.FromArgb(17, 24, 39);
            dgvSeries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeries.EnableHeadersVisualStyles = false;
            dgvSeries.GridColor = System.Drawing.Color.FromArgb(55, 65, 81);
            headerStyleSeries.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            headerStyleSeries.ForeColor = System.Drawing.Color.White;
            headerStyleSeries.SelectionBackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            headerStyleSeries.SelectionForeColor = System.Drawing.Color.White;
            headerStyleSeries.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dgvSeries.ColumnHeadersDefaultCellStyle = headerStyleSeries;
            cellStyleSeries.BackColor = System.Drawing.Color.FromArgb(31, 41, 55);
            cellStyleSeries.ForeColor = System.Drawing.Color.White;
            cellStyleSeries.SelectionBackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            cellStyleSeries.SelectionForeColor = System.Drawing.Color.White;
            cellStyleSeries.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            dgvSeries.DefaultCellStyle = cellStyleSeries;
            dgvSeries.Location = new System.Drawing.Point(456, 26);
            dgvSeries.Name = "dgvSeries";
            dgvSeries.RowHeadersVisible = false;
            dgvSeries.Size = new System.Drawing.Size(372, 132);
            dgvSeries.TabIndex = 2;
            // 
            // Editorial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 425);
            this.Controls.Add(groupBox2);
            this.Controls.Add(grpEditoriales);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Editorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookVerse - Gestión de Editoriales y Series";
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
