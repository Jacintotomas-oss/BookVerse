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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            panelHeader = new Panel();
            btnAgregarAutor = new Button();
            btnAgregarLibro = new Button();
            btnVentaPrestamos = new Button();
            flowLayoutCatalogo = new FlowLayoutPanel();
            btnAgregarEditorial = new Button();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(31, 41, 55);
            panelHeader.Controls.Add(btnAgregarEditorial);
            panelHeader.Controls.Add(btnAgregarAutor);
            panelHeader.Controls.Add(btnAgregarLibro);
            panelHeader.Controls.Add(btnVentaPrestamos);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1344, 65);
            panelHeader.TabIndex = 0;
            // 
            // btnAgregarAutor
            // 
            btnAgregarAutor.BackColor = Color.FromArgb(55, 65, 81);
            btnAgregarAutor.Cursor = Cursors.Hand;
            btnAgregarAutor.FlatAppearance.BorderSize = 0;
            btnAgregarAutor.FlatStyle = FlatStyle.Flat;
            btnAgregarAutor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregarAutor.ForeColor = Color.White;
            btnAgregarAutor.Location = new Point(405, 12);
            btnAgregarAutor.Name = "btnAgregarAutor";
            btnAgregarAutor.Size = new Size(170, 40);
            btnAgregarAutor.TabIndex = 0;
            btnAgregarAutor.Text = "Agregar Autor";
            btnAgregarAutor.UseVisualStyleBackColor = false;
            btnAgregarAutor.Click += btnAgregarAutor_Click_1;
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.BackColor = Color.FromArgb(55, 65, 81);
            btnAgregarLibro.Cursor = Cursors.Hand;
            btnAgregarLibro.FlatAppearance.BorderSize = 0;
            btnAgregarLibro.FlatStyle = FlatStyle.Flat;
            btnAgregarLibro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregarLibro.ForeColor = Color.White;
            btnAgregarLibro.Location = new Point(595, 12);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(170, 40);
            btnAgregarLibro.TabIndex = 1;
            btnAgregarLibro.Text = "Agregar Libro";
            btnAgregarLibro.UseVisualStyleBackColor = false;
            btnAgregarLibro.Click += btnAgregarLibro_Click_2;
            // 
            // btnVentaPrestamos
            // 
            btnVentaPrestamos.BackColor = Color.FromArgb(55, 65, 81);
            btnVentaPrestamos.Cursor = Cursors.Hand;
            btnVentaPrestamos.FlatAppearance.BorderSize = 0;
            btnVentaPrestamos.FlatStyle = FlatStyle.Flat;
            btnVentaPrestamos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVentaPrestamos.ForeColor = Color.White;
            btnVentaPrestamos.Location = new Point(785, 12);
            btnVentaPrestamos.Name = "btnVentaPrestamos";
            btnVentaPrestamos.Size = new Size(170, 40);
            btnVentaPrestamos.TabIndex = 2;
            btnVentaPrestamos.Text = "Registro";
            btnVentaPrestamos.UseVisualStyleBackColor = false;
            btnVentaPrestamos.Click += btnVentaPrestamos_Click;
            // 
            // flowLayoutCatalogo
            // 
            flowLayoutCatalogo.AutoScroll = true;
            flowLayoutCatalogo.AutoScrollMargin = new Size(0, 60);
            flowLayoutCatalogo.BackColor = Color.FromArgb(17, 24, 39);
            flowLayoutCatalogo.Dock = DockStyle.Fill;
            flowLayoutCatalogo.Location = new Point(0, 65);
            flowLayoutCatalogo.Name = "flowLayoutCatalogo";
            flowLayoutCatalogo.Padding = new Padding(35, 25, 35, 60);
            flowLayoutCatalogo.Size = new Size(1344, 684);
            flowLayoutCatalogo.TabIndex = 1;
            // 
            // btnAgregarEditorial
            // 
            btnAgregarEditorial.BackColor = Color.FromArgb(55, 65, 81);
            btnAgregarEditorial.Cursor = Cursors.Hand;
            btnAgregarEditorial.FlatAppearance.BorderSize = 0;
            btnAgregarEditorial.FlatStyle = FlatStyle.Flat;
            btnAgregarEditorial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregarEditorial.ForeColor = Color.White;
            btnAgregarEditorial.Location = new Point(976, 12);
            btnAgregarEditorial.Name = "btnAgregarEditorial";
            btnAgregarEditorial.Size = new Size(170, 40);
            btnAgregarEditorial.TabIndex = 3;
            btnAgregarEditorial.Text = "Agregar Editorial";
            btnAgregarEditorial.UseVisualStyleBackColor = false;
            btnAgregarEditorial.Click += btnAgregarEditorial_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 24, 39);
            ClientSize = new Size(1344, 749);
            Controls.Add(flowLayoutCatalogo);
            Controls.Add(panelHeader);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            MinimumSize = new Size(1100, 700);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookVerse - Catálogo Digital";
            Load += Menu_Load;
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private FlowLayoutPanel flowLayoutCatalogo;
        private Button btnAgregarLibro;
        private Button btnAgregarAutor;
        private Button btnVentaPrestamos;
        private Button btnAgregarEditorial;
    }
}
