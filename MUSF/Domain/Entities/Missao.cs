using System.ComponentModel.DataAnnotations;

namespace MUSF.Domain.Entities
{
    public class Missao
    {
        public Missao()
        {
            MissaoMissionario = new List<MissaoMissionario>();
        }
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Objetivo { get; set; }
        public List<Usuario> Voluntarios { get; set; }
        public string Envolvidos { get; set; }
        public string Etapas { get; set; }
        public string Tipos { get; set; }
        public DateTime? ExcluidoEm { get; set; }
        public string ExcluidoPor { get; set; }
        public ICollection<MissaoMissionario> MissaoMissionario { get; set; }
    }
}
