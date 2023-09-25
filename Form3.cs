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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(mtxtCpf.Text, txtNome.Text, txtEnder.Text, txtN.Text, txtBairro.Text, txtComple.Text, mtxtCep.Text, mtxtTele.Text, txtCidade.Text, txtEstado.Text,  txtEmail.Text);

            if (aluno.cadastrarAluno())
                MessageBox.Show("Cadastrado realizado com Sucesso");
            else
                MessageBox.Show("Erro no cadastro");
        }

        private void mtxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(mtxtCpf.Text); 
            if(e.KeyChar==13)
            {
                if(aluno.consultarAluno())
                {
                    MessageBox.Show("Aluno já cadastrado!");
                }
                else
                {
                    txtNome.Focus();
                }
                DAO_Conexao.con.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(mtxtCpf.Text, txtNome.Text, txtEnder.Text, txtN.Text, txtBairro.Text, txtComple.Text, mtxtCep.Text, mtxtTele.Text, txtCidade.Text, txtEstado.Text, txtEmail.Text);

            if (aluno.consultarAluno())
            {
                if (aluno.atualizarAluno())
                {
                    MessageBox.Show("Dados atualizados com sucesso!");

                }
                else
                {
                    MessageBox.Show("Não é possível atualizar os dados desse aluno");
                }
            }
            else
            {
                MessageBox.Show("Não é possível atualizar um aluno que ainda não foi cadastrado");
            }
        }
    }
}
