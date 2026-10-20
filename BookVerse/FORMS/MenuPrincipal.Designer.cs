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
            label1 = new Label();
            btnAgregarAutor = new Button();
            btnAgregarLibro = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 95);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(522, 46);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a BookVerse";
            label1.Click += label1_Click;
            // 
            // btnAgregarAutor
            // 
            btnAgregarAutor.Location = new Point(970, 157);
            btnAgregarAutor.Margin = new Padding(4, 5, 4, 5);
            btnAgregarAutor.Name = "btnAgregarAutor";
            btnAgregarAutor.Size = new Size(136, 38);
            btnAgregarAutor.TabIndex = 13;
            btnAgregarAutor.Text = "Agregar Autor";
            btnAgregarAutor.UseVisualStyleBackColor = true;
            btnAgregarAutor.Click += button1_Click;
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.Location = new Point(970, 108);
            btnAgregarLibro.Margin = new Padding(4, 5, 4, 5);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(136, 38);
            btnAgregarLibro.TabIndex = 14;
            btnAgregarLibro.Text = "Agregar libro";
            btnAgregarLibro.UseVisualStyleBackColor = true;
            btnAgregarLibro.Click += btnAgregarLibro_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Linen;
            ClientSize = new Size(1141, 820);
            Controls.Add(btnAgregarLibro);
            Controls.Add(btnAgregarAutor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MinimizeBox = false;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
       
        private Button btnAgregarAutor;
        private Button btnAgregarLibro;
    }
}