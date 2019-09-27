using AutoMapper;
using CSF.Api.Campanha.BlackList.Domain.Models;
using CSF.Api.Campanha.BlackList.Domain.Services;
using CSF.Api.Campanha.BlackList.Resources;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSF.Api.Campanha.BlackList.Controllers
{
	public class BlackListController : ControllerBase
	{
		private readonly IConsultaBloqueioService _consultaBloqueioService;
		private readonly IMapper _mapper;

		public BlackListController(IConsultaBloqueioService consultaDataService, IMapper mapper)
		{
			_consultaBloqueioService = consultaDataService;
			_mapper = mapper;
		}

		[HttpPost]
		[Route("ConsultaBlackList")]
		[ProducesResponseType(typeof(ConsultaBloqueioResponse), 200)]
		[ProducesResponseType(typeof(ErroResponse), 400)]
		public async Task<IActionResult> ParticipanteValido([FromBody] ConsultaBloqueioRequest request)
		{
			var result = await _consultaBloqueioService.ParticipanteValido(request);

			if (!result.Sucesso)
				return BadRequest(new ErroResponse(result.Mensagem));

			var clienteResponse = _mapper.Map<ConsultaBloqueio, ConsultaBloqueioResponse>(result.Response);

			return Ok(clienteResponse);
		}
	}
}
