using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace AulaMiriam_TelaDeLogin.CBD
{
    public class Conexao
    {
        SqlConnection Con = new SqlConnection();
        public Conexao() { //Construtor da Classe Conexao, que localiza o banco de dados no servidor\Instancia
            Con.ConnectionString = @"Data Source=DESKTOP-C89AJ0F\SQL2017;Initial Catalog=Aulas_CSharp;Integrated Security=True;User=sa;Password=_43690";
            
        }
        public SqlConnection ConectarComOBanco() { //Método para iniciar conexão com o banco de dados
            if (Con.State == System.Data.ConnectionState.Closed) {
                Con.Open();
            }
            return Con;
        
        }
        public void DesconectarComOBanco() { // Método para encerrar conexão com o banco de dados
            if (Con.State == System.Data.ConnectionState.Open)
            {
                Con.Close();
            }
        }

    }
}
