using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDad
{
    class Aluno
    {
        private string CPF;
        private string nome;
        private string rua;
        private string numero;
        private string bairro;
        private string complemento;
        private string CEP;
        private string telefone;
        private string cidade;
        private string estado;
        private string email;
        private byte[] foto;
        private bool Ativo;

        public void setCPF(string CPF)
        {
            this.CPF = CPF;
        }
        public string getCPF()
        {
            return this.CPF;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setRua(string rua)
        {
            this.rua = rua;
        }
        public string getRua()
        {
            return this.rua;
        }

        public void setNumero(string numero)
        {
            this.numero = numero;
        }
        public string getNumero()
        {
            return this.numero;
        }

        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }
        public string getBairro()
        {
            return this.bairro;
        }

        public void setComplemento(string complemento)
        {
            this.complemento = complemento;
        }
        public string getComplemento()
        {
            return this.complemento;
        }

        public void setCEP(string CEP)
        {
            this.CEP = CEP;
        }
        public string getCEP()
        {
            return this.CEP;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public string getTelefone()
        {
            return this.telefone;
        }

        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }
        public string getCidade()
        {
            return this.cidade;
        }

        public void setEstado(string estado)
        {
            this.estado = estado;
        }
        public string getEstado()
        {
            return this.estado;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return this.email;
        }

        public void setFoto(byte[] foto)
        {
            this.foto = foto;
        }
        public byte[] getFoto()
        {
            return this.foto;
        }

        public Aluno(string CPF, string nome, string rua, string numero, string bairro, string complemento, string CEP, string telefone, string cidade, string estado, string email, byte[] foto)
        {
            setCPF(CPF);
            setNome(nome);
            setRua(rua);
            setNumero(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCEP(CEP);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
            setFoto(foto);
        }

        public bool atualizarAluno()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                //Console.WriteLine("update Estudio_Aluno set nomeAluno = '" + nome + "', ruaAluno = '" + rua + "', numeroAluno = '" + numero + "', bairroAluno = '" + bairro + "' complementoAluno ='" + complemento + "',CEPAluno='" + CEP + "', cidadeAluno='" + cidade + "', estadoAluno='" + estado + "', telefoneAluno = '" + telefone + "', emailAluno = '" + email + "' where CPFAluno = '" + CPF + "'");
                MySqlCommand atualiza = new MySqlCommand("update Estudio_Aluno set nomeAluno = '" + nome + "', ruaAluno = '" + rua + "', numeroAluno = '" + numero + "', bairroAluno = '" + bairro + "', complementoAluno ='" + complemento + "',CEPAluno='" + CEP + "', telefoneAluno = '" + telefone + "', cidadeAluno='" + cidade + "', estadoAluno='" + estado + "', emailAluno = '" + email + "' where CPFAluno = '" + CPF + "', fotoAluno= '" + foto+"'", DAO_Conexao.con);
                atualiza.ExecuteNonQuery();
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
        }//atualizarAluno

        public bool cadastrarAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Aluno (CPFAluno, nomeAluno, ruaAluno, numeroAluno, bairroAluno, complementoAluno, CEPAluno, cidadeAluno, estadoAluno, telefoneAluno, emailAluno, fotoAluno) values " + "('" + CPF + "','" + nome + "','" + rua + "','" + numero + "','" + bairro + "','" + complemento + "','" + CEP + "','" + cidade + "','" + estado + "','" + telefone + "','" + email + "','"+ foto +"')", DAO_Conexao.con);
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

        public Aluno()
        {
        }

        public Aluno (string cpf)
        {
            setCPF(cpf); 
        }

        public MySqlDataReader consultarAlunoCpf()
        {
            MySqlDataReader reader = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand select = new MySqlCommand("Select * from Estudio_Aluno where CPFAluno='" + CPF + "'", DAO_Conexao.con);

                reader = select.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return reader;

        }

        public bool verificaCPF() //string CPF - sem parâmetro
        {
            int soma, resto, cont = 0;
            soma = 0;

            CPF = CPF.Trim();
            CPF = CPF.Replace(",", "");
            CPF = CPF.Replace("-", "");

            for (int i = 0; i < CPF.Length; i++)
            {
                int a = CPF[0] - '0';
                int b = CPF[i] - '0';

                if (a == b) cont++;
            }

            if (cont == 11) return false;

            for (int i = 1; i <= 9; i++) soma += int.Parse(CPF.Substring(i - 1, 1)) * (11 - i);

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11)) resto = 0;

            if (resto != int.Parse(CPF.Substring(9, 1))) return false;

            soma = 0;

            for (int i = 1; i <= 10; i++) soma += int.Parse(CPF.Substring(i - 1, 1)) * (12 - i);

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11)) resto = 0;

            if (resto != int.Parse(CPF.Substring(10, 1))) return false;

            return true;
        }
        public bool excluirAluno()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Aluno set ativo " + "= 1 where CPFAluno = '" + CPF + "'", DAO_Conexao.con);
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

        public bool ativarAluno()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Aluno set ativo " + "= 0 where CPFAluno = '" + CPF + "'", DAO_Conexao.con);
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

        public bool consultarAluno()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Aluno " + "WHERE CPFAluno='" + CPF + "'", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return existe;
            }

        public bool cadastrarAlunoTurma(String aluno, int turma)
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Aluno_Turma (aluno, turma) values " + "('" + aluno + "'," + turma + ")", DAO_Conexao.con);
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

        public MySqlDataReader consultarAlunoNaTurma(int turma)
        {
            MySqlDataReader reader = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand select = new MySqlCommand("Select * from Estudio_Aluno_Turma where turma=" + turma, DAO_Conexao.con);

                reader = select.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return reader;

        }

        public String consultarAlunoPorCPF(string cpf)
        {
            String nome = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand select = new MySqlCommand("Select nomeAluno from Estudio_Aluno where CPFAluno='"+ cpf+"'", DAO_Conexao.con);
                nome = select.ExecuteScalar().ToString();           
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
            finally { DAO_Conexao.con.Close();}
            return nome;
        }
        public bool excluirAlunoTurma(String aluno, int turma)
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("DELETE FROM Estudio_Aluno_Turma WHERE aluno='"+aluno+"' and turma= "+ turma, DAO_Conexao.con);
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

