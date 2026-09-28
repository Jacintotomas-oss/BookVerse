namespace BookVerse.FORMS
{
    public partial class Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar));
            label1 = new Label();
            checkEmpleado = new CheckBox();
            BtnSalir = new Button();
            ingresar = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            txtDui = new TextBox();
            DUI = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 20F, FontStyle.Bold);
            label1.Location = new Point(134, 25);
            label1.Name = "label1";
            label1.Size = new Size(146, 31);
            label1.TabIndex = 1;
            label1.Text = "Registrar";
            label1.Click += label1_Click;
            // 
            // checkEmpleado
            // 
            checkEmpleado.AutoSize = true;
            checkEmpleado.Font = new Font("Georgia", 10F);
            checkEmpleado.Location = new Point(111, 296);
            checkEmpleado.Name = "checkEmpleado";
            checkEmpleado.Size = new Size(172, 21);
            checkEmpleado.TabIndex = 14;
            checkEmpleado.Text = "Entrar como Empleado";
            checkEmpleado.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.Firebrick;
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Georgia", 10F, FontStyle.Bold);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Location = new Point(236, 336);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(125, 40);
            BtnSalir.TabIndex = 13;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            // 
            // ingresar
            // 
            ingresar.BackColor = Color.Teal;
            ingresar.FlatAppearance.BorderSize = 0;
            ingresar.FlatStyle = FlatStyle.Flat;
            ingresar.Font = new Font("Georgia", 10F, FontStyle.Bold);
            ingresar.ForeColor = Color.White;
            ingresar.Location = new Point(46, 336);
            ingresar.Name = "ingresar";
            ingresar.Size = new Size(125, 40);
            ingresar.TabIndex = 12;
            ingresar.Text = "Ingresar";
            ingresar.UseVisualStyleBackColor = false;
            ingresar.Click += ingresar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10F);
            label3.Location = new Point(90, 156);
            label3.Name = "label3";
            label3.Size = new Size(79, 17);
            label3.TabIndex = 11;
            label3.Text = "Contraseña";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 23);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10F);
            label2.Location = new Point(112, 127);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 9;
            label2.Text = "Usuario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 23);
            textBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10F);
            label4.Location = new Point(125, 215);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 16;
            label4.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(183, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 23);
            textBox3.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10F);
            label5.Location = new Point(111, 98);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 18;
            label5.Text = "Nombre";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(183, 213);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(204, 23);
            textBox5.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 10F);
            label6.Location = new Point(22, 187);
            label6.Name = "label6";
            label6.Size = new Size(147, 17);
            label6.TabIndex = 20;
            label6.Text = "Confirmar Contraseña";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(183, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(204, 23);
            textBox4.TabIndex = 19;
            // 
            // txtDui
            // 
            txtDui.Location = new Point(183, 267);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(203, 23);
            txtDui.TabIndex = 22;
            // 
            // DUI
            // 
            DUI.AutoSize = true;
            DUI.Location = new Point(183, 242);
            DUI.Name = "DUI";
            DUI.Size = new Size(45, 19);
            DUI.TabIndex = 23;
            DUI.Text = "DUI";
            DUI.UseVisualStyleBackColor = true;
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(419, 397);
            Controls.Add(DUI);
            Controls.Add(txtDui);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(checkEmpleado);
            Controls.Add(BtnSalir);
            Controls.Add(ingresar);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Registrar";
            Text = "Registrar";
            Load += Registrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkEmpleado;   
        private Button BtnSalir;
        private Button ingresar;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private TextBox txtDui;
        private CheckBox DUI;
    }
}