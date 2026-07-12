using EasyWhats.Web.Interfaces;
using EasyWhats.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyWhats.Web.Controllers
{
    public class ConfiguracaoSistemaController : Controller
    {
        private readonly IConfiguracaoSistemaRepository _repository;

        public ConfiguracaoSistemaController(IConfiguracaoSistemaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var configuracao = await _repository.ObterConfiguracaoAsync();

            if (configuracao == null)
                configuracao = new ConfiguracaoSistema();

            return View(configuracao);
        }

        [HttpPost]
        public async Task<IActionResult> Salvar(ConfiguracaoSistema configuracao)
        {
            if (!ModelState.IsValid)
                return View("Index", configuracao);

            var existente = await _repository.ObterConfiguracaoAsync();

            if (existente == null)
            {
                await _repository.AdicionarAsync(configuracao);
            }
            else
            {
                existente.Empresa = configuracao.Empresa;
                existente.PhoneNumberId = configuracao.PhoneNumberId;
                existente.BusinessAccountId = configuracao.BusinessAccountId;
                existente.NumeroWhatsApp = configuracao.NumeroWhatsApp;
                existente.AccessToken = configuracao.AccessToken;
                existente.TemplatePadrao = configuracao.TemplatePadrao;

                await _repository.AtualizarAsync(existente);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}