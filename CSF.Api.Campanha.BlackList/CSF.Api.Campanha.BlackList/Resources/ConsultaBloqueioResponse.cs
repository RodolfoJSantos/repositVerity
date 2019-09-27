using CSF.Api.Campanha.BlackList.Domain.Models;
using CSF.Api.Campanha.BlackList.Domain.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSF.Api.Campanha.BlackList.Resources
{
	public class ConsultaBloqueioResponse 
	{
		/// <summary>
		/// Se o participante não está na black list é valido
		/// </summary>
		public bool ParticipanteValido { get; set; }
	}
}
