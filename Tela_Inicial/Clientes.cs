using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaMiriam_TelaDeLogin.TelaInicial
{
    public class Clientes
    {
        public string CodigoCliente { get; set; }
        public DateTime Data { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public int Inscricao { get; set; }

        public Clientes() { }

        public Clientes(string codigoCliente, DateTime data, string razaoSocial, string cNPJ, string endereco, string bairro, string cidade, string uf, string telefone, string cpf, int inscricao)
        {
            CodigoCliente = codigoCliente;
            Data = data;
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            Endereco = endereco;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
            Telefone = telefone;
            Cpf = cpf;
            Inscricao = inscricao;
        }
    }
}
