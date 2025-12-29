using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaroliBudget.Models;

namespace GaroliBudget.Repositories.Interfaces
{
    public interface IClienteService
    {
        void Inserir(Cliente cliente);
        void Atualizar(Cliente cliente);
        Cliente ObterPorId(int idCliente);
        List<Cliente> ListarAtivos();
        List<Cliente> ListarTodos();
    }

    public interface IClienteRepository
    {
        void Inserir(Cliente cliente);
        void Atualizar(Cliente cliente);
        Cliente ObterPorId(int idCliente);
        List<Cliente> ListarAtivos();
        List<Cliente> ListarTodos();
        List<Cliente> ListarWhere(string where);
        bool ExisteCnpj(string cnpj, int? ignorarId = null);
    }
}
