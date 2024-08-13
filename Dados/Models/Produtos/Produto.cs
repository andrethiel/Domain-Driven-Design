using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Models.Produtos
{
    public class Produto
    {
        public ProdutoId Id { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public Dinheiro Valor { get; private set; }
        public Sku Sku { get; private set; }
    }
}
