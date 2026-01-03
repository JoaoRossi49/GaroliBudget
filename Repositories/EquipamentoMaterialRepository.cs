using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaroliBudget.Models;
using Npgsql;

namespace GaroliBudget.Repositories
{
    public class EquipamentoMaterialRepository
    {
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
    }
}
