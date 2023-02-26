using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Windows_Forms
{
    public class ConexaoSQL
    {
        private readonly SqlConnection _conexao;
        public string nome;
        public int pontuacao;
        public ConexaoSQL()
        {
            this._conexao = new SqlConnection(@"Server=DESKTOP-05IP2B2\SQLEXPRESS ;Database=Cadastro;User Id=sa;Password=Pardini2021!;");
        }

        public void InserirNome()
        {
            try
            {
                _conexao.Open();

                string sql = "INSERT INTO NomesJogo(Id, Nome) VALUES (@id, @nome)";

                using (SqlCommand cmd = new SqlCommand(sql, _conexao))
                {
                    Random numeroID = new Random();
                    numeroID.Next();
                    cmd.Parameters.Add(new SqlParameter("@id", numeroID.Next()));
                    cmd.Parameters.Add(new SqlParameter("@nome", nome));                   

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                _conexao.Close();
            }
        }
        

    


    }
}
