using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSF.Api.Campanha.BlackList.Resources
{
	public class ErroResponse
	{
		/// <summary>
		/// Status do processamento da requisição
		/// </summary>
		public bool Sucesso => false;

		/// <summary>
		/// Mensagens de erros apresentadas
		/// </summary>
		public List<string> Mensagens { get; private set; }

		public ErroResponse(List<string> mensagens)
		{
			this.Mensagens = mensagens ?? new List<string>();
		}

		public ErroResponse(string mensagem)
		{
			this.Mensagens = new List<string>();

			if (!string.IsNullOrWhiteSpace(mensagem))
			{
				this.Mensagens.Add(mensagem);
			}
		}
	}
}
