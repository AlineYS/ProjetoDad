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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoDad
{
    public partial class Form9 : Form
    {   
        public Form9()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            WindowState = FormWindowState.Maximized;

            Modalidade con_mod = new Modalidade();
            MySqlDataReader r = con_mod.consultarTodasModalidade();
            while (r.Read())
            {
                dataGridView1.Rows.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }
        int idEstudio = 0;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell selectedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            textBox1.Text = selectedCell.Value.ToString();
            string nome = textBox1.Text;
            Modalidade modalidade = new Modalidade(textBox1.Text);
            MySqlDataReader rd = modalidade.consultarModalidadeNome(nome);

            while (rd.Read())
            {
                {
                  idEstudio = int.Parse(rd["idEstudio_Modalidade"].ToString());  

                }
            }
            DAO_Conexao.con.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String professor = textBox2.Text;
            String dia_semana = textBox3.Text;
            String hora = maskedTextBox1.Text;
            int modalidade = idEstudio;

            Turma turma = new Turma(modalidade, professor, dia_semana, hora);

            if (turma.cadastrarTurma())
            {
                MessageBox.Show("Cadastrado realizado com Sucesso");
            }
            else
                MessageBox.Show("Erro no cadastro");

            Turma turma1 = new Turma(modalidade);
        }
    }
}
