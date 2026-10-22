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
            panel1 = new Panel();
            btnAgregarLibro = new Button();
            btnAgregarAutor = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnAgregarAutor);
            panel1.Controls.Add(btnAgregarLibro);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-9, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 608);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.Location = new Point(759, 42);
            btnAgregarLibro.Margin = new Padding(3, 4, 3, 4);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(109, 31);
            btnAgregarLibro.TabIndex = 18;
            btnAgregarLibro.Text = "Agregar libro";
            btnAgregarLibro.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAutor
            // 
            btnAgregarAutor.Location = new Point(759, 90);
            btnAgregarAutor.Margin = new Padding(3, 4, 3, 4);
            btnAgregarAutor.Name = "btnAgregarAutor";
            btnAgregarAutor.Size = new Size(109, 31);
            btnAgregarAutor.TabIndex = 17;
            btnAgregarAutor.Text = "Agregar Autor";
            btnAgregarAutor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 53);
            label1.Name = "label1";
            label1.Size = new Size(443, 39);
            label1.TabIndex = 16;
            label1.Text = "Bienvenido a BookVerse";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Linen;
            ClientSize = new Size(913, 599);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAgregarAutor;
        private Button btnAgregarLibro;
        private Label label1;
    }
}