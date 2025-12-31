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
    public class ProcessoService : IProcessoService
    {
        private readonly IProcessoRepository _processoRepository;

        public ProcessoService(IProcessoRepository processoRepository)
        {
            _processoRepository = processoRepository;
        }

        public int CriarProcesso(Processo processo)
        {
            processo.Ativo = true;

            return _processoRepository.Inserir(processo);
        }

        public void AtualizarProcesso(Processo processo)
        {
            if (processo.IdProcesso <= 0)
                throw new Exception("Processo inválido.");

            _processoRepository.Atualizar(processo);
        }

        public Processo ObterPorId(int idProcesso)
        {
            if (idProcesso <= 0)
                throw new Exception("ID do processo inválido.");

            return _processoRepository.ObterPorId(idProcesso);
        }

        public List<Processo> ListarAtivos()
        {
            return _processoRepository.ListarAtivos();
        }

        public List<Processo> ListarTodos()
        {
            return _processoRepository.ListarTodos();
        }

        public List<Processo> ListarWhere(string where)
        {
            return _processoRepository.ListarWhere(where);
        }

        public void InativarProcesso(int idProcesso)
        {
            var processo = ObterPorId(idProcesso);

            if (processo == null)
                throw new Exception("Processo não encontrado.");

            processo.Ativo = false;
            _processoRepository.Atualizar(processo);
        }

    }

}
