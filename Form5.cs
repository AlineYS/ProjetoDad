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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        

            



            
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String descricao = txtDescricao.Text;
            float preco = float.Parse(txtPreco.Text);
            int qtdeAluno = int.Parse(txtQtdeAluno.Text);
            int qtdeAulas = int.Parse(txtQtdeAula.Text);

            Modalidade modalidade = new Modalidade(descricao, preco, qtdeAluno, qtdeAulas);

            if (modalidade.confirmaModalidade(descricao))
            {
                MessageBox.Show("Modalidade já cadastrada");
            }
            else
            {
                if (modalidade.cadastrarModalidade())
                {
                    MessageBox.Show("Cadastrado realizado com Sucesso");
                }
                else
                    MessageBox.Show("Erro no cadastro");

                Modalidade modalidade1 = new Modalidade(descricao);
            }
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
