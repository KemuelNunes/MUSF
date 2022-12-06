namespace MUSF.Domain
{
    public class Perfil
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public string ExcluidoPor { get; set; }
        public DateTime? ExcluidoEm { get; set; }
        public DateTime? AlteradoEm { get; set; }
        public string AlteradoPor { get; set; }
        public List<Usuario> Usuario { get; set; }

    }
}
