namespace forms1
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
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            Usuariolab = new Label();
            senhalab = new Label();
            buttonlogar = new Button();
            labelResultado = new Label();
            TextBoxnsenha = new TextBox();
            TextBoxnU = new Label();
            TextBoxnovoUsuario = new Label();
            textBoxusuarioo = new TextBox();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(181, 125);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(100, 23);
            textBoxUsuario.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(181, 186);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(100, 23);
            textBoxSenha.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(607, 207);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(607, 125);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // Usuariolab
            // 
            Usuariolab.AutoSize = true;
            Usuariolab.Location = new Point(181, 107);
            Usuariolab.Name = "Usuariolab";
            Usuariolab.Size = new Size(46, 15);
            Usuariolab.TabIndex = 4;
            Usuariolab.Text = "usuario";
            // 
            // senhalab
            // 
            senhalab.AutoSize = true;
            senhalab.Location = new Point(181, 168);
            senhalab.Name = "senhalab";
            senhalab.Size = new Size(38, 15);
            senhalab.TabIndex = 5;
            senhalab.Text = "senha";
            senhalab.Click += senhalab_Click;
            // 
            // buttonlogar
            // 
            buttonlogar.Location = new Point(181, 252);
            buttonlogar.Name = "buttonlogar";
            buttonlogar.Size = new Size(75, 23);
            buttonlogar.TabIndex = 6;
            buttonlogar.Text = "Entrar";
            buttonlogar.UseVisualStyleBackColor = true;
            buttonlogar.Click += Logar_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(189, 347);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(38, 15);
            labelResultado.TabIndex = 7;
            labelResultado.Text = "label1";
            // 
            // TextBoxnsenha
            // 
            TextBoxnsenha.Location = new Point(366, 308);
            TextBoxnsenha.Name = "TextBoxnsenha";
            TextBoxnsenha.Size = new Size(100, 23);
            TextBoxnsenha.TabIndex = 8;
            // 
            // TextBoxnU
            // 
            TextBoxnU.AutoSize = true;
            TextBoxnU.Location = new Point(366, 290);
            TextBoxnU.Name = "TextBoxnU";
            TextBoxnU.Size = new Size(44, 15);
            TextBoxnU.TabIndex = 9;
            TextBoxnU.Text = "senhaa";
            // 
            // TextBoxnovoUsuario
            // 
            TextBoxnovoUsuario.AutoSize = true;
            TextBoxnovoUsuario.Location = new Point(366, 215);
            TextBoxnovoUsuario.Name = "TextBoxnovoUsuario";
            TextBoxnovoUsuario.Size = new Size(53, 15);
            TextBoxnovoUsuario.TabIndex = 10;
            TextBoxnovoUsuario.Text = "usuarioo";
            // 
            // textBoxusuarioo
            // 
            textBoxusuarioo.Location = new Point(366, 242);
            textBoxusuarioo.Name = "textBoxusuarioo";
            textBoxusuarioo.Size = new Size(100, 23);
            textBoxusuarioo.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxusuarioo);
            Controls.Add(TextBoxnovoUsuario);
            Controls.Add(TextBoxnU);
            Controls.Add(TextBoxnsenha);
            Controls.Add(labelResultado);
            Controls.Add(buttonlogar);
            Controls.Add(senhalab);
            Controls.Add(Usuariolab);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label Usuariolab;
        private Label senhalab;
        private Button buttonlogar;
        private Label labelResultado;
        private TextBox TextBoxnsenha;
        private Label TextBoxnU;
        private Label TextBoxnovoUsuario;
        private TextBox textBoxusuarioo;
    }
}
