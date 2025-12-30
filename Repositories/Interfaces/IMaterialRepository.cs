using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaroliBudget.Models;

namespace GaroliBudget.Repositories.Interfaces
{
    public interface IMaterialService
    {
        int CriarMaterial(Material Material);
        void AtualizarMaterial(Material Material);
        Material ObterPorId(int idMaterial);
        List<Material> ListarAtivos();
        List<Material> ListarTodos();
    }

    public interface IMaterialRepository
    {
        int Inserir(Material Material);
        void Atualizar(Material Material);
        Material ObterPorId(int idMaterial);
        List<Material> ListarAtivos();
        List<Material> ListarTodos();
        List<Material> ListarWhere(string where);

    }
}
