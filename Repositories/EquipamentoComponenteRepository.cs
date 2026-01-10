using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaroliBudget.Models;
using GaroliBudget.Repositories.Interfaces;
using Npgsql;

namespace GaroliBudget.Repositories
{
    public class EquipamentoComponenteRepository : IEquipamentoComponenteRepository
    {
        public void InserirLista(
            int idEquipamento,
            List<Componente> componentes,
            NpgsqlConnection conn,
            NpgsqlTransaction tran)
        {
            if (componentes != null)
            {
                foreach (var c in componentes)
                {
                    var cmd = conn.CreateCommand();
                    cmd.Transaction = tran;
                    cmd.CommandText = @"
                INSERT INTO EQUIPAMENTO_COMPONENTE
                (ID_EQUIPAMENTO, ID_MODULO, ID_COMPONENTE, DESCRICAO_COMPONENTE, QUANTIDADE_PADRAO)
                VALUES
                (@id, @mod, @idComponente, @descricao, @qtd)";

                    cmd.Parameters.AddWithValue("@id", idEquipamento);
                    cmd.Parameters.AddWithValue("@mod", c.Modulo.Id);
                    cmd.Parameters.AddWithValue("@idComponente", c.IdComponente);
                    cmd.Parameters.AddWithValue("@descricao", c.Descricao);
                    cmd.Parameters.AddWithValue("@qtd", c.Quantidade);

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
                "DELETE FROM EQUIPAMENTO_COMPONENTE WHERE ID_EQUIPAMENTO = @id";

            cmd.Parameters.AddWithValue("@id", idEquipamento);
            cmd.ExecuteNonQuery();
        }
    }
}
