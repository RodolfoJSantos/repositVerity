using CSF.Api.Campanha.BlackList.Infra.Extensions;
using CSF.Api.Campanha.BlackList.Resources;
using Microsoft.AspNetCore.Mvc;

namespace CSF.Api.Campanha.BlackList.Infra.Config
{
	public static class InvalidModelStateResponseFactory
	{
		public static IActionResult ProduceErrorResponse(ActionContext context)
		{
			var erros = context.ModelState.GetMensagemErros();
			var response = new ErroResponse(mensagens: erros);

			return new BadRequestObjectResult(response);
		}
	}
}
