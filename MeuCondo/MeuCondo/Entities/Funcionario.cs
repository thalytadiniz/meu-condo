using MeuCondo.Enum;


namespace MeuCondo.Entities
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public TipoFuncionario tipo { get; set; }
        public string MatriculaCarteira { get; set; }
    }
}
