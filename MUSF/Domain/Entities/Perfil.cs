namespace MUSF.Domain.Entities
{
    public class Perfil
    {
        public Perfil()
        {
            Id = Guid.NewGuid();
            Usuario = new List<Usuario>();
        }
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public string? ExcluidoPor { get; set; }
        public DateTime? ExcluidoEm { get; set; }
        public DateTime? AlteradoEm { get; set; }
        public string? AlteradoPor { get; set; }
        public List<Usuario> Usuario { get; set; }

    }
}
