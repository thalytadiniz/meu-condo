using MeuCondo.Enum;

namespace MeuCondo.DTO.Visitante
{
    public class VisitanteRequest
    {
        public string Nome { get; set; }
        public string NroCpf { get; set; }
        public string Telefone { get; set; }
        public TipoVisitante Tipo { get; set; }
    }
}
