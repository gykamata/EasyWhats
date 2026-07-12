using EasyWhats.Web.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace EasyWhats.Web.Models
{
    public class ConfiguracaoSistema : EntityBase
    {
        [Required]
        [StringLength(100)]
        public string Empresa { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Phone Number ID")]
        public string PhoneNumberId { get; set; } = string.Empty;

        [Required]
        [Display(Name = "WhatsApp Business Account ID")]
        public string BusinessAccountId { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Access Token")]
        public string AccessToken { get; set; } = string.Empty;

        [Display(Name = "Template Padrão")]
        public string? TemplatePadrao { get; set; }

        [Display(Name = "Número WhatsApp")]
        public string NumeroWhatsApp { get; set; } = string.Empty;
    }
}