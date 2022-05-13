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
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpGet(nameof(GetEnderecos))]
        public IActionResult GetEnderecos()
        {
            var res = _enderecoService.GetAllEnderecos();
            if (res is not null)
            {
                return Ok(res);
            }
            return BadRequest("No Records Found");
        }

        [HttpGet(nameof(GetEndereco))]
        public IActionResult GetEndereco(Guid id)
        {
            var res = _enderecoService.GetEndereco(id);
            if (res is not null)
            {
                return Ok(res);
            }
            return BadRequest("No Records Found");
        }


        [HttpPost(nameof(InsertEndereco))]
        public IActionResult InsertEndereco(Endereco endereco)
        {
            _enderecoService.InsertEndereco(endereco);
            return Ok("Endereco inserido com sucesso!");
        }

        [HttpPut(nameof(UpdateEndereco))]
        public IActionResult UpdateEndereco(Endereco endereco)
        {
            _enderecoService.UpdateEndereco(endereco);
            return Ok("Endereco Atualizado com sucesso!");
        }

        [HttpDelete(nameof(RemoveEndereco))]
        public IActionResult RemoveEndereco(Guid id)
        {
            _enderecoService.RemoveEndereco(id);
            return Ok("Endereco Removido com sucesso!");
        }
    }
}
