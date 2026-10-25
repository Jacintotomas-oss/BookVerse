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
            btnAgregarLibro = new Button();
            btnAgregarAutor = new Button();
            label1 = new Label();
            btnVentaPrestamos = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.Location = new Point(12, 71);
            btnAgregarLibro.Margin = new Padding(3, 4, 3, 4);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(109, 31);
            btnAgregarLibro.TabIndex = 21;
            btnAgregarLibro.Text = "Agregar libro";
            btnAgregarLibro.UseVisualStyleBackColor = true;
            btnAgregarLibro.Click += btnAgregarLibro_Click_2;
            // 
            // btnAgregarAutor
            // 
            btnAgregarAutor.Location = new Point(12, 110);
            btnAgregarAutor.Margin = new Padding(3, 4, 3, 4);
            btnAgregarAutor.Name = "btnAgregarAutor";
            btnAgregarAutor.Size = new Size(109, 31);
            btnAgregarAutor.TabIndex = 20;
            btnAgregarAutor.Text = "Agregar Autor";
            btnAgregarAutor.UseVisualStyleBackColor = true;
            btnAgregarAutor.Click += btnAgregarAutor_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(259, 24);
            label1.TabIndex = 19;
            label1.Text = "Bienvenido a BookVerse";
            // 
            // btnVentaPrestamos
            // 
            btnVentaPrestamos.Location = new Point(12, 149);
            btnVentaPrestamos.Margin = new Padding(3, 4, 3, 4);
            btnVentaPrestamos.Name = "btnVentaPrestamos";
            btnVentaPrestamos.Size = new Size(109, 31);
            btnVentaPrestamos.TabIndex = 22;
            btnVentaPrestamos.Text = "Registro";
            btnVentaPrestamos.UseVisualStyleBackColor = true;
            btnVentaPrestamos.Click += btnVentaPrestamos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-128, -43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1150, 657);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Linen;
            ClientSize = new Size(913, 599);
            Controls.Add(btnVentaPrestamos);
            Controls.Add(btnAgregarLibro);
            Controls.Add(btnAgregarAutor);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarLibro;
        private Button btnAgregarAutor;
        private Label label1;
        private Button btnVentaPrestamos;
        private PictureBox pictureBox1;
    }
}