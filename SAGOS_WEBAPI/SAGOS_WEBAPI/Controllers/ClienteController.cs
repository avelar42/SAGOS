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
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet(nameof(GetClientes))]
        public IActionResult GetClientes()
        {
            var res = _clienteService.GetAllClientes();
            if(res is not null)
            {
                return Ok(res);
            }
            return BadRequest("No Records Found");
        }

        [HttpGet(nameof(GetCliente))]
        public IActionResult GetCliente(Guid id)
        {
            var res = _clienteService.GetCliente(id);
            if (res is not null)
            {
                return Ok(res);
            }
            return BadRequest("No Records Found");
        }


        [HttpPost(nameof(InsertCliente))]
        public IActionResult InsertCliente(Cliente cliente)
        {
            _clienteService.InsertClientes(cliente);
            return Ok("Cliente inserido com sucesso!");
        }

        [HttpPut(nameof(UpdateCliente))]
        public IActionResult UpdateCliente(Cliente cliente)
        {
            _clienteService.UpdateClientes(cliente);
            return Ok("Cliente Atualizado com sucesso!");
        }

        [HttpDelete(nameof(RemoveCliente))]
        public IActionResult RemoveCliente(Guid id)
        {
            _clienteService.RemoveClientes(id);
            return Ok("Funcionario Removido com sucesso!");
        }
    }
}
