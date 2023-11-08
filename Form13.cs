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
    public partial class Form13 : Form
    {
        
        public Form13()
        {
            InitializeComponent();
            Modalidade mod = new Modalidade();
            MySqlDataReader dr = mod.consultarTodasModalidade();
            while (dr.Read())
            {   
                if (dr["ativa"].ToString() == 0.ToString())
                comboBox1.Items.Add(dr["descricaoModalidade"].ToString());

            }
            DAO_Conexao.con.Close();

        }
        int idTurma = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            int idModalidade = 0;
            string nome = comboBox1.Text;
            Turma turma = new Turma();
            Modalidade modalidade = new Modalidade(nome);
            MySqlDataReader rd = modalidade.consultarModalidadeNome(nome);

            while (rd.Read())
            {
                {
                    idModalidade = int.Parse(rd["idEstudio_Modalidade"].ToString());

                }
            }
            DAO_Conexao.con.Close();

            MySqlDataReader a = turma.consultarTodasTurmas();
            while (a.Read())
            {
                int Amodalidade = Convert.ToInt32(a["modalidade"]);
                if (Amodalidade == idModalidade)
                    comboBox2.Items.Add(a["dia_semana"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            int idModalidade = 0;
            string nome = comboBox1.Text;
            Modalidade modalidade = new Modalidade(nome);
            MySqlDataReader rd = modalidade.consultarModalidadeNome(nome);

            while (rd.Read())
            {
                {
                    idModalidade = int.Parse(rd["idEstudio_Modalidade"].ToString());

                }
            }
            DAO_Conexao.con.Close();

            string diaDaSemana = comboBox2.Text;
            Turma turma = new Turma();
            MySqlDataReader v = turma.consultarTodasTurmas();
            while (v.Read())
            {
                int Amodalidade = Convert.ToInt32(v["modalidade"]);
                if (diaDaSemana == v["dia_semana"].ToString() && Amodalidade == idModalidade)
                    comboBox3.Items.Add(v["hora"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {   

            int idModalidade = 0;
            String dia_semana = comboBox2.Text;
            String hora = comboBox3.Text;
            string nome = comboBox1.Text;
            Modalidade modalidade = new Modalidade(nome);
            MySqlDataReader rd = modalidade.consultarModalidadeNome(nome);


            while (rd.Read())
            {
                {
                    idModalidade = int.Parse(rd["idEstudio_Modalidade"].ToString());

                }
            }
            DAO_Conexao.con.Close();

            
            Turma turma = new Turma();
            MySqlDataReader a = turma.consultarTurma(idModalidade, dia_semana, hora);


            while (a.Read())
            {
                {
                    textBox1.Text = (a["professor"].ToString());
                    idTurma = int.Parse(a["idEstudio_Turma"].ToString());
                }
            }
            DAO_Conexao.con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            int idModalidade = 0;
            string nome = comboBox1.Text;
            Modalidade modalidade = new Modalidade(nome);
            MySqlDataReader rd = modalidade.consultarModalidadeNome(nome);


            while (rd.Read())
            {
                {
                    idModalidade = int.Parse(rd["idEstudio_Modalidade"].ToString());

                }
            }
            DAO_Conexao.con.Close();

            String dia_semana = comboBox2.Text;
            String hora = comboBox3.Text;
            String professor = textBox1.Text;
            Turma turma = new Turma();
            if (turma.atualizarTurma(professor, dia_semana, hora, idModalidade, idTurma))
            {
                MessageBox.Show("Atualizado com Sucesso");
            }
            else
                MessageBox.Show("Erro ao atualizar");
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }
    }
}
