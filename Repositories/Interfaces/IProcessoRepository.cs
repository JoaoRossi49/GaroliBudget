using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaroliBudget.Models;

namespace GaroliBudget.Repositories.Interfaces
{
    public interface IProcessoService
    {
        int CriarProcesso(Processo Processo);
        void AtualizarProcesso(Processo Processo);
        Processo ObterPorId(int idProcesso);
        List<Processo> ListarAtivos();
        List<Processo> ListarTodos();
    }

    public interface IProcessoRepository
    {
        int Inserir(Processo Processo);
        void Atualizar(Processo Processo);
        Processo ObterPorId(int idProcesso);
        List<Processo> ListarAtivos();
        List<Processo> ListarTodos();
        List<Processo> ListarWhere(string where);

    }
}
