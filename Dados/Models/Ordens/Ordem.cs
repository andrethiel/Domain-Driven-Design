using Dados.Models.Clientes;
using Dados.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Models.Ordens
{
    public class Ordem
    {
        private readonly HashSet<LineItem> _lineItems = new();

        private Ordem()
        {

        }
        public OrdemId Id { get; private set; }
        public ClienteId ClienteId { get; private set; }

        public static Ordem Criar(ClienteId clienteId)
        {
            var ordem = new Ordem
            {
                Id = new OrdemId(Guid.NewGuid()),
                ClienteId = clienteId
            };

            return ordem;

        }

        public void Add(ProdutoId produtoId, Dinheiro Valor)
        {
            var lineItem = new LineItem(new LineItemId(Guid.NewGuid()), Id, produtoId, Valor);
            _lineItems.Add(lineItem);
        }
    }
}
