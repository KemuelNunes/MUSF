using System;

namespace MUSF.Domain.Entities
{

    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime CriadoEm { get; set; }
        public string Telefone { get; set; }
        public string ExcluidoPor { get; set; }
        public DateTime? ExcluidoEm { get; set; }
        public List<Missao> Missao { get; set; }
        public Perfil Perfil { get; set; }
        public Guid PerfilId { get; set; }


    }
}

