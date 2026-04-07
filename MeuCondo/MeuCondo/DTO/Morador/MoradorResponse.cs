namespace MeuCondo.DTO.Morador
{
    public class MoradorResponse
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string NroDocumento { get; set; }
        public string Telefone { get; set; }
        public string Apartamento { get; set; }
        public string Bloco { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
