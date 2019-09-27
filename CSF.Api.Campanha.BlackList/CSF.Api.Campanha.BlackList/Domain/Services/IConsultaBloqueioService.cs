using CSF.Api.Campanha.BlackList.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSF.Api.Campanha.BlackList.Domain.Services
{
	public interface IConsultaBloqueioService
	{
		Task<ConsultaBloqueioResponse> ParticipanteValido(ConsultaBloqueioRequest request);					 
	}
}
