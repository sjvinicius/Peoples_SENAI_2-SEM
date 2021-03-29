using Senai.Peoples.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Directorys
{
    public class Funcionario : IFuncionarioDirectory
    {
        public int IDFuncionario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Sobrenome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Atualizar(Funcionario idfuncionario)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> BuscarPorId(Funcionario idfuncionario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Funcionario idfuncionario)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Funcionario novofuncionario)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> Listar()
        {

            //Cria uma variável do tipo lista de funcionários, onde os valores tirados do banco de dados serão atribuidos à essa varável
            List<Funcionario> listarTodos = new List<Funcionario>();

            string stringConexao = "";

            using ()
            {

            }

        }
    }
}
