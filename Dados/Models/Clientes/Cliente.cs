namespace Dados.Models.Clientes
{
    public class Cliente
    {
        public ClienteId Id { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
    }
}
