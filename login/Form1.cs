namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1entrar_Click(object sender, EventArgs e)
        {
            string usuario = TextBoxEmail.Text;
            string senha = textBoxSenha.Text;

            if (usuario == null || usuario == "")
            {
                LabelResultado.Text = "Usuario é obrigatório!!!";
                LabelResultado.ForeColor = Color.Red;
                return;
            }

            if (usuario == "Rikelmi.Viana" && senha == "12345")
            {
                LabelResultado.Text = "Autenticado com sucesso";
                LabelResultado.ForeColor = Color.Green;
            }
            else
            {
                LabelResultado.Text = "Usuario ou senha incorretos";
                LabelResultado.ForeColor = Color.Red;
            }
        }
    }
}
