using Relatório.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatório.DAL
{
    public class PessoasDAL
    {
        private SqlConnection conexao;
        public string MensagemErro { get; set; }
        #region Construtor Padrão
        public PessoasDAL()
        {
            LeitorConfiguracao leitor = new LeitorConfiguracao();
            //Instanciar a conexão
            conexao = new SqlConnection();
            conexao.ConnectionString = leitor.LerConexao();
        }
        #endregion

        #region Inserir
        public bool Inserir(Pessoas pessoas)
        {
            bool sucesso = false;
            //Limpar mensagem de erro
            MensagemErro = "";

            //Declaração de comandos DML
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = @"INSERT INTO TB_PESSOAS (Nome, Email, Numero, Endereco, Cidade, Estado, Telefone, Sexo, CEP, Bairro, Complemento, DataNasc) VALUES (@nome, @email, @numero, @endereco, @cidade, @estado, @telefone, @sexo, @CEP, @bairro, @complemento, @datanasc)";

            //Criar os parâmetros de acesso aos dados
            cmd.Parameters.AddWithValue("@Nome", pessoas.Nome);
            cmd.Parameters.AddWithValue("@Email", pessoas.Email);
            cmd.Parameters.AddWithValue("@Numero", pessoas.Numero);
            cmd.Parameters.AddWithValue("@Endereco", pessoas.Endereco);
            cmd.Parameters.AddWithValue("@Cidade", pessoas.Cidade);
            cmd.Parameters.AddWithValue("@Estado", pessoas.Estado);
            cmd.Parameters.AddWithValue("@Telefone", pessoas.Telefone);
            cmd.Parameters.AddWithValue("@Sexo", pessoas.Sexo);
            cmd.Parameters.AddWithValue("@CEP", pessoas.CEP);
            cmd.Parameters.AddWithValue("@Bairro", pessoas.Bairro);
            cmd.Parameters.AddWithValue("@Complemento", pessoas.Complemento);
            cmd.Parameters.AddWithValue("@DataNasc", pessoas.DataNasc);
            //Executar o comando
            try
            {
                //Tente abrir a conexão 
                conexao.Open();

                //Executar o comando T-SQL e retorna o número de linhas afetadas
                cmd.ExecuteNonQuery();
                //Se chegou até aqui, então ta sussa
                sucesso = true;
            }
            catch (Exception ex)
            {
                //Se entrou aqui, então deu ruim
                MensagemErro = ex.Message;

            }
            finally
            {
                //Fecha a conexão com o SGBD
                conexao.Close();
            }
            return sucesso;
        }
        #endregion

        #region Listar
        public List<Pessoas> Listar()
        {
            //Instanciar a lista de pessoas
            List<Pessoas> listaPessoas = new List<Pessoas>();
            //Declarar o comando
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = @"SELECT * FROM TB_PESSOAS ORDED BY Codigo, Nome";

            //Executar o comando
            try
            {
                //Abrir conexão
                conexao.Open();
                //Executar o comando e receber o resultado
                //Costuma dar erro aqui
                SqlDataReader leitor = cmd.ExecuteReader();

                while(leitor.Read() == true)
                {
                    //Instanciar objetos
                    Pessoas pessoas = new Pessoas();
                    pessoas.Nome = leitor["Nome"].ToString();
                    pessoas.Email = leitor["Email"].ToString();
                    pessoas.Numero = Convert.ToInt32(leitor["Numero"]);
                    pessoas.Endereco = leitor["Etnia"].ToString();
                    pessoas.Codigo = Convert.ToInt32(leitor["Codigo"]);
                    pessoas.Cidade = leitor["Cidade"].ToString();
                    pessoas.Estado = leitor["Estado"].ToString();
                    pessoas.Telefone = leitor["Telefone"].ToString();
                    pessoas.Sexo = leitor["Sexo"].ToString();
                    pessoas.CEP = leitor["CEP"].ToString();
                    pessoas.Bairro = leitor["Bairro"].ToString();
                    pessoas.Complemento = leitor["Complemento"].ToString();
                    pessoas.DataNasc = leitor["DataNasc"].ToString();

                    //Adicionar os elementos da lista
                    listaPessoas.Add(pessoas);
                }
            }
            catch(Exception ex)
            {
                //Se entrou aqui, então deu erro
                MensagemErro = ex.Message;
            }
            finally
            {
                //Finalizar conexao
                conexao.Close();
            }
            return listaPessoas;
        }
        #endregion

        #region Consultar por Código
            public Pessoas ConsultarPorCodigo(int codigo)
            {
            Pessoas pessoas = null;

            //Limpar mensagem de erro
            MensagemErro = "";

            //Declaração de comandos DML
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = @"SELECT * FROM TB_PESSOAS WHERE Codigo = @codigo";

            //Criar os parâmetros 
            cmd.Parameters.AddWithValue("@Codigo", codigo);

            try
            {
                conexao.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.Read() == true)
                {
                    pessoas = new Pessoas();
                    pessoas.Codigo = Convert.ToInt32(leitor["Codigo"].ToString());
                    pessoas.Nome = leitor["Nome"].ToString();
                    pessoas.Email = leitor["Email"].ToString();
                    pessoas.CEP = leitor["CEP"].ToString();
                    pessoas.Telefone = leitor["Telefone"].ToString();
                    pessoas.Sexo = leitor["Sexo"].ToString();
                    pessoas.Endereco = leitor["Endereco"].ToString();
                    pessoas.Bairro = leitor["Bairro"].ToString();
                    pessoas.Numero = Convert.ToInt32(leitor["Numero"]);
                    pessoas.Estado = leitor["Estado"].ToString();
                    pessoas.Complemento = leitor["Complemento"].ToString();
                    pessoas.Cidade = leitor["Cidade"].ToString();
                }
            }
            catch (Exception ex)
            {
                //Se entrou aqui, então deu erro
                MensagemErro = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            return pessoas;
        }
        #endregion

        #region Alterar
        public bool Alterar(Pessoas pessoa)
        {
            bool sucesso = false;
            MensagemErro = "";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = @"UPDATE TB_PESSOAS SET Nome = @Nome, Email = @Email, Numero = @Numero, Endereco = @Endereco, Cidade = @Cidade, Estado = @Estado, Telefone = @Telefone, Sexo = @Sexo, CEP = @CEP, Bairro = @Bairro, Complemento = @Complemento, DataNasc = @DataNasc WHERE Codigo = @Codigo";

            cmd.Parameters.AddWithValue("@Codigo", pessoa.Codigo);
            cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
            cmd.Parameters.AddWithValue("@Email", pessoa.Email);
            cmd.Parameters.AddWithValue("@Numero", pessoa.Numero);
            cmd.Parameters.AddWithValue("@Endereco", pessoa.Endereco);
            cmd.Parameters.AddWithValue("@Cidade", pessoa.Cidade);
            cmd.Parameters.AddWithValue("@Estado", pessoa.Estado);
            cmd.Parameters.AddWithValue("@Telefone", pessoa.Telefone);
            cmd.Parameters.AddWithValue("@Sexo", pessoa.Sexo);
            cmd.Parameters.AddWithValue("@CEP", pessoa.CEP);
            cmd.Parameters.AddWithValue("@Bairro", pessoa.Bairro);
            cmd.Parameters.AddWithValue("@Complemento", pessoa.Complemento);
            cmd.Parameters.AddWithValue("@DataNasc", pessoa.DataNasc);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                sucesso = true;
            }
            catch (Exception ex)
            {
                MensagemErro = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            return sucesso;
        }
        #endregion

        #region Excluir
        public bool Excluir(int codigo)
        {
            bool sucesso = false;
            MensagemErro = "";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            /*DELETE FROM nome_tabela*/
            cmd.CommandText = @"DELETE FROM TB_PESSOAS WHERE Codigo = @Codigo";

            cmd.Parameters.AddWithValue("@Codigo", codigo);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                sucesso = true;
            }
            catch (Exception ex)
            {
                MensagemErro = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            return sucesso;
        }
        #endregion

        #region Pesquisar
        public List<Pessoas> Pesquisar(string nome)
        {
            //Instanciar lista
            List<Pessoas> listaPessoas = new List<Pessoas>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            /*SELECT * FROM TB_PESSOA WHERE Nome LIKE @Nome + '%' OR email LIKE @email*/
            cmd.CommandText = "SELECT * FROM TB_PESSOAS WHERE Nome LIKE @Nome + '%'";

            cmd.Parameters.AddWithValue("@Nome", nome);
            try
            {
                conexao.Open();
                SqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read() == true)
                {
                    Pessoas pessoas = new Pessoas();
                    pessoas.Codigo = Convert.ToInt32(leitor["Codigo"]);
                    pessoas.Nome = leitor["Nome"].ToString();
                    pessoas.Email = leitor["Email"].ToString();
                    pessoas.Numero = Convert.ToInt32(leitor["Numero"]);
                    pessoas.Endereco = leitor["Endereco"].ToString();
                    pessoas.Cidade = leitor["Cidade"].ToString();
                    pessoas.Estado = leitor["Estado"].ToString();
                    pessoas.Telefone = leitor["Telefone"].ToString();
                    pessoas.Sexo = leitor["Sexo"].ToString();
                    pessoas.CEP = leitor["CEP"].ToString();
                    pessoas.Bairro = leitor["Bairro"].ToString();
                    pessoas.Complemento = leitor["Complemento"].ToString();
                    pessoas.DataNasc = leitor["DataNasc"].ToString();

                    listaPessoas.Add(pessoas);
                }
                leitor.Close();
            }
            catch (SqlException ex)
            {
                MensagemErro = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            return listaPessoas;
        }
        #endregion
    }
}
