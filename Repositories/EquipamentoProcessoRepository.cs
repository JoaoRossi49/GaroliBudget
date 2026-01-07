using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaroliBudget.Models;
using Npgsql;

namespace GaroliBudget.Repositories
{
    public class EquipamentoProcessoRepository
    {
        public void InserirLista(
            int idEquipamento,
            List<Processo> processos,
            NpgsqlConnection conn,
            NpgsqlTransaction tran)
        {
            if (processos != null)
            {
                foreach (var p in processos)
                {
                    var cmd = conn.CreateCommand();
                    cmd.Transaction = tran;
                    cmd.CommandText = @"
                INSERT INTO EQUIPAMENTO_MAO_OBRA
                (ID_EQUIPAMENTO, ID_MODULO, ID_PROCESSO, DESCRICAO_PROCESSO, HORAS_PADRAO)
                VALUES
                (@id, @mod, @mat, @descricao, @qtd)";

                    cmd.Parameters.AddWithValue("@id", idEquipamento);
                    cmd.Parameters.AddWithValue("@mod", p.Modulo.Id);
                    cmd.Parameters.AddWithValue("@idProcesso", p.IdProcesso);
                    cmd.Parameters.AddWithValue("@descricao", p.Descricao);
                    cmd.Parameters.AddWithValue("@qtd", p.Quantidade);

                    cmd.ExecuteNonQuery();
                }
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
                "DELETE FROM EQUIPAMENTO_MAO_OBRA WHERE ID_EQUIPAMENTO = @id";

            cmd.Parameters.AddWithValue("@id", idEquipamento);
            cmd.ExecuteNonQuery();
        }
    }
}
