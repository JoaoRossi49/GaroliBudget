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
    public class ComponenteService : IComponenteService
    {
        private readonly IComponenteRepository _componenteRepository;

        public ComponenteService(IComponenteRepository componenteRepository)
        {
            _componenteRepository = componenteRepository;
        }

        public int CriarComponente(Componente componente)
        {
            componente.Ativo = true;

            return _componenteRepository.Inserir(componente);
        }

        public void AtualizarComponente(Componente componente)
        {
            if (componente.IdComponente <= 0)
                throw new Exception("Componente inválido.");

            _componenteRepository.Atualizar(componente);
        }

        public Componente ObterPorId(int idComponente)
        {
            if (idComponente <= 0)
                throw new Exception("ID do componente inválido.");

            return _componenteRepository.ObterPorId(idComponente);
        }

        public List<Componente> ListarAtivos()
        {
            return _componenteRepository.ListarAtivos();
        }

        public List<Componente> ListarTodos()
        {
            return _componenteRepository.ListarTodos();
        }

        public List<Componente> ListarWhere(string where)
        {
            return _componenteRepository.ListarWhere(where);
        }

        public void InativarComponente(int idComponente)
        {
            var componente = ObterPorId(idComponente);

            if (componente == null)
                throw new Exception("Componente não encontrado.");

            componente.Ativo = false;
            _componenteRepository.Atualizar(componente);
        }

    }

}
