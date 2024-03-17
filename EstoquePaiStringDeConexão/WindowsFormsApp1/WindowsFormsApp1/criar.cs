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


namespace WindowsFormsApp1
{
    public partial class criar : Form
    {
        public criar()
        {
            InitializeComponent();
        }
        public string conection = $"Data Source={Environment.MachineName};Initial Catalog=BancoEstoque;Integrated Security=True";
        private void criar_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conection))
            {
                connection.Open();
                string query = "SELECT COUNT(*) from TabelaItens";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int rowCount = (int)command.ExecuteScalar() + 1;
                    lbl_cod.Text = rowCount.ToString();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conection))
            {
                connection.Open();
                if (txt_descricao.Text == "" && txt_EstoqueAtual.Text == "" && txt_EstoqueMinimo.Text == "" 
                    && txt_EstoqueMaximo.Text == "" && txt_ValorUnitario.Text == "") 
                {
                    MessageBox.Show("Os valores não podem estar vazios, preencha os campos!", "Aviso!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string insert = $"insert INTO TabelaItens values({Convert.ToInt32(lbl_cod.Text)},'{txt_descricao.Text}',{Convert.ToInt32(txt_EstoqueAtual.Text)},{Convert.ToInt32(txt_EstoqueMinimo.Text)}" +
                    $",{Convert.ToInt32(txt_EstoqueMaximo.Text)},{Convert.ToDouble(txt_ValorUnitario.Text)}, NULL)";
                    SqlDataAdapter adapter = new SqlDataAdapter(insert, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
