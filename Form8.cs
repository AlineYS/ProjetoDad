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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            Modalidade mod = new Modalidade();
            MySqlDataReader dr = mod.consultarTodasModalidade();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["descricaoModalidade"].ToString());

            }
            DAO_Conexao.con.Close();

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Modalidade modalidade = new Modalidade(comboBox1.Text);
            int id = comboBox1.SelectedIndex;
            MySqlDataReader rd = modalidade.consultarModalidade(id + 1);

            while (rd.Read())
            {
                {
                    textBox1.Text = (rd["precoModalidade"].ToString());
                    textBox2.Text = (rd["qtdeAlunos"].ToString());
                    textBox3.Text = (rd["qtdeAulas"].ToString());

                }
            }
            DAO_Conexao.con.Close();
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
