namespace MUSF.Domain
{
    public class Missionario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Igreja { get; set; }
        public DateTime? ExcluidoEm { get; set; }
        public string ExcluidoPor { get; set; }
        public DateTime Alteracao { get; set; }
        public ICollection<Missao> Missao { get; set; }
    }
}
