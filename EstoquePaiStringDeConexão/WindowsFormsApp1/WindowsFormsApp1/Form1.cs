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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public string conection = $"Data Source={Environment.MachineName};Initial Catalog=BancoEstoque;Integrated Security=True";
        

        BancoDeDados bD1 = new BancoDeDados();

        private void AlterarDados() 
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtém a linha de dados do DataGridView e armazena-a na variável
                DataRow linhaSelecionada = ((DataRowView)dataGridView1.SelectedRows[0].DataBoundItem).Row;
                // Faça algo com a linha selecionada, se necessário
                string codColuna = linhaSelecionada[0].ToString(), EstoqueAtual = linhaSelecionada[2].ToString();
                string descricaoColuna = linhaSelecionada[1].ToString(), EstoqueMínimo = linhaSelecionada[3].ToString();
                string EstoqueMaximo = linhaSelecionada[4].ToString(), ValorUnitario = linhaSelecionada[5].ToString();
                // Abre o novo formulário, para alterar linha
                alterar form = new alterar(codColuna, descricaoColuna, EstoqueAtual, EstoqueMínimo, EstoqueMaximo, ValorUnitario);
                form.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
            dataGridView1.DataSource =  bD1.ApareceTabela(conection);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bD1.ApareceTabela(conection);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            criar formCria = new criar();
            formCria.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlterarDados();
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                // Obtém a linha de dados do DataGridView e armazena-a na variável
                DataRow linhaSelecionada = ((DataRowView)dataGridView1.SelectedRows[0].DataBoundItem).Row;
                // Faça algo com a linha selecionada, se necessário
                string codColuna = linhaSelecionada[0].ToString();
                dataGridView1.DataSource = bD1.Deletar(codColuna, conection);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string searchTerm = txt_pesquisa.Text; // Obtém o termo de pesquisa da caixa de texto
            dataGridView1.DataSource = bD1.Pesquisar(searchTerm, conection);

        }
    }
}
