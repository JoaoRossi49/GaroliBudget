using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaroliBudget.Infrastructure;
using GaroliBudget.Models;
using GaroliBudget.Repositories.Interfaces;
using GaroliBudget.Services;
using Npgsql;

namespace GaroliBudget.Repositories.ItensOrcamento
{
    public class OrcamentoMaterialRepository : IOrcamentoMaterialRepository
    {
        private OrcamentoModuloRepository _moduloRepository  = new OrcamentoModuloRepository();

        private readonly IMaterialRepository _materialRepository = new MaterialRepository();

        public void InserirLista(
            int idEquipamento,
            List<Material> materiais,
            NpgsqlConnection conn,
            NpgsqlTransaction tran)
        {
            if (materiais != null)
            {
                foreach (var m in materiais)
                {
                    var cmd = conn.CreateCommand();
                    cmd.Transaction = tran;
                    cmd.CommandText = @"
                INSERT INTO ORCAMENTO_MATERIAL
                (ID_EQUIPAMENTO, ID_MODULO, ID_MATERIAL, DESCRICAO_MATERIAL, QUANTIDADE_PADRAO, UNIDADE)
                VALUES
                (@id, @mod, @idMaterial, @descricao, @qtd, @und)";

                    cmd.Parameters.AddWithValue("@id", idEquipamento);
                    cmd.Parameters.AddWithValue("@mod", m.Modulo.Id);
                    cmd.Parameters.AddWithValue("@idMaterial", m.IdMaterial);
                    cmd.Parameters.AddWithValue("@descricao", m.Descricao);
                    cmd.Parameters.AddWithValue("@qtd", m.Quantidade);
                    cmd.Parameters.AddWithValue("@und", m.Unidade);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void RemoverPorOrcamento(
            int idOrcamento,
            NpgsqlConnection conn,
            NpgsqlTransaction tran)
        {
            var cmd = conn.CreateCommand();
            cmd.Transaction = tran;
            cmd.CommandText =
                "DELETE FROM ORCAMENTO_MATERIAL WHERE ID_ORCAMENTO = @id";

            cmd.Parameters.AddWithValue("@id", idOrcamento);
            cmd.ExecuteNonQuery();
        }

        public List<Material> ListarPorOrcamentoId(int idOrcamento, int idModulo = 0)
        {
            var lista = new List<Material>();

            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM ORCAMENTO_MATERIAL WHERE ID_ORCAMENTO = {idOrcamento} " +
                (idModulo > 0 ? $"AND ID_MODULO = {idModulo};" : ";");

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(Mapear(reader));
            }

            return lista;
        }

        private Material Mapear(NpgsqlDataReader reader)
        {
            Material material = new Material();

            var idMaterial = reader.GetInt32(reader.GetOrdinal("ID_MATERIAL"));
            material = _materialRepository.ObterPorId(idMaterial);

            material.Quantidade = Convert.ToDecimal(reader["QUANTIDADE_PADRAO"]);

            var idModulo = reader.GetInt32(reader.GetOrdinal("ID_MODULO"));
            var modulo = _moduloRepository.ObterPorId(idModulo);

            material.Modulo = modulo ?? new Modulo
            {
                Id = 0,
                Nome = "Módulo Não Identificado"
            };

            return material;
        }
    }
}
