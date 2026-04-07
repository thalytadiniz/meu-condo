using MeuCondo.Enum;

namespace MeuCondo.Entities
{
    public class Visitante : Pessoa
    {
        public StatusAcesso Acesso { get; set; }
        public long MoradorId { get; set; }

        public TipoVisitante Tipo { get; set; }

        public TipoDocumento TipoDoc { get; set; }
        public Morador Morador { get; set; }
    }
}
