using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaroliBudget.Infrastructure;
using GaroliBudget.Models;
using Npgsql;

namespace GaroliBudget.Repositories
{
    public class EquipamentoMaterialRepository
    {
        private readonly EquipamentoModuloRepository _moduloRepository;

        public void InserirLista(
            int idEquipamento,
            List<Material> materiais,
            NpgsqlConnection conn,
            NpgsqlTransaction tran)
        {
            foreach (var m in materiais)
            {
                var cmd = conn.CreateCommand();
                cmd.Transaction = tran;
                cmd.CommandText = @"
                INSERT INTO EQUIPAMENTO_MATERIAL
                (ID_EQUIPAMENTO, ID_MODULO, ID_MATERIAL, DESCRICAO_MATERIAL, QUANTIDADE_PADRAO)
                VALUES
                (@id, @mod, @mat, @descricao, @qtd)";

                cmd.Parameters.AddWithValue("@id", idEquipamento);
                cmd.Parameters.AddWithValue("@mod", m.Modulo.Id);
                cmd.Parameters.AddWithValue("@idMaterial", m.IdMaterial);
                cmd.Parameters.AddWithValue("@descricao", m.Descricao);
                cmd.Parameters.AddWithValue("@qtd", m.Quantidade);

                cmd.ExecuteNonQuery();
            }
        }

        public void RemoverPorEquipamento(
            int idEquipamento,
            NpgsqlConnection conn,
            NpgsqlTransaction tran)
        {
            var cmd = conn.CreateCommand();
            cmd.Transaction = tran;
            cmd.CommandText =
                "DELETE FROM EQUIPAMENTO_MATERIAL WHERE ID_EQUIPAMENTO = @id";

            cmd.Parameters.AddWithValue("@id", idEquipamento);
            cmd.ExecuteNonQuery();
        }

        private List<Material> ListarPorEquipamentoId(int IdEquipamento)
        {
            var lista = new List<Material>();

            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM EQUIPAMENTO_MATERIAL WHERE ID_EQUIPAMENTO = {IdEquipamento};";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(Mapear(reader));
            }

            return lista;
        }

        private Material Mapear(NpgsqlDataReader reader)
        {
            return new Material
            {
                IdMaterial = reader.GetInt32(reader.GetOrdinal("ID_MATERIAL")),
                Descricao = reader["DESCRICAO_MATERIAL"].ToString(),
                Unidade = reader["UNIDADE"].ToString(),
                CustoUnitario = Convert.ToDecimal(reader["CUSTO_UNITARIO"]),
                Quantidade = Convert.ToDecimal(reader["QUANTIDADE_PADRAO"]),
                Ativo = reader.GetInt32(reader.GetOrdinal("ATIVO")) == 1,
                Modulo = _moduloRepository.ObterPorId(reader.GetInt32(reader.GetOrdinal("ID_MODULO")))
            };
        }
    }
}
