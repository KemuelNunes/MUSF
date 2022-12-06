namespace MUSF.Domain
{
    public class TransacaoUsuario
    {
        public Guid Id { get; set; }
        public string TipoTransacao { get; set; }
        public string NomeTransacao { get; set; }
        public DateTime DataTransacao { get; set; }


    }
}
