using CSF.Api.Campanha.BlackList.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSF.Api.Campanha.BlackList.Domain.Services.Communication
{
	public class ConsultaBloqueioResponse : BaseResponse<ConsultaBloqueio>
	{
		public ConsultaBloqueioResponse(ConsultaBloqueio response) : base(response)
		{ }

		public ConsultaBloqueioResponse(string mensagem) : base(mensagem)
		{ }
	}
}
