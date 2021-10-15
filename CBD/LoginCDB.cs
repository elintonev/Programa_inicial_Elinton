using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AulaMiriam_TelaDeLogin.TelaInicial;

namespace AulaMiriam_TelaDeLogin.CBD
{
    public class LoginCDB
    {
        public bool Tem = false;
        public int Executa;
        public string Mensagem = "";
        SqlCommand Cmd = new SqlCommand(); //Classe do System para usar comandos em SQL.
        Conexao Conectar = new Conexao();
        SqlDataReader dr; //Varável do tipo SQLDataReader, serve para armazenar o resultado de um Consulta.
        AutoCompleteStringCollection Lista = new AutoCompleteStringCollection();
        public bool VerificarSenha(string usuario, string senha)
        {
            Cmd.CommandText = "Select * from login Where usuario = @usuario AND senha = @senha"; //ComandoText serve para Executar uma linha de comando que seria executada no Studio
            Cmd.Parameters.AddWithValue("@usuario", usuario); //Parametros do Where no Select
            Cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                Cmd.Connection = Conectar.ConectarComOBanco(); //Verifica a conexão com o banco de dados, chamando o método Conectar da Classe Conexao
                dr = Cmd.ExecuteReader(); //Executa os CommandText e retorna o resultado da consulta para a Variável dr
                if (dr.HasRows)
                { //HasRows signifca "Tem Linhas", se o dr retornou com linhas de comando a variável booleana recebe um True
                    Tem = true;
                }

            }
            catch (SqlException)
            {

                this.Mensagem = "Falha ao conectar com o banco de dados!";
            }
            return Tem;
        }
        public void IncluirDadosCadastros(Clientes cli)
        {
            Cmd.CommandText = "INSERT INTO dbo.Clientes(codigocliente, data_inclusao, razao_social,cnpj,endereco,bairro,cidade,uf,telefone, cpf, inscricao) VALUES (@codigocliente, @data_inclusao, @razao_social,@cnpj,@endereco,@bairro,@cidade,@uf,@telefone, @cpf, @inscricao)";
            Cmd.Connection = Conectar.ConectarComOBanco();
            Cmd.Parameters.AddWithValue("@codigocliente", cli.CodigoCliente);
            Cmd.Parameters.AddWithValue("@data_inclusao", cli.Data);
            Cmd.Parameters.AddWithValue("@razao_social", cli.RazaoSocial);
            Cmd.Parameters.AddWithValue("@cnpj", cli.CNPJ);
            Cmd.Parameters.AddWithValue("@endereco", cli.Endereco);
            Cmd.Parameters.AddWithValue("@bairro", cli.Bairro);
            Cmd.Parameters.AddWithValue("@cidade", cli.Cidade);
            Cmd.Parameters.AddWithValue("@uf", cli.UF);
            Cmd.Parameters.AddWithValue("@telefone", cli.Telefone);
            Cmd.Parameters.AddWithValue("@cpf", cli.Cpf);
            Cmd.Parameters.AddWithValue("@inscricao", cli.Inscricao);
            try
            {
                if (Cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    Executa = Cmd.ExecuteNonQuery();
                    this.Mensagem = "";

                }
                else
                {
                    Cmd.Connection.Open();
                    Executa = Cmd.ExecuteNonQuery();
                    this.Mensagem = "";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Mensagem = ex.Message;
            }
        }
        public void AtualizarCadastros(Clientes cli)
        {
            Cmd.CommandText = "UPDATE dbo.Clientes SET data_inclusao = @data_inclusao, razao_social = @razao_social, cnpj = @cnpj, endereco = @endereco, bairro = @bairro, cidade = @cidade, uf = @uf, telefone = @telefone, cpf = @cpf, inscricao = @inscricao WHERE codigocliente = @codigocliente";
            Cmd.Connection = Conectar.ConectarComOBanco();
            Cmd.Parameters.AddWithValue("@codigocliente", cli.CodigoCliente);
            Cmd.Parameters.AddWithValue("@data_inclusao", cli.Data);
            Cmd.Parameters.AddWithValue("@razao_social", cli.RazaoSocial);
            Cmd.Parameters.AddWithValue("@cnpj", cli.CNPJ);
            Cmd.Parameters.AddWithValue("@endereco", cli.Endereco);
            Cmd.Parameters.AddWithValue("@bairro", cli.Bairro);
            Cmd.Parameters.AddWithValue("@cidade", cli.Cidade);
            Cmd.Parameters.AddWithValue("@uf", cli.UF);
            Cmd.Parameters.AddWithValue("@telefone", cli.Telefone);
            Cmd.Parameters.AddWithValue("@cpf", cli.Cpf);
            Cmd.Parameters.AddWithValue("@inscricao", cli.Inscricao);
            try
            {
                if (Cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    Executa = Cmd.ExecuteNonQuery();
                    this.Mensagem = "";
                }
                else
                {
                    Cmd.Connection.Open();
                    Executa = Cmd.ExecuteNonQuery();
                    this.Mensagem = "";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Mensagem = ex.Message;
            }
        }
    }
}
