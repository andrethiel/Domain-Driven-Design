using Dados.Models.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Clientes
{
    public interface IClienteRepository
    {
        Task<Cliente?> ListarId(ClienteId id);
    }
}
