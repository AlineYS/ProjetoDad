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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            Modalidade mod = new Modalidade();
            MySqlDataReader reader = mod.consultarModalidade(index + 1);
            while (reader.Read())
            {
                textBox1.Text = reader["precoModalidade"].ToString();
                textBox2.Text = reader["qtdeAlunos"].ToString();
                textBox3.Text = reader["qtdeAulas"].ToString();
            }
            DAO_Conexao.con.Close();
        }
    }
}
