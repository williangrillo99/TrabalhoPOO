namespace SistemaEscola.Dominio.Enderecos.Entidade
{
    public class Endereco
    {
        public string Cidade { get; set; } = null!;
        public string Bairro { get; set; } = null!;
        public string Rua { get; set; } = null!;
        public int Numero { get; set; }
        public int Cep { get; set; }
    }
}