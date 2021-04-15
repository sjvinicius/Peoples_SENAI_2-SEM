using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Senai.Peoples.WebApi.Domains;
using Senai.Peoples.WebApi.Interfaces;
using Senai.Peoples.WebApi.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Controllers
{
     // Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    // Define que a rota de uma requisição será no formato domínio/api/NomeController
    [Route("api/[controller]")]

    // Define que é um controlador de API
    [ApiController]

    public class FuncionarioController : ControllerBase

    {
        // Instanciando objeto para receber todos os métodos da interface IFuncionarioRepository
        private IFuncionarioRepository _funcionarioRepository { get; set; }

        public FuncionarioController() {

            _funcionarioRepository = new FuncionarioRepository();


        }

        [HttpGet]
        public IActionResult Get()
        {

            List<FuncionarioDomain> listaFuncionarios = _funcionarioRepository.Listar();

            return Ok(listaFuncionarios);

        }



        [HttpGet("{id}")]

        public IActionResult GetById( FuncionarioDomain func )
        {

            int idFunc = func.IdFuncionario ;

            FuncionarioDomain listafuncionarioID = _funcionarioRepository.BuscarPorId( func.IdFuncionario );

            return Ok(listafuncionarioID);

        }
    }
}
