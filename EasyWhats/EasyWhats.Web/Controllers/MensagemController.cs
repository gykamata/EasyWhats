using EasyWhats.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyWhats.Web.Controllers
{
    public class MensagemController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new EnviarMensagemModel());
        }

        [HttpPost]
        public IActionResult Enviar(EnviarMensagemModel model)
        {
            if (!ModelState.IsValid)
                return View("Index", model);

            var numeros = model.Numeros
                .Split(new[] { '\r', '\n', ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => n.Trim())
                .ToList();

            ViewBag.Total = numeros.Count;
            ViewBag.Lista = numeros;

            return View("Resultado");
        }
    }
}