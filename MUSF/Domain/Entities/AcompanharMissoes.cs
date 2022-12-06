namespace MUSF.Domain.Entities
{
    public class AcompanharMissoes
    {
        public Guid Id { get; set; }
        public string Status { get; set; }
        public string Acoes { get; set; }
        public string Missionario { get; set; }
        public DateTime Duracao { get; set; }
        public string Local { get; set; }
        public decimal RegiaoBrasil { get; set; }
        public decimal RegiaoPais { get; set; }

    }
}
