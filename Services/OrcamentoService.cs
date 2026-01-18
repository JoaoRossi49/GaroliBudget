using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaroliBudget.Infrastructure;
using GaroliBudget.Models;
using GaroliBudget.Repositories.Interfaces;
using GaroliBudget.Repositories.ItensOrcamento;

namespace GaroliBudget.Services
{
    public class OrcamentoService : IOrcamentoService
    {
        private readonly IOrcamentoRepository _orcamentoRepository;
        private readonly OrcamentoMaterialRepository _materialRepository = new OrcamentoMaterialRepository();
        private readonly OrcamentoComponenteRepository _componenteRepository = new OrcamentoComponenteRepository();
        private readonly OrcamentoProcessoRepository _processoRepository = new OrcamentoProcessoRepository();

        public int Salvar(Orcamento orcamento)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            using var tran = conn.BeginTransaction();

            try
            {
                int id;

                if (orcamento.IdOrcamento == 0)
                    id = _orcamentoRepository.Inserir(orcamento);
                else
                {
                    _orcamentoRepository.Atualizar(orcamento);
                    id = orcamento.IdOrcamento;
                }

                _materialRepository.RemoverPorOrcamento(id, conn, tran);
                _componenteRepository.RemoverPorOrcamento(id, conn, tran);
                _processoRepository.RemoverPorOrcamento(id, conn, tran);

                _materialRepository.InserirLista(id, orcamento.Materiais, conn, tran);
                _componenteRepository.InserirLista(id, orcamento.Componentes, conn, tran);
                _processoRepository.InserirLista(id, orcamento.Processos, conn, tran);

                tran.Commit();
                return id;
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }
        public OrcamentoService(IOrcamentoRepository orcamentoRepository)
        {
            _orcamentoRepository = orcamentoRepository;
        }

        public int CriarOrcamento(Orcamento orcamento)
        {
            orcamento.Ativo = true;

            return _orcamentoRepository.Inserir(orcamento);
        }

        public void AtualizarOrcamento(Orcamento orcamento)
        {
            if (orcamento.IdOrcamento <= 0)
                throw new Exception("Orcamento inválido.");

            _orcamentoRepository.Atualizar(orcamento);
        }

        public Orcamento ObterPorId(int idOrcamento)
        {
            if (idOrcamento <= 0)
                throw new Exception("ID do orcamento inválido.");

            return _orcamentoRepository.ObterPorId(idOrcamento);
        }

        public List<Orcamento> ListarTodos()
        {
            return _orcamentoRepository.ListarTodos();
        }

        public List<Orcamento> ListarWhere(string where)
        {
            return _orcamentoRepository.ListarWhere(where);
        }

        public List<Material> ListarMateriais(int idOrcamento, int idModulo)
        {
            return _materialRepository.ListarPorOrcamentoId(idOrcamento, idModulo);
        }

        public List<Processo> ListarProcessos(int idOrcamento, int idModulo)
        {
            return _processoRepository.ListarPorOrcamentoId(idOrcamento, idModulo);
        }

        public List<Componente> ListarComponentes(int idOrcamento, int idModulo)
        {
            return _componenteRepository.ListarPorOrcamentoId(idOrcamento, idModulo);
        }

        public void InativarOrcamento(int idOrcamento)
        {
            var orcamento = ObterPorId(idOrcamento);

            if (orcamento == null)
                throw new Exception("Orcamento não encontrado.");

            orcamento.Ativo = false;
            _orcamentoRepository.Atualizar(orcamento);
        }

    }

}
