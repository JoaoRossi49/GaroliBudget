using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaroliBudget.Models;

namespace GaroliBudget.Repositories.Interfaces
{
    public interface IEquipamentoService
    {
        int CriarEquipamento(Equipamento Equipamento);
        void AtualizarEquipamento(Equipamento Equipamento);
        Equipamento ObterPorId(int idEquipamento);
        List<Equipamento> ListarAtivos();
        List<Equipamento> ListarTodos();
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
}
