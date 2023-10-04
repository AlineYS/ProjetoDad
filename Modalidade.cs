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

        public MySqlDataReader consultarTodasModalidade()
        {
            MySqlDataReader reader = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand select = new MySqlCommand("Select * from Estudio_Modalidade",DAO_Conexao.con);

                reader = select.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return reader;

        }
        public MySqlDataReader consultarModalidade(int id)
        {
            MySqlDataReader reader = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand select = new MySqlCommand("Select * from Estudio_Modalidade where idEstudio_Modalidade="+ id, DAO_Conexao.con);

                reader = select.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return reader;

        }

        public bool excluirModalidade(int id)
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Modalidade set ativa = 1 where idEstudio_Modalidade="+id, DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }

        public bool atualizarModalidade(int id)
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("update Estudio_Modalidade set descricaoModalidade='"+descricao+"', precoModalidade="+preco+ ", qtdeAlunos="+qtde_alunos+ ", qtdeAulas="+qtde_aulas+" where idEstudio_Modalidade=" + id, DAO_Conexao.con);
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

        public bool ativarModalidade(int id)
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand ativa = new MySqlCommand("update Estudio_Modalidade set ativa = 0 where idEstudio_Modalidade="+id, DAO_Conexao.con);
                ativa.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }
    }
}
