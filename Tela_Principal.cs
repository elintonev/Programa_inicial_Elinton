using AulaMiriam_TelaDeLogin.TelaInicial;
using System;
using System.Threading;
using System.Windows.Forms;

namespace AulaMiriam_TelaDeLogin
{
    public partial class Tela_Principal : Form
    {
        Thread Nt;
        public Tela_Principal()
        {
            InitializeComponent();
        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {

            Nt = new Thread(novoForm);
            Nt.SetApartmentState(ApartmentState.MTA);
            Nt.Start();
        }
        public void novoForm() {
            Application.Run(new CadastroClientes());
        }
    }
}
