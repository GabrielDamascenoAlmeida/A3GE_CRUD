using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hello_World
{
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Fornecedor_Load(object sender, EventArgs e)
        {
            CarregarDadosBanco();
        }

        private void CarregarDadosBanco() 
        {
            string conexao = "server=localhost;database=db_fornecedores;uid=root;pwd=etec";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
            conexaoMYSQL.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from tb_fornecedor", conexaoMYSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DgvFornecedor.DataSource = dt;


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIdFornecedor.Text != "");
            {
                try
                {
                    DateTime diasNascimento;
                    DateTime diadehoje;
                    diasNascimento = DateTime.Parse(txtIdFornecedor.Text);
                    diadehoje = System.DateTime.Today;

                    int AnoNascimento = DateTime.Parse(txtIdFornecedor.Text).Year;
                    int AnoAtual = System.DateTime.Now.Year;

                    int AnoIdade = AnoAtual - AnoNascimento;

                    if (diasNascimento.DayOfYear > diadehoje.DayOfYear) ;
                    {
                        AnoIdade = AnoIdade - 1;
                    }
                    if (AnoIdade <= 17)
                    {
                        MessageBox.Show("Você é menor de idade, não irá passar");
                    }
                    else
                    {
                        MessageBox.Show("Você é maior de idade. Pode passar");
                    }
                    int QtdeDiaVida = (diadehoje.DayOfYear - diasNascimento.DayOfYear);
                }
                catch
                {
                    MessageBox.Show("Data invalida");
                    txtIdFornecedor.Text = "";
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string conexao = "server=localhost;database=db_fornecedores;uid=root;pwd=etec";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
            conexaoMYSQL.Open();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCpfFornecedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
