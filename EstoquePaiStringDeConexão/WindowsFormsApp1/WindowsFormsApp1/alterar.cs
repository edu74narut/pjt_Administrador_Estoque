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
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class alterar : Form
    {
        public string txt, txt2, txt3, txt4, txt5, txt6;
        public alterar(string cod, string descricao, string EstoqueAtual, string EstoqueMinimo,string EstoqueMaximo, string ValorUnitario)
        {
            InitializeComponent();
            txt = cod.ToString(); txt3 = EstoqueAtual.ToString();
            txt2 = descricao.ToString(); txt4 = EstoqueMinimo.ToString();
            txt5 = EstoqueMaximo.ToString(); txt6 = ValorUnitario.ToString();
            CultureInfo cultura = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = cultura;
            CultureInfo.DefaultThreadCurrentUICulture = cultura;
        }
        
        public string conection = $"Data Source={Environment.MachineName};Initial Catalog=BancoEstoque;Integrated Security=True";

        private void alterar_Load(object sender, EventArgs e)
        {
            lbl_codigo.Text = txt;
            lbl_descricao.Text = txt2;
            txt_EstoqueAtual.Text = txt3;
            txt_EstoqueMinimo.Text = txt5;
            txt_EstoqueMaximo.Text = txt4;
            txt_ValorUnitario.Text = txt6;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int estoqueAtual, estoqueMaximo, estoqueMinimo; double valorUnitario;

            if (int.TryParse(txt_EstoqueAtual.Text, out estoqueAtual) && int.TryParse(txt_EstoqueMaximo.Text, out estoqueMaximo)
                && int.TryParse(txt_EstoqueMinimo.Text, out estoqueMinimo) && estoqueAtual > -1 && estoqueMaximo  > -1 && estoqueMinimo > -1)
            {
                if (double.TryParse(txt_ValorUnitario.Text, out valorUnitario) && valorUnitario > -1)
                {
                    if (Convert.ToInt32(txt_EstoqueMaximo.Text) <= Convert.ToInt32(txt_EstoqueMinimo.Text))
                    {
                        MessageBox.Show("O Estoque máximo deve ser maior que o estoque mínimo, tente novamente.");
                    }
                    else
                    {
                        string update = $"update TabelaItens set EstoqueAtual = {txt_EstoqueAtual.Text}, EstoqueMaximo = {txt_EstoqueMaximo.Text}, " +
                        $"EstoqueMinimo = {txt_EstoqueMinimo.Text}, ValorUnitario = {Convert.ToDouble(txt_ValorUnitario.Text)} where cod = {lbl_codigo.Text} ;";

                        using (SqlConnection con = new SqlConnection(conection))
                        {
                            con.Open();
                            SqlDataAdapter adapter = new SqlDataAdapter(update, con);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                        }
                    }
                }
                else
                    MessageBox.Show("O valor unitário deve ser um número positivo!");
            }
            else
                MessageBox.Show("Os valores em relação ao estoque devem ser números inteiros e não negativos!");
        }
    }
}
