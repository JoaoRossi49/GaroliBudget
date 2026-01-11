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
    public class EquipamentoModuloRepository
    {
        public int Inserir(
            Modulo modulo,
            NpgsqlConnection conn,
            NpgsqlTransaction tran)
        {
            var cmd = conn.CreateCommand();
            cmd.Transaction = tran;

            cmd.CommandText = @"
            INSERT INTO EQUIPAMENTO_MODULO
            (ID_EQUIPAMENTO, NOME_MODULO, ORDEM)
            VALUES
            (@equip, @nome, @ordem)
            RETURNING ID_MODULO";

            cmd.Parameters.AddWithValue("@equip", modulo.IdEquipamento);
            cmd.Parameters.AddWithValue("@nome", modulo.Nome);
            cmd.Parameters.AddWithValue("@ordem", modulo.Ordem);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public Modulo ObterPorId(int id)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText =
            @"SELECT *
              FROM EQUIPAMENTO_MODULO WHERE ID_MODULO = @id;";

            cmd.Parameters.AddWithValue("@id", id);

            using var dr = cmd.ExecuteReader();
            if (!dr.Read()) return null;

            return Mapear(dr);
        }

        public void RemoverPorId(
            int idModulo)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText =
                "DELETE FROM EQUIPAMENTO_MODULO WHERE ID_MODULO = @id";

            cmd.Parameters.AddWithValue("@id", idModulo);
            cmd.ExecuteNonQuery();
        }

        private Modulo Mapear(NpgsqlDataReader reader)
        {
            return new Modulo
            {
                Id = reader.GetInt32(reader.GetOrdinal("ID_MODULO")),
                IdEquipamento = reader.GetInt32(reader.GetOrdinal("ID_EQUIPAMENTO")),
                Nome = reader["NOME_MODULO"].ToString(),
                Ordem = Convert.ToInt32(reader["ORDEM"])
            };
        }

    }

}
