using System.ComponentModel.DataAnnotations;

namespace EasyWhats.Web.Models
{
    public class EnviarMensagemModel
    {
        [Required(ErrorMessage = "Informe pelo menos um número.")]
        [Display(Name = "Números de WhatsApp")]
        public string Numeros { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite a mensagem.")]
        [Display(Name = "Mensagem")]
        public string Mensagem { get; set; } = string.Empty;
    }
}