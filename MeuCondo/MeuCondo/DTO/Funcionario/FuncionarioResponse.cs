using MeuCondo.Enum;

namespace MeuCondo.DTO.Funcionario
{
    public class FuncionarioResponse
    {
        public string Nome { get; set; }
        public string NroDocumento { get; set; }
        public string Telefone { get; set; }
        public TipoFuncionario Tipo { get; set; }
        public string MatriculaCarteira { get; set; }

    }
}
