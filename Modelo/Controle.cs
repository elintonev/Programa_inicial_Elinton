using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaMiriam_TelaDeLogin.CBD;

namespace AulaMiriam_TelaDeLogin.Modelo
{
    public class Controle
    {
        public bool Tem; //Como o método retorna um Booleano, precisamos criar uma variável booleana para associar no retorno
        public string Mensagem = ""; //Variável que armazena a mensagem de erro
        LoginCDB Login = new LoginCDB(); //Instanciação da classe LoginCDB, para podermos usar seus construtores e métdos
        public bool Acessar(string usuario, string senha) {//Método que vai enviar o usuário e senha para a Classe LoginCDB verificar o usuário e senha
           Tem = Login.VerificarSenha(usuario, senha);// A variável Tem, recebe o Bool do método VerificarSenha da classe LoginCDB
            if (!Login.Mensagem.Equals("")) {
                this.Mensagem = Login.Mensagem;
            }
            return Tem;
        }
    }
}
