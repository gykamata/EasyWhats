using EasyWhats.Web.Models;

namespace EasyWhats.Web.Interfaces
{
    public interface IConfiguracaoSistemaRepository
    {
        Task<List<ConfiguracaoSistema>> ObterTodosAsync();
        Task<ConfiguracaoSistema?> ObterPorIdAsync(int id);
        Task<ConfiguracaoSistema?> ObterConfiguracaoAsync();
        Task AdicionarAsync(ConfiguracaoSistema configuracao);
        Task AtualizarAsync(ConfiguracaoSistema configuracao);
        Task DesativarAsync(int id);
    }
}
