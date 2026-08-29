namespace BookVerse
{
    partial class Form1
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 36);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Iniciar Sesion";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(282, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 110);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(302, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 164);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            label3.Click += label3_Click;
            // 
            // ingresar
            // 
            ingresar.BackColor = Color.Lime;
            ingresar.Location = new Point(229, 243);
            ingresar.Name = "ingresar";
            ingresar.Size = new Size(98, 40);
            ingresar.TabIndex = 5;
            ingresar.Text = "Ingresar";
            ingresar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(462, 243);
            button1.Name = "button1";
            button1.Size = new Size(98, 40);
            button1.TabIndex = 6;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(ingresar);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
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
    }
}
