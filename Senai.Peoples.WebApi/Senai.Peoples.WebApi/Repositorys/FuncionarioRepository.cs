using Senai.Peoples.WebApi.Domains;
using Senai.Peoples.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Repositorys
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        public int IDFuncionario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Sobrenome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        string stringConexao = "Data Source: LAPTOP-5IAR0TCC ; Initial Catalog: funcionario; User Id: sa ; Pwd: senai@132 ; ";

        public void Atualizar(FuncionarioDomain idfuncionario)
        {
            throw new NotImplementedException();
        }

        public FuncionarioDomain BuscarPorId(int idfuncionario)
        {

            using (SqlConnection con = new SqlConnection())
            {

                string querySelectId = $"SELECT * FROM funcionario WHERE IdFuncionario = @ID";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectId, con))
                {

                    // Adiciona um valor à um parametro em comando SQL
                    cmd.Parameters.AddWithValue("@ID", idfuncionario);

                    FuncionarioDomain func = new FuncionarioDomain();

                    rdr = cmd.ExecuteReader();
                    
                    FuncionarioDomain funcionarioBuscado = new FuncionarioDomain();

                    if (rdr.Read())
                    {

                        funcionarioBuscado.IdFuncionario      = Convert.ToInt32(rdr["idFuncionario"]);
                        funcionarioBuscado.NomeFuncionario    = rdr["nomeFuncionario"].ToString();
                        funcionarioBuscado.Sobrenome          = rdr["sobrenomeFuncionario"].ToString();

                        return funcionarioBuscado;

                    }

                    else
                    {

                        return null;

                    }
                }
            }
        }

        public void Inserir(FuncionarioDomain novofuncionario)
        {
            throw new NotImplementedException();
        }

        public List<FuncionarioDomain> Listar()
        {
            //Cria uma variável do tipo lista de funcionários, onde os valores tirados do banco de dados serão atribuidos à essa varável
            List<FuncionarioDomain> listarTodos = new List<FuncionarioDomain>();

            // Abrindo conexão diretamente com o banco de dados
            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                // Criando string com o valor do comando referente ao banco de dados da onde vamos tirar as informações
                string querySelecionarTudo = "SELECT * FROM funcionario";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelecionarTudo, con))
                {


                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                        FuncionarioDomain func = new FuncionarioDomain();

                        func.IdFuncionario      = Convert.ToInt32(rdr[0]);
                        func.NomeFuncionario    = rdr[1].ToString();
                        func.Sobrenome          = rdr[2].ToString();

                        listarTodos.Add(func);

                    }

                    return listarTodos;
                }
            }
        }

        public void Deletar(int idfuncionario)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(int idfuncionario)
        {
            throw new NotImplementedException();
        }
    }
}
