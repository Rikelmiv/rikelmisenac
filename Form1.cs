namespace forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> listaUsuarios = new List<string>() { "Neymar.jr", "Pablo.Vitar", "Sukuna.Silva" };

        List<string> listaSenhas = new List<string>() { "bruna", "12345", "777" };


        private void Logar_Click(object sender, EventArgs e)

        {

            string usuarioBuscado = textBoxUsuario.Text;

            string senha = textBoxSenha.Text;

            int posicaoUsuarioEncontrado = -1;


            //MODOS DIFERENTES DE EXERCUTAR UM PROGRAMA COM DIFERENTES FORMULAS.

            /*

            if (usuarioBuscado == null || usuarioBuscado == "")

            {

                labelResultado.Text = "Usu�rio � obrigat�rio!";

                labelResultado.ForeColor = Color.Red;

            }

            else if (senha == null || senha == "")

            {

                labelResultado.Text = "Senha � obrigat�ria";

                labelResultado.ForeColor = Color.Red;

            }

            else if (usuarioBuscado == "andre.luiz" && senha == "1234")

            {

                labelResultado.Text = "Autenticado com Sucesso!";

                labelResultado.ForeColor = Color.Green; 

            }

            else

            {

                labelResultado.Text = "Usu�rio ou senha Incorreto";

                labelResultado.ForeColor = Color.Red;

            }

            */


            /*

            if (string.IsNullOrWhiteSpace(usuario))

            {

                _ = labelResultado.Text = "E-mail � obrigat�ria";

                labelResultado.ForeColor = Color.Red;

                return;

            }

            if (senha == null || senha == "")

            {

                _ = labelResultado.Text = "Senha � obrigat�ria";

                labelResultado.ForeColor = Color.Red;

            }

            else if (usuario == "andre.luiz" && senha == "1234")

            {

                labelResultado.Text = "Autenticado com Sucesso!";

                labelResultado.ForeColor = Color.Green;

            }

            else

            {

                labelResultado.Text = "Usu�rio ou senha Incorreto";

                labelResultado.ForeColor = Color.Red;

            }

            */


            if (usuarioBuscado == null || usuarioBuscado == "")

            {

                _ = labelResultado.Text = "E-mail � obrigat�ria";

                labelResultado.ForeColor = Color.Red;

                return;

            }

            if (senha == null || senha == "")

            {

                _ = labelResultado.Text = "Senha � obrigat�ria";

                labelResultado.ForeColor = Color.Red;

                return;

            }

            for (int i = 0; i < listaUsuarios.Count; i++)

            {

                if (usuarioBuscado == listaUsuarios[i])

                {

                    posicaoUsuarioEncontrado = i;

                }

            }

            //f (usuarioBuscado == listaUsuarios[posicaoUsuarioEncontrado] && senha == "1234")

            //N�O FUNCIONA, USUARIO AQUI � O PRINCIPAL POR TANTO "usuarioBuscado" ou "listaUsuarios" N�O � NECESSARIO

            //H� A NECESSIDADE DE MUDAR RESULTADO DE USUARIO PARA"!=" POIS ASSIM O PROGRAMA N�O APLICAR� UMA EXE��O EM MEIO A EXECU��O

            //E CASSO O USUARIO N�O SEJA ENCONTRADO, N�O HAVER� ERRO POR N�O SER ASSOCIADO A UM NUMERO INEXISTENTE NA LISTA QUE � "-1"

            if (posicaoUsuarioEncontrado != -1 && senha == listaSenhas[posicaoUsuarioEncontrado])

            {

                labelResultado.Text = "Autenticado com Sucesso!";

                labelResultado.ForeColor = Color.Green;

            }

            else

            {

                labelResultado.Text = "Usu�rio ou senha Incorreto";

                labelResultado.ForeColor = Color.Red;

            }



            /*

            if (usuario == string.Empty || senha == string.Empty)

            {

                labelResultado.Text = "E-mail e senha obrigat�rio(s)";

                labelResultado.ForeColor = Color.Red;

                return;

            }  

            if (usuario == "andre.luiz" && senha == "1234")

            {

                labelResultado.Text = "Autenticado com Sucesso!";

                labelResultado.ForeColor = Color.Green;

            }

            else

            {

                labelResultado.Text = "Usu�rio ou senha Incorreto";

                labelResultado.ForeColor = Color.Red;

            }

            */


        }

      
        private void senhalab_Click(object sender, EventArgs e)
        {

        }
    }
}
