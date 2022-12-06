namespace MUSF.Domain.Entities
{
    public class Transacao
    {
        public Guid Id { get; set; }
        public string Tipo { get; set; }
        public DateTime? ExcluidoEm { get; set; }
        public string ExcluidoPor { get; set; }
        public DateTime Alteracao { get; set; }

    }
}
