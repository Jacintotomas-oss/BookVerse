namespace BookVerse
{
    partial class Login
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            ingresar = new Button();
            button1 = new Button();
            checkBox1 = new CheckBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(141, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(307, 46);
            label1.TabIndex = 0;
            label1.Text = "Iniciar Sesion";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 192);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(130, 196);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(252, 266);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 31);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(112, 270);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 24);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            label3.Click += label3_Click;
            // 
            // ingresar
            // 
            ingresar.BackColor = Color.Teal;
            ingresar.FlatAppearance.BorderSize = 0;
            ingresar.FlatStyle = FlatStyle.Flat;
            ingresar.Font = new Font("Georgia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ingresar.ForeColor = Color.White;
            ingresar.Location = new Point(112, 411);
            ingresar.Margin = new Padding(4, 5, 4, 5);
            ingresar.Name = "ingresar";
            ingresar.Size = new Size(140, 67);
            ingresar.TabIndex = 5;
            ingresar.Text = "Ingresar";
            ingresar.UseVisualStyleBackColor = false;
            ingresar.Click += ingresar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Georgia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(306, 411);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(140, 67);
            button1.TabIndex = 6;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Georgia", 10F);
            checkBox1.Location = new Point(112, 343);
            checkBox1.Margin = new Padding(4, 5, 4, 5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(215, 28);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Mostrar Contraseña";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(588, 619);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(ingresar);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button ingresar;
        private Button button1;
        private CheckBox checkBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
