using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaroliBudget.Models;

namespace GaroliBudget.Repositories.Interfaces
{
    public interface IComponenteService
    {
        int CriarComponente(Componente Componente);
        void AtualizarComponente(Componente Componente);
        Componente ObterPorId(int idComponente);
        List<Componente> ListarAtivos();
        List<Componente> ListarTodos();
    }

    public interface IComponenteRepository
    {
        int Inserir(Componente Componente);
        void Atualizar(Componente Componente);
        Componente ObterPorId(int idComponente);
        List<Componente> ListarAtivos();
        List<Componente> ListarTodos();
        List<Componente> ListarWhere(string where);

    }
}
