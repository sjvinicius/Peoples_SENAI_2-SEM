using Senai.Peoples.WebApi.Directorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Interfaces
{
    interface IFuncionarioDirectory
    {
        // ATRIBUTOS

        /// <summary>
        ///     Identificador único de cada funcionário da empresa PEOPLES
        /// </summary>
        public int IDFuncionario { get; set; }

        /// <summary>
        ///     Nome dos Funcionários da empresa PEOPLES
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        ///     Sobrenome dos funcionários da empresa PEOPLES
        /// </summary>
        public string Sobrenome { get; set; }


        //MÉTODOS

        /// <summary>
        ///     Insere um novo funcionário na tabela do banco de dados
        /// </summary>
        /// <param name="novofuncionario"> utiliza os como argumento os dados do novo usuário para fazer a inserção do funcionário no banco de dados </param>
        void Inserir(Funcionario novofuncionario);

        /// <summary>
        ///     Apresenta o nome e sobrenome de todos os usuários presente no banco de dados
        /// </summary>
        /// <returns> Retorna a lista de funcionários cadastrados no banco de dados </returns>
        List<Funcionario> Listar();

        /// <summary>
        /// 
        ///     Faz a requisição de um funcionários especifico ao banco de dados ao fornecer o seu ID para encontrar o usuario desejado
        /// 
        /// </summary>
        /// <param name="idfuncionario">Parâmetro especificado pelo usuário para solicitar o usuário que deseja buscar</param>
        /// <returns>
        ///     Retorna o Usuário solicitado ao banco de dados 
        /// </returns>
        List<Funcionario> BuscarPorId(Funcionario idfuncionario);

        /// <summary>
        ///     Deleta um Funcionário especificado pelo pelo usuário
        /// </summary>
        /// <param name="idfuncionario"> parâmetro especificado pelo usuário para selecionar o ID do usuário à ser deletado </param>
        void Deletar(Funcionario idfuncionario);

        /// <summary>
        ///     Faz alguma alteração nos dados de algum funcionário que o usuário desejar
        /// </summary>
        /// <param name="idfuncionario"> Parâmetro de seleção para que o usuário direcione o funcionário à ser alterado </param>
        void Atualizar(Funcionario idfuncionario);

    }
}
