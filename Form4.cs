﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void mtxtCpfEx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(mtxtCpfEx.Text);
            if (e.KeyChar == 13)
            {
                if (aluno.consultarAluno()){
                    if (aluno.excluirAluno())
                    {
                        MessageBox.Show("Aluno Excluído");
                    }
                }
            }
        }

        private void mtxtCpfEx_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
