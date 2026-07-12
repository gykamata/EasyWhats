namespace EasyWhats.Web.Models.Base
{
    /// <summary>
    /// Classe base para todas as entidades do sistema.
    /// Contém propriedades comuns que serão herdadas pelas demais entidades.
    /// </summary>
    public abstract class EntityBase
    {
        /// <summary>
        /// Identificador único da entidade.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Data em que o registro foi criado.
        /// </summary>
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        /// <summary>
        /// Data da última alteração.
        /// </summary>
        public DateTime? DataAlteracao { get; set; }

        /// <summary>
        /// Indica se o registro está ativo.
        /// </summary>
        public bool Ativo { get; set; } = true;
    }
}
