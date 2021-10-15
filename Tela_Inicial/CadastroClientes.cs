using AulaMiriam_TelaDeLogin.CBD;
using AulaMiriam_TelaDeLogin.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Text;

namespace AulaMiriam_TelaDeLogin.TelaInicial
{
    public partial class CadastroClientes : Form
    {
        Conexao Con = new Conexao();
        LoginCDB LoginCDB = new LoginCDB();
        Clientes cadCliente;
        int inscricao;
        int Alterar = 0;
        public CadastroClientes()
        {
            Con.ConectarComOBanco();
            InitializeComponent();
        }


        //Método privado para Limpar os campos
        #region Limpar os Campos
        private void LimparCampos()
        {
            lbl_Sucesso.Visible = true;
            lbl_Sucesso.ForeColor = System.Drawing.Color.Green;
            lbl_Sucesso.Text = "Cadastrado com Sucesso";
            Application.DoEvents();
            System.Threading.Thread.Sleep(2000);
            lbl_Sucesso.Visible = false;
            txt_CodigoCliente.Text = string.Empty;
            txt_RazaoSocial.Text = string.Empty;
            mtb_CNPJ.Text = string.Empty;
            txt_Uf.Text = string.Empty;
            txt_Bairro.Text = string.Empty;
            txt_Endereco.Text = string.Empty;
            txt_Cidade.Text = string.Empty;
            mtb_Telefone.Text = string.Empty;
            mtb_CPF.Text = string.Empty;
            rbtn_PessoaFisica.Checked = false;
            rbtn_PessoaJuridica.Checked = false;
        }
        #endregion
        //Método para incluir os cadastros no banco de dados
        #region Incluir os cadastros no banco de dados
        private void InclusaoCadastros()
        {
            cadCliente = new Clientes(txt_CodigoCliente.Text, dtp_DataInclusao.Value, txt_RazaoSocial.Text, mtb_CNPJ.Text, txt_Endereco.Text, txt_Bairro.Text, txt_Cidade.Text, txt_Uf.Text, mtb_Telefone.Text, mtb_CPF.Text, inscricao);
            LoginCDB Cmd = new LoginCDB();
            Cmd.IncluirDadosCadastros(cadCliente);
            if (Cmd.Executa > 0)
            {
                LimparCampos();
            }
            else
            {
                lbl_Sucesso.Visible = true;
                lbl_Sucesso.ForeColor = System.Drawing.Color.Red;
                lbl_Sucesso.Text = "Falha ao cadastrar";
                Application.DoEvents();
                System.Threading.Thread.Sleep(3000);
                lbl_Sucesso.Visible = false;
            }
        }
        #endregion
        //Método para atualizar os dados cadastrais no banco de dados
        #region Atualizar os dados cadastrias no banco de dados
        private void AtualizarCadastro()
        {
            LoginCDB Cmd = new LoginCDB();
            cadCliente = new Clientes(txt_CodigoCliente.Text, dtp_DataInclusao.Value, txt_RazaoSocial.Text, mtb_CNPJ.Text, txt_Endereco.Text, txt_Bairro.Text, txt_Cidade.Text, txt_Uf.Text, mtb_Telefone.Text, mtb_CPF.Text, inscricao);
            Cmd.AtualizarCadastros(cadCliente);
            if (Cmd.Executa > 0)
            {
                LimparCampos();
            }
            else
            {
                lbl_Sucesso.Visible = true;
                lbl_Sucesso.ForeColor = System.Drawing.Color.Red;
                lbl_Sucesso.Text = "Falha ao atualizar dados";
                Application.DoEvents();
                System.Threading.Thread.Sleep(3000);
                lbl_Sucesso.Visible = false;
            }

        }
        #endregion
        //Método que desativa o RadioButton e o MaskedTextBox não selecionado
        #region Verificar os dados selecionados nos RadioButtons
        private void VerificarPessoaFouJ(object sender, EventArgs e)
        {
            if (rbtn_PessoaJuridica.Checked)
            {
                inscricao = 0;
                mtb_CNPJ.Enabled = true;
                mtb_CPF.Enabled = false;
                mtb_CPF.Text = string.Empty;
            }
            else if (rbtn_PessoaFisica.Checked)
            {
                inscricao = 1;
                mtb_CPF.Enabled = true;
                mtb_CNPJ.Enabled = false;
                mtb_CNPJ.Text = string.Empty;
            }
        }
        #endregion
        //Método que faz o preenchimento enquanto digita do TextBox com informações do Banco de Dados
        #region Método AutoComplete do TextBox
        public void Buscar()
        {
            try
            {
                SqlCommand Cmd = new SqlCommand();
                Conexao Conectar = new Conexao();
                Cmd.Connection = Conectar.ConectarComOBanco();
                if (Cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    Cmd.CommandText = "select razao_social from Clientes";
                    SqlDataReader dr = Cmd.ExecuteReader();
                    AutoCompleteStringCollection Auto = new AutoCompleteStringCollection();
                    while(dr.Read())
                    { 
                        Auto.Add(dr.GetString(0));
                    }
                    txt_Buscar.AutoCompleteCustomSource = Auto;
                }
                else
                {
                    Cmd.Connection.Open();
                    Cmd.CommandText = "select razao_social from Clientes";
                    SqlDataReader dr = Cmd.ExecuteReader();
                    AutoCompleteStringCollection Auto = new AutoCompleteStringCollection();
                    while (dr.Read())
                    {
                        Auto.Add(dr.GetString(0));
                    }
                    txt_Buscar.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txt_Buscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txt_Buscar.AutoCompleteCustomSource = Auto;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao conectar com banco de dados", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        public void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (Alterar != 1)
            {
                InclusaoCadastros();
            }
            else
            {
                AtualizarCadastro();
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_CodigoCliente.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txt_CodigoCliente.Enabled = false;
            dtp_DataInclusao.Text = dataGridView1.SelectedCells[1].Value.ToString();
            dtp_DataInclusao.Enabled = false;
            txt_RazaoSocial.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txt_RazaoSocial.Enabled = false;
            txt_Endereco.Text = dataGridView1.SelectedCells[4].Value.ToString();
            txt_Endereco.Enabled = false;
            txt_Bairro.Text = dataGridView1.SelectedCells[5].Value.ToString();
            txt_Bairro.Enabled = false;
            txt_Cidade.Text = dataGridView1.SelectedCells[6].Value.ToString();
            txt_Cidade.Enabled = false;
            txt_Uf.Text = dataGridView1.SelectedCells[7].Value.ToString();
            txt_Uf.Enabled = false;
            mtb_Telefone.Text = dataGridView1.SelectedCells[8].Value.ToString();
            mtb_Telefone.Enabled = false;
            if (dataGridView1.SelectedCells[10].Value.ToString() != null)
            {
                string aux = dataGridView1.SelectedCells[10].Value.ToString();
                if (aux == "0")
                {
                    rbtn_PessoaJuridica.Checked = true;
                    mtb_CNPJ.Text = dataGridView1.SelectedCells[3].Value.ToString();
                    mtb_CNPJ.Enabled = false;
                    rbtn_PessoaFisica.Checked = false;
                    mtb_CPF.Enabled = false;
                }
                else
                {
                    rbtn_PessoaFisica.Checked = true;
                    if (dataGridView1.SelectedCells[9].Value.ToString() == null)
                    {
                        mtb_CPF.Text = "11111111111";
                    }
                    else
                    {
                        mtb_CPF.Text = dataGridView1.SelectedCells[9].Value.ToString();
                    }
                    mtb_CPF.Enabled = false;
                    rbtn_PessoaJuridica.Checked = false;
                    mtb_CNPJ.Enabled = false;

                }
            }
        }
        private void btn_BuscarCadastros_Click(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aulas_CSharpDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter1.Fill(this.aulas_CSharpDataSet2.Clientes);
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Alterar = 1;
                txt_CodigoCliente.Text = dataGridView1.SelectedCells[0].Value.ToString();
                txt_CodigoCliente.Enabled = true;
                dtp_DataInclusao.Text = dataGridView1.SelectedCells[1].Value.ToString();
                dtp_DataInclusao.Enabled = true;
                txt_RazaoSocial.Text = dataGridView1.SelectedCells[2].Value.ToString();
                txt_RazaoSocial.Enabled = true;
                mtb_CNPJ.Text = dataGridView1.SelectedCells[3].Value.ToString();
                mtb_CNPJ.Enabled = true;
                txt_Endereco.Text = dataGridView1.SelectedCells[4].Value.ToString();
                txt_Endereco.Enabled = true;
                txt_Bairro.Text = dataGridView1.SelectedCells[5].Value.ToString();
                txt_Bairro.Enabled = true;
                txt_Cidade.Text = dataGridView1.SelectedCells[6].Value.ToString();
                txt_Cidade.Enabled = true;
                txt_Uf.Text = dataGridView1.SelectedCells[7].Value.ToString();
                txt_Uf.Enabled = true;
                mtb_Telefone.Text = dataGridView1.SelectedCells[8].Value.ToString();
                mtb_Telefone.Enabled = true;
                mtb_CPF.Text = dataGridView1.SelectedCells[9].Value.ToString();
                mtb_CPF.Enabled = true;
            }
            catch (SystemException)
            {
                MessageBox.Show("Não há dados para alterar!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CadastroClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aulas_CSharpDataSet2.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter1.Fill(this.aulas_CSharpDataSet2.Clientes);
            Buscar();
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

