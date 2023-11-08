using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
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
        private byte[] ConverterFotoParaByteArray()
        {
            using (var stream = new System.IO.MemoryStream())
            {
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                //deslocamento de bytes em relação ao parâmetro original
                //redefine a posição do fluxo para a gravação
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] bArray = new byte[stream.Length];
                //Lê um bloco de bytes e grava os dados em um buffer (stream)
                stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                return bArray;
            }
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            byte[] foto = ConverterFotoParaByteArray();
            Aluno aluno = new Aluno(mtxtCpf.Text, txtNome.Text, txtEnder.Text, txtN.Text, txtBairro.Text, txtComple.Text, mtxtCep.Text, mtxtTele.Text, txtCidade.Text, txtEstado.Text, txtEmail.Text, foto);
            
            if (aluno.verificaCPF())
            {
                if (aluno.cadastrarAluno())
                    MessageBox.Show("Cadastrado realizado com Sucesso");
                else
                    MessageBox.Show("Erro no cadastro");
            }
            else
            {
                MessageBox.Show("CPF inválido");
            }
        }

        private void mtxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(mtxtCpf.Text); 
            if(e.KeyChar==13)
            {
                if(aluno.consultarAluno())
                {
                    MessageBox.Show("Aluno já cadastrado!");
                    txtNome.Enabled = false;
                    txtBairro.Enabled = false;
                    txtCidade.Enabled = false; 
                    txtEstado.Enabled = false;
                    txtEnder.Enabled = false;
                    txtComple.Enabled = false;
                    txtEmail.Enabled = false;
                    mtxtCep.Enabled = false;
                    mtxtTele.Enabled = false;
                    txtN.Enabled = false;
                }
                else
                {
                    txtNome.Focus();
                    txtNome.Enabled = true;
                    txtBairro.Enabled = true;
                    txtCidade.Enabled = true;
                    txtEstado.Enabled = true;
                    txtEnder.Enabled = true;
                    txtComple.Enabled = true;
                    txtEmail.Enabled = true;
                    mtxtCep.Enabled = true;
                    mtxtTele.Enabled = true;
                    txtN.Enabled = true;
                }
                DAO_Conexao.con.Close();
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            byte[] foto = ConverterFotoParaByteArray();
            Aluno aluno = new Aluno(mtxtCpf.Text, txtNome.Text, txtEnder.Text, txtN.Text, txtBairro.Text, txtComple.Text, mtxtCep.Text, mtxtTele.Text, txtCidade.Text, txtEstado.Text, txtEmail.Text, foto);

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

        private void button2_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(mtxtCpf.Text);
            
                if (aluno.consultarAluno())
                {
                    if (aluno.ativarAluno())
                    {
                        MessageBox.Show("Aluno Ativado");
                    }
                    else
                {
                    MessageBox.Show("Não foi possível ativar o Aluno");
                }
                }
            
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Abrir Foto";
            dialog.Filter = "JPG (*.jpg)|*.jpg" + "|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(dialog.OpenFile());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel carregar a foto: " + ex.Message);
                }//catch
            }//if
            dialog.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
