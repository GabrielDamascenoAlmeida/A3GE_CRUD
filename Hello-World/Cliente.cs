using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Form1 telalogin = new Form1();
            telalogin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Nome.Text == "" || Telefone.Text == "" || Endereco.Text == "" || Email.Text == "" || Idade.Text == "" || Cpf.Text== "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos");
            }
            else
            {
                Form1 telalogin = new Form1();
                telalogin.Show();
                this.Hide();
            }
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cpf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
