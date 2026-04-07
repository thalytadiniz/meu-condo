using MeuCondo.Enum;


namespace MeuCondo.Entities
{
    public class Funcionario : Pessoa
    {
        public TipoFuncionario Tipo { get; set; }
        public string MatriculaCarteira { get; set; }
    }
}
    