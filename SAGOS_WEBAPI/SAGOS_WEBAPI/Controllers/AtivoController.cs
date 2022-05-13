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
    public class AtivoController : ControllerBase
    {
        private readonly IAtivoService _ativoService;

        public AtivoController(IAtivoService ativoService)
        {
            _ativoService = ativoService;
        }

        [HttpGet(nameof(GetAtivos))]
        public IActionResult GetAtivos()
        {
            var res = _ativoService.GetAllAtivos();
            if (res is not null)
            {
                return Ok(res);
            }
            return BadRequest("No Records Found");
        }

        [HttpGet(nameof(GetAtivo))]
        public IActionResult GetAtivo(Guid id)
        {
            var res = _ativoService.GetAtivo(id);
            if (res is not null)
            {
                return Ok(res);
            }
            return BadRequest("No Records Found");
        }


        [HttpPost(nameof(InsertAtivo))]
        public IActionResult InsertAtivo(Ativo ativo)
        {
            _ativoService.InsertAtivo(ativo);
            return Ok("Ativo inserido com sucesso!");
        }

        [HttpPut(nameof(UpdateAtivo))]
        public IActionResult UpdateAtivo(Ativo ativo)
        {
            _ativoService.UpdateAtivo(ativo);
            return Ok("Ativo Atualizado com sucesso!");
        }

        [HttpDelete(nameof(RemoveAtivo))]
        public IActionResult RemoveAtivo(Guid id)
        {
            _ativoService.RemoveAtivo(id);
            return Ok("Ativo Removido com sucesso!");
        }
    }
}
