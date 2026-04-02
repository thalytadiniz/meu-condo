namespace MeuCondo.Entities
{
    public abstract class Pessoa
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string NroDocumento { get; set; } // Quando for morador ou funcionario vai ser usado CPF. Foi criado assim pra reaproveitar a classe abstrata em Visitante, porém nele pode usar o enum TipoDocumento
        public string Telefone { get; set; }
        public DateTime Data { get; set; }
    }
}
