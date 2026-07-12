using EasyWhats.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyWhats.Web.Data
{
    /// <summary>
    /// Contexto principal do banco de dados.
    /// Responsável por mapear as entidades da aplicação.
    /// </summary>
    public class EasyWhatsContext : DbContext
    {
        public EasyWhatsContext(DbContextOptions<EasyWhatsContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Configurações do sistema.
        /// </summary>
        public DbSet<ConfiguracaoSistema> ConfiguracoesSistema { get; set; }
    }
}
