using System;
using System.Windows.Forms;
using AulaMiriam_TelaDeLogin.Modelo;
using System.Threading;

namespace AulaMiriam_TelaDeLogin
{
    public partial class Form1 : Form
    {
        Thread Nt;
        public Form1()
        {
            InitializeComponent();
            txt_Usuario.Focus();
            txt_Usuario.Text = "Administrador";
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            string Mensagem = "Tem certeza que deseja sair?";
            var a = MessageBox.Show(Mensagem, "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (a == DialogResult.Yes) {
                Application.Exit();
            }
        }
        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.Acessar(txt_Usuario.Text,txt_Senha.Text); //Consulta o método Acessar da classe Controle, enviando os parâmetros digitados pelo usuário
            if (controle.Mensagem.Equals(""))
            {
                if (controle.Tem)
                {
                    this.Close();
                    Nt = new Thread(novoForm);
                    Nt.SetApartmentState(ApartmentState.STA);
                    Nt.Start();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show(controle.Mensagem);
            }
        }
        private void novoForm() //--- ITEM 2 --- Método criado para chamar o novo Formulário 
        {
            Application.Run(new Tela_Principal()); // Chama a aplicação, instanciando o novo formulário
        }
    }
}
