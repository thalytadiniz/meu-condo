using MeuCondo.Enum;

namespace MeuCondo.DTO.Visitante
{
    public class VisitanteRequest
    {
        public string Nome { get; set; }
        public string NroDocumento { get; set; }
        public string Telefone { get; set; }
        public TipoVisitante Tipo { get; set; }
        public TipoDocumento Documento { get; set; }
        public long MoradorId { get; set; }

    }
}
