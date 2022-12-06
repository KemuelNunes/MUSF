using System.Security.Principal;

namespace MUSF.Domain
{
    public class MissaoMissionario
    {
        public Guid Id { get; set; }
        public string NomeMissao { get; set; }
        public string NomeMissionario { get; set; }
        public DateTime? ExcluidoEm { get; set; }
        public string ExcluidoPor { get; set; }
        public DateTime Alteracao { get; set; }


    }
}
