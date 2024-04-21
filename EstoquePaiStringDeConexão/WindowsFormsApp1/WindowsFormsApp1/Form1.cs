using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CultureInfo cultura = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = cultura;
            CultureInfo.DefaultThreadCurrentUICulture = cultura;
            
        }
        public string conection = $"Data Source={Environment.MachineName};Initial Catalog=BancoEstoque;Integrated Security=True";

        private void ApareceTabela(string conexao)
        {
            string SELECT = "update TabelaItens set ValorTotal = (ValorUnitario * EstoqueAtual);" +
                "SELECT cod, descricao as Descrição,\r\n    EstoqueAtual as [Estoque atual],\r\n    EstoqueMaximo as [Estoque máximo],\r\n    EstoqueMinimo as [Estoque mínimo],\r\n    ValorUnitario as [Valor unitário], ValorTotal as [Valor total],\r\n    CASE\r\n        WHEN EstoqueAtual > EstoqueMaximo THEN 'ACIMA'\r\n        WHEN EstoqueAtual >= EstoqueMinimo AND EstoqueAtual <= EstoqueMaximo THEN 'IDEAL'\r\n        WHEN EstoqueAtual < EstoqueMinimo THEN 'COMPRAR'\r\n    END AS [Status capacidade] \r\nFROM dbo.TabelaItens;";
            using (SqlConnection con = new SqlConnection(conexao))
            {
                try
                {
                    con.Open();
                    Console.WriteLine("Conexão Aberta");
                    SqlDataAdapter adapter = new SqlDataAdapter(SELECT, con);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                catch
                {
                    Console.WriteLine("Algo deu errado");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            ApareceTabela(conection);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApareceTabela(conection);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            criar formCria = new criar();
            formCria.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtém a linha de dados do DataGridView e armazena-a na variável
                DataRow linhaSelecionada = ((DataRowView)dataGridView1.SelectedRows[0].DataBoundItem).Row;
                // Faça algo com a linha selecionada, se necessário
                string codColuna = linhaSelecionada[0].ToString(), EstoqueAtual = linhaSelecionada[2].ToString();
                string descricaoColuna = linhaSelecionada[1].ToString(), EstoqueMínimo = linhaSelecionada[3].ToString();
                string EstoqueMaximo = linhaSelecionada[4].ToString(), ValorUnitario = linhaSelecionada[5].ToString();
                // Abre o novo formulário
                alterar form = new alterar(codColuna, descricaoColuna, EstoqueAtual, EstoqueMínimo, EstoqueMaximo, ValorUnitario);
                form.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtém a linha de dados do DataGridView e armazena-a na variável
                DataRow linhaSelecionada = ((DataRowView)dataGridView1.SelectedRows[0].DataBoundItem).Row;
                // Faça algo com a linha selecionada, se necessário
                string codColuna = linhaSelecionada[0].ToString();
                string DELETE = $"delete from TabelaItens where cod = {codColuna}";
                using (SqlConnection con = new SqlConnection(conection)) 
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(DELETE, con);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            /*string searchTerm = txt_pesquisa.Text; // Obtém o termo de pesquisa da caixa de texto
            string query = "SELECT cod, descricao as Descrição,\r\n    EstoqueAtual as [Estoque atual],\r\n    " +
                "EstoqueMaximo as [Estoque máximo],\r\n    EstoqueMinimo as [Estoque mínimo],\r\n    ValorUnitario as [Valor unitário], ValorTotal as " +
                "[Valor total],\r\n    CASE\r\n        WHEN EstoqueAtual > EstoqueMaximo THEN 'ACIMA'\r\n        WHEN EstoqueAtual >= EstoqueMinimo AND " +
                "EstoqueAtual <= EstoqueMaximo THEN 'IDEAL'\r\n        WHEN EstoqueAtual < EstoqueMinimo THEN 'COMPRAR'\r\n    END AS [Status capacidade] " +
                "\r\nFROM dbo.TabelaItens where descricao = @searchTerm;";
            Console.WriteLine(txt_pesquisa.Text);
            using (SqlConnection con = new SqlConnection(conection))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    Console.WriteLine(txt_pesquisa.Text);
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%"); // Usamos % para pesquisa parcia
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable; // Exibe os resultados na DataGridView
                }
            }*/

            string searchTerm = txt_pesquisa.Text; // Obtém o termo de pesquisa da caixa de texto
            string query = "SELECT cod, descricao as Descrição,\r\n    EstoqueAtual as [Estoque atual],\r\n    " +
                "EstoqueMaximo as [Estoque máximo],\r\n    EstoqueMinimo as [Estoque mínimo],\r\n    ValorUnitario as [Valor unitário], ValorTotal as " +
                "[Valor total],\r\n    CASE\r\n        WHEN EstoqueAtual > EstoqueMaximo THEN 'ACIMA'\r\n        WHEN EstoqueAtual >= EstoqueMinimo AND " +
                "EstoqueAtual <= EstoqueMaximo THEN 'IDEAL'\r\n        WHEN EstoqueAtual < EstoqueMinimo THEN 'COMPRAR'\r\n    END AS [Status capacidade] " +
                "\r\nFROM dbo.TabelaItens where descricao LIKE @searchTerm;";
            Console.WriteLine(txt_pesquisa.Text);
            using (SqlConnection con = new SqlConnection(conection))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    Console.WriteLine(txt_pesquisa.Text);
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%"); // Usamos % para pesquisa parcial
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable; // Exibe os resultados na DataGridView
                }
            }

        }
    }
}
