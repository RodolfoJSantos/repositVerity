using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;

namespace CSF.Api.Campanha.BlackList.Infra.Extensions
{
	public static class ModelStateExtensions
	{
		public static List<string> GetMensagemErros(this ModelStateDictionary dictionary)
		{
			return dictionary.SelectMany(_ => _.Value.Errors)
								.Select(_ => _.ErrorMessage).ToList();
		}
	}
}
