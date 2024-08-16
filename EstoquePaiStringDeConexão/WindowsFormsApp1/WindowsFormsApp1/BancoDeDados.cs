using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace WindowsFormsApp1
{
    internal class BancoDeDados
    {
        public DataTable ApareceTabela(string conexao)
        {
            string SELECT = "update TabelaItens set ValorTotal = (ValorUnitario * EstoqueAtual);" +
                "SELECT cod, descricao as Descrição,\r\n    EstoqueAtual as [Estoque atual],\r\n    EstoqueMaximo as [Estoque máximo],\r\n    EstoqueMinimo as [Estoque mínimo],\r\n    ValorUnitario as [Valor unitário], ValorTotal as [Valor total],\r\n    CASE\r\n        WHEN EstoqueAtual > EstoqueMaximo THEN 'ACIMA'\r\n        WHEN EstoqueAtual >= EstoqueMinimo AND EstoqueAtual <= EstoqueMaximo THEN 'IDEAL'\r\n        WHEN EstoqueAtual < EstoqueMinimo THEN 'COMPRAR'\r\n    END AS [Status capacidade] \r\nFROM dbo.TabelaItens;";
            using (SqlConnection con = new SqlConnection(conexao))
            {
                try
                {
                    // Abrir conexão
                    con.Open();
                    // Criando adaptador para executar select no bdd
                    SqlDataAdapter adapter = new SqlDataAdapter(SELECT, con);
                    // Criando tabela de dados
                    DataTable dataTable = new DataTable();
                    // Preenchendo a tabela de dados com o select
                    adapter.Fill(dataTable);
                    // Passando a tabela para o dataGridView1
                    return dataTable;
                }
                catch
                {
                    Console.WriteLine("Algo deu errado");
                    return null;
                }
            }
        }
        public DataTable Deletar(string codColuna, string conexao)
        {
            string DELETE = $"delete from TabelaItens where cod = {codColuna}";
            using (SqlConnection con = new SqlConnection(conexao))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(DELETE, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable Pesquisar(string searchTerm, string conexao)
        {
            // Select que procura o termo
            string query = "SELECT cod, descricao as Descrição,\r\n    EstoqueAtual as [Estoque atual],\r\n    " +
                "EstoqueMaximo as [Estoque máximo],\r\n    EstoqueMinimo as [Estoque mínimo],\r\n    ValorUnitario as [Valor unitário], ValorTotal as " +
                "[Valor total],\r\n    CASE\r\n        WHEN EstoqueAtual > EstoqueMaximo THEN 'ACIMA'\r\n        WHEN EstoqueAtual >= EstoqueMinimo AND " +
                "EstoqueAtual <= EstoqueMaximo THEN 'IDEAL'\r\n        WHEN EstoqueAtual < EstoqueMinimo THEN 'COMPRAR'\r\n    END AS [Status capacidade] " +
                "\r\nFROM dbo.TabelaItens where descricao LIKE @searchTerm;";
            using (SqlConnection con = new SqlConnection(conexao))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%"); // Usamos % para pesquisa parcial
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }

        }
    }
}
