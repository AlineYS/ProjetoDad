using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDad
{
    internal class Turma
    {
        private string professor, dia_semana, hora;
        private int modalidade;

        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Modalidade { get => modalidade; set => modalidade = value; }

        public Turma (int modalidade, string professor, string dia_semana, string hora)
        {
            this.modalidade = modalidade;
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
        }

        public Turma (int modalidade)
        {
            this.modalidade = modalidade;
        }

        public Turma() { 
        }

        public Turma (int modalidade, string dia_semana)
        {
            this.modalidade = modalidade;
            this.dia_semana = dia_semana;
        }


        public bool cadastrarTurma()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Turma (professor, dia_semana, hora, modalidade) values " + "('" + professor + "','" + dia_semana + "','" + hora + "'," + modalidade + ")", DAO_Conexao.con);
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

        public bool excluirTurma(int modalidade, string dia_semana, string hora)
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("DELETE FROM Estudio_Turma WHERE modalidade = "+ modalidade +" and dia_semana = '"+dia_semana+"' and hora = '"+hora+"'", DAO_Conexao.con);
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

        public MySqlDataReader consultarTodasTurmas()
        {
            MySqlDataReader reader = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand select = new MySqlCommand("Select * from Estudio_Turma", DAO_Conexao.con);

                reader = select.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return reader;

        }
    }
}
