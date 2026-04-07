using MeuCondo.Enum;

namespace MeuCondo.DTO.Visitante
{
    public class VisitanteResponse
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string NroDocumento { get; set; }
        public TipoVisitante Tipo { get; set; }
        public string Apartamento { get; set; }
        public StatusAcesso Status { get; set; }
        public string NomeMorador { get; set; } 

    }
}
