using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaroliBudget.Infrastructure;
using GaroliBudget.Models;
using GaroliBudget.Repositories;
using GaroliBudget.Repositories.Interfaces;

namespace GaroliBudget.Services
{
    public class EquipamentoService : IEquipamentoService
    {
        private readonly IEquipamentoRepository _equipamentoRepository;
        private readonly EquipamentoMaterialRepository _materialRepository;
        private readonly EquipamentoComponenteRepository _componenteRepository;
        private readonly EquipamentoProcessoRepository _processoRepository;

        public int Salvar(Equipamento equipamento)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            using var tran = conn.BeginTransaction();

            try
            {
                int id;

                if (equipamento.IdEquipamento == 0)
                    id = _equipamentoRepository.Inserir(equipamento);
                else
                {
                    _equipamentoRepository.Atualizar(equipamento);
                    id = equipamento.IdEquipamento;
                }

                _materialRepository.RemoverPorEquipamento(id, conn, tran);
                _componenteRepository.RemoverPorEquipamento(id, conn, tran);
                _processoRepository.RemoverPorEquipamento(id, conn, tran);

                _materialRepository.InserirLista(id, equipamento.Materiais, conn, tran);
                _componenteRepository.InserirLista(id, equipamento.Componentes, conn, tran);
                _processoRepository.InserirLista(id, equipamento.Processos, conn, tran);

                tran.Commit();
                return id;
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }
        public EquipamentoService(IEquipamentoRepository equipamentoRepository)
        {
            _equipamentoRepository = equipamentoRepository;
        }

        public int CriarEquipamento(Equipamento equipamento)
        {
            equipamento.Ativo = true;

            return _equipamentoRepository.Inserir(equipamento);
        }

        public void AtualizarEquipamento(Equipamento equipamento)
        {
            if (equipamento.IdEquipamento <= 0)
                throw new Exception("Equipamento inválido.");

            _equipamentoRepository.Atualizar(equipamento);
        }

        public Equipamento ObterPorId(int idEquipamento)
        {
            if (idEquipamento <= 0)
                throw new Exception("ID do equipamento inválido.");

            return _equipamentoRepository.ObterPorId(idEquipamento);
        }

        public List<Equipamento> ListarAtivos()
        {
            return _equipamentoRepository.ListarAtivos();
        }

        public List<Equipamento> ListarTodos()
        {
            return _equipamentoRepository.ListarTodos();
        }

        public List<Equipamento> ListarWhere(string where)
        {
            return _equipamentoRepository.ListarWhere(where);
        }

        public void InativarEquipamento(int idEquipamento)
        {
            var equipamento = ObterPorId(idEquipamento);

            if (equipamento == null)
                throw new Exception("Equipamento não encontrado.");

            equipamento.Ativo = false;
            _equipamentoRepository.Atualizar(equipamento);
        }

    }

}
