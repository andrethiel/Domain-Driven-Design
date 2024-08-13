using Dados.Models.Produtos;

namespace Dados.Models.Ordens
{
    public class LineItem
    {
        internal LineItem(LineItemId id, OrdemId ordemId, ProdutoId produtoId, Dinheiro valor)
        {
            Id = id;
            OrdemId = ordemId;
            ProdutoId = produtoId;
            Valor = valor;
        }

        public LineItemId Id { get; private set; }
        public OrdemId OrdemId { get; private set; }
        public ProdutoId ProdutoId { get; private set; }
        public Dinheiro Valor { get; private set; }
    }
}
