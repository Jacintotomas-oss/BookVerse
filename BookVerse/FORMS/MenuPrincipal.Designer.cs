namespace BookVerse.FORMS
{
    partial class MenuPrincipal
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
            btnAgregarLibro = new Button();
            btnAgregarAutor = new Button();
            label1 = new Label();
            btnVentaPrestamos = new Button();
            SuspendLayout();
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.Location = new Point(641, 31);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(95, 23);
            btnAgregarLibro.TabIndex = 21;
            btnAgregarLibro.Text = "Agregar libro";
            btnAgregarLibro.UseVisualStyleBackColor = true;
            btnAgregarLibro.Click += btnAgregarLibro_Click_2;
            // 
            // btnAgregarAutor
            // 
            btnAgregarAutor.Location = new Point(641, 67);
            btnAgregarAutor.Name = "btnAgregarAutor";
            btnAgregarAutor.Size = new Size(95, 23);
            btnAgregarAutor.TabIndex = 20;
            btnAgregarAutor.Text = "Agregar Autor";
            btnAgregarAutor.UseVisualStyleBackColor = true;
            btnAgregarAutor.Click += btnAgregarAutor_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(149, 39);
            label1.Name = "label1";
            label1.Size = new Size(352, 31);
            label1.TabIndex = 19;
            label1.Text = "Bienvenido a BookVerse";
            // 
            // btnVentaPrestamos
            // 
            btnVentaPrestamos.Location = new Point(641, 107);
            btnVentaPrestamos.Name = "btnVentaPrestamos";
            btnVentaPrestamos.Size = new Size(95, 23);
            btnVentaPrestamos.TabIndex = 22;
            btnVentaPrestamos.Text = "Registro";
            btnVentaPrestamos.UseVisualStyleBackColor = true;
            btnVentaPrestamos.Click += btnVentaPrestamos_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Linen;
            ClientSize = new Size(799, 449);
            Controls.Add(btnVentaPrestamos);
            Controls.Add(btnAgregarLibro);
            Controls.Add(btnAgregarAutor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarLibro;
        private Button btnAgregarAutor;
        private Label label1;
        private Button btnVentaPrestamos;
    }
}