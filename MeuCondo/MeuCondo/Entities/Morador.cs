namespace MeuCondo.Entities
{
    public class Morador : Pessoa
    {
        public string Apartamento { get; set; }

        public string Bloco { get; set; }

        public char Ativo { get; set; } // S ou N

    }
}
