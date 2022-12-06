using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace MUSF.Domain.Entities
{
    public class MissaoMissionario
    {
        public MissaoMissionario()
        {

        }
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Missao")]
        public Guid  MissaoId { get; set; }
        [ForeignKey("Missionario")]
        public Guid MissionarioId { get; set; }

        public DateTime? ExcluidoEm { get; set; }
        public string ExcluidoPor { get; set; }
        public DateTime Alteracao { get; set; }

        public Missao Missao { get; set; }
        public Missionario Missionario { get; set; }
        
    }
}
