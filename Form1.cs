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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            menuStrip1.Enabled = false;

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202245", "cl202245", "cl*18122006"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de conexão");
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 cad_login = new Form2();
            cad_login.MdiParent = this;
            cad_login.Show();

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.login(textBox1.Text, textBox2.Text);
            if (tipo == 0)
                MessageBox.Show("Usuário/Senha inválidos");
            if (tipo == 1)
            {
                //MessageBox.Show("Usuário ADM");
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
            }
            if (tipo == 2)
            {
                //MessageBox.Show(Usuário Restrito);
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
                cadastrarAlunoToolStripMenuItem.Enabled = false;
            }
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.MdiParent = this;
            form4.Show();
        }

        

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.MdiParent = this;
            form5.Show(); 
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.MdiParent = this;
            form8.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.MdiParent = this;
            form6.Show();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.MdiParent = this;
            form7.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.MdiParent = this;
            form9.Show();
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.MdiParent = this;
            form10.Show();
        }
    }
}
