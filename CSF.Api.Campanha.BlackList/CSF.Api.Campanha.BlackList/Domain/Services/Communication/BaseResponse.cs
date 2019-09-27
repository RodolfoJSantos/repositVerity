using System.Collections.Generic;

namespace CSF.Api.Campanha.BlackList.Domain.Services.Communication
{
	public class BaseResponse<T>
	{
		public bool Sucesso { get; protected set; }
		public string Mensagem { get; protected set; }
		public T Response { get; private set; }
		public List<T> Responses { get; private set; }

		protected BaseResponse(T response)
		{
			Sucesso = true;
			Mensagem = string.Empty;
			Response = response;
		}

		protected BaseResponse(List<T> responses)
		{
			Sucesso = true;
			Mensagem = string.Empty;
			Responses = responses;
		}

		protected BaseResponse(string mensagem)
		{
			Sucesso = false;
			Mensagem = mensagem;
			Response = default;
		}
	}
}
