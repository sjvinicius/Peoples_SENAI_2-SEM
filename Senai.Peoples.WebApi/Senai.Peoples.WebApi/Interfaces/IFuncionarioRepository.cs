using Senai.Peoples.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Interfaces
{
    interface IFuncionarioRepository
    {
        // atributos

        /// <summary>
        ///     identificador único de cada funcionário da empresa peoples
        /// </summary>
        //public int idfuncionario { get; set; }

        /// <summary>
        ///     nome dos funcionários da empresa peoples
        /// </summary>
        //public string nome { get; set; }

        /// <summary>
        ///     sobrenome dos funcionários da empresa peoples
        /// </summary>
        //public string sobrenome { get; set; }


        //MÉTODOS

        /// <summary>
        ///     Insere um novo funcionário na tabela do banco de dados
        /// </summary>
        /// <param name="novofuncionario"> utiliza os como argumento os dados do novo usuário para fazer a inserção do funcionário no banco de dados </param>
        void Inserir(FuncionarioDomain novofuncionario);

        /// <summary>
        ///     Apresenta o nome e sobrenome de todos os usuários presente no banco de dados
        /// </summary>
        /// <returns> Retorna a lista de funcionários cadastrados no banco de dados </returns>
        List<FuncionarioDomain> Listar();

        /// <summary>
        /// 
        ///     Faz a requisição de um funcionários especifico ao banco de dados ao fornecer o seu ID para encontrar o usuario desejado
        /// 
        /// </summary>
        /// <param name="idfuncionario">Parâmetro do tipo int especificado pelo usuário para solicitar o usuário que deseja buscar</param>
        /// <returns>
        ///     Retorna o Usuário solicitado ao banco de dados 
        /// </returns>
        FuncionarioDomain BuscarPorId(int idfuncionario);

        /// <summary>
        ///     Deleta um Funcionário especificado pelo pelo usuário
        /// </summary>
        /// <param name="idfuncionario"> parâmetro especificado pelo usuário para selecionar o ID do usuário à ser deletado </param>
        void Deletar(int idfuncionario);

        /// <summary>
        ///     Faz alguma alteração nos dados de algum funcionário que o usuário desejar
        /// </summary>
        /// <param name="idfuncionario"> Parâmetro de seleção para que o usuário direcione o funcionário à ser alterado </param>
        void Atualizar(int idfuncionario);
    }
}
