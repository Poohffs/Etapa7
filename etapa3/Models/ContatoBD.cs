using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;

namespace etapa3.Models
{
    public static class ContatoBD
    {
         // Dados de conexão
        private static string dadosConexao = "Database=estapa4; Data Source=localhost; User Id=root;";

        public static void Incluir (Contato contato)
        {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            string query = "insert into contato (nome, email,mensagem) values(@nome,@email,@mensagem);";
            MySqlCommand comando = new MySqlCommand(query,conexao);
            comando.Parameters.AddWithValue("@nome",contato.nome);
            comando.Parameters.AddWithValue("@email",contato.email);
            comando.Parameters.AddWithValue("@mensagem",contato.mensagem);
        
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        
        public static List<Contato> Listar()
        {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            string query = "select * from contato;";
            MySqlCommand comando = new MySqlCommand(query,conexao);
            MySqlDataReader leitor = comando.ExecuteReader();
            List<Contato> lista = new List<Contato>();
            while (leitor.Read())
            {
              Contato contato = new Contato();
              if (!leitor.IsDBNull(leitor.GetOrdinal("id")))
              contato.id = leitor.GetInt32("id");

              if (!leitor.IsDBNull(leitor.GetOrdinal("nome")))
              contato.nome = leitor.GetString("nome");

              if (!leitor.IsDBNull(leitor.GetOrdinal("email")))
              contato.email = leitor.GetString("email");

              if (!leitor.IsDBNull(leitor.GetOrdinal("mensagem")))
              contato.mensagem = leitor.GetString("mensagem");

              
              lista.Add(contato);
            }
            conexao.Close();
            return lista;
        }

        
    }
}