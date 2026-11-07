namespace BookVerse.FORMS
{
    public partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1 = new Panel();
            lblSubtitulo = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            ingresar = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lblSubtitulo);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(ingresar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 481);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 10.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(156, 163, 175);
            lblSubtitulo.Location = new Point(52, 85);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(320, 25);
            lblSubtitulo.TabIndex = 16;
            lblSubtitulo.Text = "Iniciar Sesión";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Segoe UI", 9F);
            checkBox1.ForeColor = Color.FromArgb(209, 213, 219);
            checkBox1.Location = new Point(52, 260);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(128, 19);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Mostrar contraseña";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(55, 65, 81);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(52, 362);
            button1.Name = "button1";
            button1.Size = new Size(320, 38);
            button1.TabIndex = 14;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ingresar
            // 
            ingresar.BackColor = Color.FromArgb(37, 99, 235);
            ingresar.Cursor = Cursors.Hand;
            ingresar.FlatAppearance.BorderSize = 0;
            ingresar.FlatStyle = FlatStyle.Flat;
            ingresar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ingresar.ForeColor = Color.White;
            ingresar.Location = new Point(52, 305);
            ingresar.Name = "ingresar";
            ingresar.Size = new Size(320, 44);
            ingresar.TabIndex = 13;
            ingresar.Text = "Iniciar Sesión";
            ingresar.UseVisualStyleBackColor = false;
            ingresar.Click += ingresar_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(229, 231, 235);
            label3.Location = new Point(52, 195);
            label3.Name = "label3";
            label3.Size = new Size(320, 20);
            label3.TabIndex = 12;
            label3.Text = "Contraseña:";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(31, 41, 55);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 10.5F);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(52, 220);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(320, 26);
            textBox2.TabIndex = 11;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(229, 231, 235);
            label2.Location = new Point(52, 120);
            label2.Name = "label2";
            label2.Size = new Size(320, 20);
            label2.TabIndex = 10;
            label2.Text = "Usuario:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(31, 41, 55);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 10.5F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(52, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 26);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(52, 28);
            label1.Name = "label1";
            label1.Size = new Size(320, 52);
            label1.TabIndex = 8;
            label1.Text = "BookVerse";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Login
            // 
            AcceptButton = ingresar;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(17, 24, 39);
            ClientSize = new Size(424, 481);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(440, 520);
            MinimizeBox = false;
            MinimumSize = new Size(440, 520);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookVerse - Iniciar Sesión";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel1;
        private Label lblSubtitulo;
        private CheckBox checkBox1;
        private Button button1;
        private Button ingresar;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}
