using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaroliBudget.Models;
using GaroliBudget.Repositories;
using GaroliBudget.Repositories.Interfaces;

namespace GaroliBudget.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public int CriarCliente(Cliente cliente)
        {
            ValidarCliente(cliente);

            if (!string.IsNullOrWhiteSpace(cliente.Cnpj))
            {
                if (_clienteRepository.ExisteCnpj(cliente.Cnpj))
                    throw new Exception("Já existe um cliente cadastrado com este CNPJ.");
            }

            cliente.Ativo = true;

            return _clienteRepository.Inserir(cliente);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            if (cliente.IdCliente <= 0)
                throw new Exception("Cliente inválido.");

            ValidarCliente(cliente);

            if (!string.IsNullOrWhiteSpace(cliente.Cnpj))
            {
                if (_clienteRepository.ExisteCnpj(cliente.Cnpj, cliente.IdCliente))
                    throw new Exception("Já existe outro cliente cadastrado com este CNPJ.");
            }

            _clienteRepository.Atualizar(cliente);
        }

        public Cliente ObterPorId(int idCliente)
        {
            if (idCliente <= 0)
                throw new Exception("ID do cliente inválido.");

            return _clienteRepository.ObterPorId(idCliente);
        }

        public List<Cliente> ListarAtivos()
        {
            return _clienteRepository.ListarAtivos();
        }

        public List<Cliente> ListarTodos()
        {
            return _clienteRepository.ListarTodos();
        }

        public List<Cliente> ListarWhere(string where)
        {
            return _clienteRepository.ListarWhere(where);
        }

        public void InativarCliente(int idCliente)
        {
            var cliente = ObterPorId(idCliente);

            if (cliente == null)
                throw new Exception("Cliente não encontrado.");

            cliente.Ativo = false;
            _clienteRepository.Atualizar(cliente);
        }

        private void ValidarCliente(Cliente cliente)
        {
            if (cliente == null)
                throw new Exception("Cliente não informado.");

            if (string.IsNullOrWhiteSpace(cliente.RazaoSocial))
                throw new Exception("Razão social é obrigatória.");

            if (!string.IsNullOrWhiteSpace(cliente.Email) &&
                !cliente.Email.Contains("@"))
                throw new Exception("E-mail inválido.");
        }
    }

}
