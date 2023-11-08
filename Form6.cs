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
    public partial class Form6 : Form
    {
        public Form6()
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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade();
            int id = 0;
            MySqlDataReader dr = mod.consultarTodasModalidade();
            while (dr.Read())
            {
                if (dr["descricaoModalidade"].ToString() == comboBox1.Text)
                {
                    id = int.Parse(dr["idEstudio_Modalidade"].ToString());
                }
            }
            DAO_Conexao.con.Close();

            Modalidade modalidade = new Modalidade(comboBox1.Text);
            Turma turma = new Turma();
            if (modalidade.excluirModalidade(id))
                    {
                        MessageBox.Show("Modalidade Excluída");
                        turma.excluirTurmaModalidade(id);
                       
                    }
            else
            {
                MessageBox.Show("Erro ao excluir");
            }                
            
        }
    }
}
