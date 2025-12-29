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
        void Inserir(Material Material);
        void Atualizar(Material Material);
        Material ObterPorId(int idMaterial);
        List<Material> ListarAtivos();
    }

    public interface IMaterialRepository
    {
        void Inserir(Material Material);
        void Atualizar(Material Material);
        Material ObterPorId(int idMaterial);
        List<Material> ListarAtivos();
    }
}
