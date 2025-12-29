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
    public class MaterialService : IMaterialService
    {
        private readonly IMaterialRepository _materialRepository;

        public MaterialService(IMaterialRepository materialRepository)
        {
            _materialRepository = materialRepository;
        }

        public void Inserir(Material material)
        {
            material.Ativo = true;
        }

        public void Atualizar(Material material)
        {
            if (material.Id <= 0)
                throw new Exception("Material inválido.");

            _materialRepository.Atualizar(material);
        }

        public Material ObterPorId(int idMaterial)
        {
            if (idMaterial <= 0)
                throw new Exception("ID do material inválido.");

            return _materialRepository.ObterPorId(idMaterial);
        }

        public List<Material> ListarAtivos()
        {
            return _materialRepository.ListarAtivos();
        }

        public void InativarMaterial(int idMaterial)
        {
            var material = ObterPorId(idMaterial);

            if (material == null)
                throw new Exception("Material não encontrado.");

            material.Ativo = false;
            _materialRepository.Atualizar(material);
        }

    }

}
