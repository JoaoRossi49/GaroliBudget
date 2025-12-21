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
        int CriarCliente(Cliente cliente);
        void AtualizarCliente(Cliente cliente);
        Cliente ObterPorId(int idCliente);
        List<Cliente> ListarAtivos();
        List<Cliente> ListarTodos();
    }

    public interface IClienteRepository
    {
        int Inserir(Cliente cliente);
        void Atualizar(Cliente cliente);
        Cliente ObterPorId(int idCliente);
        List<Cliente> ListarAtivos();
        List<Cliente> ListarTodos();
        bool ExisteCnpj(string cnpj, int? ignorarId = null);
    }
}
