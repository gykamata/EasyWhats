using EasyWhats.Web.Data;
using EasyWhats.Web.Interfaces;
using EasyWhats.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyWhats.Web.Repositories
{
    public class ConfiguracaoSistemaRepository : IConfiguracaoSistemaRepository
    {
        private readonly EasyWhatsContext _context;

        public ConfiguracaoSistemaRepository(EasyWhatsContext context)
        {
            _context = context;
        }

        public async Task<List<ConfiguracaoSistema>> ObterTodosAsync()
        {
            return await _context.ConfiguracoesSistema
                .Where(c => c.Ativo)
                .OrderBy(c => c.Empresa)
                .ToListAsync();
        }

        public async Task<ConfiguracaoSistema?> ObterPorIdAsync(int id)
        {
            return await _context.ConfiguracoesSistema
                .FirstOrDefaultAsync(c => c.Id == id && c.Ativo);
        }

        public async Task<ConfiguracaoSistema?> ObterConfiguracaoAsync()
        {
            return await _context.ConfiguracoesSistema
                .Where(c => c.Ativo)
                .FirstOrDefaultAsync();
        }

        public async Task AdicionarAsync(ConfiguracaoSistema configuracao)
        {
            await _context.ConfiguracoesSistema.AddAsync(configuracao);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(ConfiguracaoSistema configuracao)
        {
            configuracao.DataAlteracao = DateTime.Now;

            _context.ConfiguracoesSistema.Update(configuracao);

            await _context.SaveChangesAsync();
        }

        public async Task DesativarAsync(int id)
        {
            var configuracao = await ObterPorIdAsync(id);

            if (configuracao == null)
                return;

            configuracao.Ativo = false;
            configuracao.DataAlteracao = DateTime.Now;

            _context.ConfiguracoesSistema.Update(configuracao);

            await _context.SaveChangesAsync();
        }
    }
}
