using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaroliBudget.Models;
using Npgsql;

namespace GaroliBudget.Repositories.Interfaces
{
    public interface IOrcamentoService
    {
        int CriarOrcamento(Orcamento Orcamento);
        int Salvar(Orcamento Orcamento);
        void AtualizarOrcamento(Orcamento Orcamento);
        Orcamento ObterPorId(int idOrcamento);
        List<Orcamento> ListarTodos();
        List<Material> ListarMateriais(int idOrcamento, int idModulo = 0);
        List<Processo> ListarProcessos(int idOrcamento, int idModulo = 0);
        List<Componente> ListarComponentes(int idOrcamento, int idModulo = 0);
    }

    public interface IOrcamentoRepository
    {
        int Inserir(Orcamento Orcamento);
        void Atualizar(Orcamento Orcamento);
        Orcamento ObterPorId(int idOrcamento);
        List<Orcamento> ListarTodos();
        List<Orcamento> ListarWhere(string where);

    }

    public interface IOrcamentoMaterialRepository
    {
        void InserirLista(
            int idOrcamento,
            List<Material> materiais,
            NpgsqlConnection conn,
            NpgsqlTransaction tran);
        void RemoverPorOrcamento(
            int idOrcamento,
            NpgsqlConnection conn,
            NpgsqlTransaction tran);
    }

    public interface IOrcamentoComponenteRepository
    {
        void InserirLista(
            int idOrcamento,
            List<Componente> componentes,
            NpgsqlConnection conn,
            NpgsqlTransaction tran);
        void RemoverPorOrcamento(
            int idOrcamento,
            NpgsqlConnection conn,
            NpgsqlTransaction tran);
    }

    public interface IOrcamentoProcessoRepository
    {
        void InserirLista(
            int idOrcamento,
            List<Processo> processos,
            NpgsqlConnection conn,
            NpgsqlTransaction tran);
        void RemoverPorOrcamento(
            int idOrcamento,
            NpgsqlConnection conn,
            NpgsqlTransaction tran);
    }
}
