using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaroliBudget.Models;
using Npgsql;

namespace GaroliBudget.Repositories.Interfaces
{
    public interface IEquipamentoService
    {
        int CriarEquipamento(Equipamento Equipamento);
        int Salvar(Equipamento Equipamento);
        void AtualizarEquipamento(Equipamento Equipamento);
        Equipamento ObterPorId(int idEquipamento);
        List<Equipamento> ListarAtivos();
        List<Equipamento> ListarTodos();
        List<Material> ListarMateriais(int idEquipamento, int idModulo);
        List<Processo> ListarProcessos(int idEquipamento, int idModulo);
        List<Componente> ListarComponentes(int idEquipamento, int idModulo);
    }

    public interface IEquipamentoRepository
    {
        int Inserir(Equipamento Equipamento);
        void Atualizar(Equipamento Equipamento);
        Equipamento ObterPorId(int idEquipamento);
        List<Equipamento> ListarAtivos();
        List<Equipamento> ListarTodos();
        List<Equipamento> ListarWhere(string where);

    }

    public interface IEquipamentoMaterialRepository
    {
        void InserirLista(
            int idEquipamento,
            List<Material> materiais,
            NpgsqlConnection conn,
            NpgsqlTransaction tran);
        void RemoverPorEquipamento(
            int idEquipamento,
            NpgsqlConnection conn,
            NpgsqlTransaction tran);
        List<Material> ListarPorEquipamentoId(int IdEquipamento);
    }

    public interface IEquipamentoComponenteRepository
    {
        void InserirLista(
            int idEquipamento,
            List<Componente> componentes,
            NpgsqlConnection conn,
            NpgsqlTransaction tran);
        void RemoverPorEquipamento(
            int idEquipamento,
            NpgsqlConnection conn,
            NpgsqlTransaction tran);
    }

    public interface IEquipamentoProcessoRepository
    {
        void InserirLista(
            int idEquipamento,
            List<Processo> processos,
            NpgsqlConnection conn,
            NpgsqlTransaction tran);
        void RemoverPorEquipamento(
            int idEquipamento,
            NpgsqlConnection conn,
            NpgsqlTransaction tran);
    }
}
