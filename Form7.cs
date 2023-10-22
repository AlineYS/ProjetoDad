using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDad
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            Modalidade mod = new Modalidade();
            MySqlDataReader dr = mod.consultarTodasModalidade();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["descricaoModalidade"].ToString());

            }
            DAO_Conexao.con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            Modalidade mod = new Modalidade();
            MySqlDataReader reader = mod.consultarModalidade(index + 1);
            while (reader.Read())
            {
                txtPreco.Text = reader["precoModalidade"].ToString();
                txtAlunos.Text = reader["qtdeAlunos"].ToString();
                txtAulas.Text = reader["qtdeAulas"].ToString();
            }
            DAO_Conexao.con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            String descricao = comboBox1.Text;
            float preco = float.Parse(txtPreco.Text);
            int qtdeAluno = int.Parse(txtAlunos.Text);
            int qtdeAulas = int.Parse(txtAulas.Text);

            Modalidade modalidade = new Modalidade(descricao, preco, qtdeAluno, qtdeAulas);

            if (modalidade.atualizarModalidade(index + 1))
            {
                MessageBox.Show("Atualizado com Sucesso");
            }
            else
                MessageBox.Show("Erro ao atualizar");

            Modalidade modalidade1 = new Modalidade(descricao);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;
            int index = comboBox1.SelectedIndex;
            Modalidade mod = new Modalidade();
            MySqlDataReader reader = mod.consultarModalidade(index+1);
            while (reader.Read())
            {
                  a = int.Parse(reader["ativa"].ToString());
            }
            DAO_Conexao.con.Close();
            if (a == 1)
            {
                if (mod.ativarModalidade(index + 1))
                {
                    MessageBox.Show("Ativado com Sucesso");
                }
                else
                    MessageBox.Show("Erro na ativação");
            }
            else
            {
                MessageBox.Show("Modalidade já está ativa");
            }
           
        }

    }
}