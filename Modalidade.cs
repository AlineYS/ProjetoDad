﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDad
{
    class Modalidade
    {
        private string descricao;
        private float preco;
        private int qtde_alunos, qtde_aulas;

        public string Descricao { get => descricao; set => descricao = value; }
        public float Preco { get => preco; set => preco = value; }
        public int Qtde_alunos { get => qtde_alunos; set => qtde_alunos = value; }
        public int Qtde_aulas { get => qtde_aulas; set => qtde_aulas = value; }


        public Modalidade(string descricao, float preco, int qtde_alunos, int qtde_aulas)
        {
            this.descricao = descricao;
            this.Preco = preco;
            this.Qtde_alunos = qtde_alunos;
            this.Qtde_aulas = qtde_aulas;
        }

        public Modalidade(string descricao)
        {
            this.descricao = descricao;
        }

        public Modalidade()
        {

        }
        
        public bool cadastrarModalidade()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Modalidade (descricaoModalidade, precoModalidade, qtdeAlunos, qtdeAulas) values " + "('" + descricao + "'," + preco + "," + qtde_alunos + "," + qtde_aulas + ")", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }
    }
}