using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAGOS_WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {

        private readonly IFuncionarioService _funcionarioService;
        public FuncionarioController(IFuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        [HttpGet(nameof(GetAllFuncionarios))]
        public IActionResult GetAllFuncionarios()
        {
            var res = _funcionarioService.GetAllFuncionarios();
            if(res is not null)
            {
                return Ok(res);
            }
            return BadRequest("No Records Found");
        }

        [HttpGet(nameof(GetFuncionarios))]
        public IActionResult GetFuncionarios(Guid id)
        {
            var res = _funcionarioService.getFuncionario(id);
            if (res is not null)
            {
                return Ok(res);
            }
            return BadRequest("No Records Found");
        }

        [HttpPost(nameof(InsertFuncionarios))]
        public IActionResult InsertFuncionarios(Funcionario funcionario)
        {
            _funcionarioService.InsertFuncionario(funcionario);
            return Ok("Funcionario inserido com sucesso!");
        }

        [HttpPut(nameof(UpdateFuncionarios))]
        public IActionResult UpdateFuncionarios(Funcionario funcionario)
        {
            _funcionarioService.UpdateFuncionario(funcionario);
            return Ok("Funcionario Atualizado com sucesso!");
        }

        [HttpDelete(nameof(RemoveFuncionarios))]
        public IActionResult RemoveFuncionarios(Guid id)
        {
            _funcionarioService.RemoveFuncionario(id);
            return Ok("Funcionario Removido com sucesso!");
        }
    }
}
