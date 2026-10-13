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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1 = new Panel();
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
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(ingresar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(487, 507);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Georgia", 10F);
            checkBox1.Location = new Point(97, 296);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(182, 24);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Mostrar Contraseña";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Georgia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(248, 386);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(112, 53);
            button1.TabIndex = 14;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            // 
            // ingresar
            // 
            ingresar.BackColor = Color.Lime;
            ingresar.FlatAppearance.BorderSize = 0;
            ingresar.FlatStyle = FlatStyle.Flat;
            ingresar.Font = new Font("Georgia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ingresar.ForeColor = Color.White;
            ingresar.Location = new Point(97, 386);
            ingresar.Margin = new Padding(3, 4, 3, 4);
            ingresar.Name = "ingresar";
            ingresar.Size = new Size(112, 53);
            ingresar.TabIndex = 13;
            ingresar.Text = "Ingresar";
            ingresar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(97, 237);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 12;
            label3.Text = "Contraseña";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 234);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 27);
            textBox2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(112, 178);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 10;
            label2.Text = "Usuario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 174);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 27);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(121, 68);
            label1.Name = "label1";
            label1.Size = new Size(259, 39);
            label1.TabIndex = 8;
            label1.Text = "Iniciar Sesion";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(471, 495);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel1;
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
