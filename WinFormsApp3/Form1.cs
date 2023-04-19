using WinFormsApp3.Modelo;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Controle controle = new Controle();
            controle.acessar(txtEmail.Text, txtSenha.Text);
            if (controle.tem)
            {
                MessageBox.Show("Logado com sucesso", "Entrando",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BemVindo bv = new BemVindo();
                bv.Show();
            }
            else {
                MessageBox.Show("Login não encontrado, verifique login e senha", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarSe cad = new CadastrarSe();
            cad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}