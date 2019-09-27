using System;
using System.ComponentModel.DataAnnotations;

namespace CSF.Api.Campanha.BlackList.Resources
{
	public class ConsultaBloqueioRequest
	{
		/// <summary>
		/// CPF do participante
		/// </summary>
		[Required(ErrorMessage = "Cpf é obrigatório")]
		public string Cpf { get; set; }

		/// <summary>
		/// Data de nascimento do participante
		/// </summary>        
		[Required(ErrorMessage = "Data Nascimento é obrigatório")]
		public DateTime DataNascimento { get; set; }

		/// <summary>
		/// Numero de identificação da campanha
		/// </summary>        
		[Required(ErrorMessage = "Id Campanha é obrigatório")]
		public int IdCampanha { get; set; }
	}
}
