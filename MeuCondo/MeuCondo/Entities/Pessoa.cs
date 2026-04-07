namespace MeuCondo.Entities
{
    public abstract class Pessoa
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string NroDocumento { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
