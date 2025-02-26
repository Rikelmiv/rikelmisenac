namespace login
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
            TextBoxEmail = new TextBox();
            textBoxSenha = new TextBox();
            button1entrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LabelResultado = new Label();
            SuspendLayout();
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(117, 137);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(259, 23);
            TextBoxEmail.TabIndex = 0;
            TextBoxEmail.TextChanged += textBox1_TextChanged;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(117, 194);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(259, 23);
            textBoxSenha.TabIndex = 1;
            // 
            // button1entrar
            // 
            button1entrar.Location = new Point(387, 166);
            button1entrar.Name = "button1entrar";
            button1entrar.Size = new Size(75, 23);
            button1entrar.TabIndex = 2;
            button1entrar.Text = "Acessar conta";
            button1entrar.UseVisualStyleBackColor = true;
            button1entrar.Click += button1entrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 140);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "E-mail";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 194);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 244);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 5;
            label3.Text = "Esqueci a senha";
            label3.Click += label3_Click;
            // 
            // LabelResultado
            // 
            LabelResultado.AutoSize = true;
            LabelResultado.Location = new Point(120, 299);
            LabelResultado.Name = "LabelResultado";
            LabelResultado.Size = new Size(38, 15);
            LabelResultado.TabIndex = 6;
            LabelResultado.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(743, 409);
            Controls.Add(LabelResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1entrar);
            Controls.Add(textBoxSenha);
            Controls.Add(TextBoxEmail);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxEmail;
        private TextBox textBoxSenha;
        private Button button1entrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LabelResultado;
    }
}
