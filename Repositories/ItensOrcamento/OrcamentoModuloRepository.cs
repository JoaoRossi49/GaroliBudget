using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaroliBudget.Infrastructure;
using GaroliBudget.Models;
using Npgsql;

namespace GaroliBudget.Repositories.ItensOrcamento
{
    public class OrcamentoModuloRepository
    {
        public int Inserir(
            Modulo modulo,
            NpgsqlConnection conn,
            NpgsqlTransaction tran)
        {
            var cmd = conn.CreateCommand();
            cmd.Transaction = tran;

            cmd.CommandText = @"
            INSERT INTO ORCAMENTO_MODULO
            (ID_ORCAMENTO, NOME_MODULO, ORDEM)
            VALUES
            (@orca, @nome, @ordem)
            RETURNING ID_MODULO";

            cmd.Parameters.AddWithValue("@orca", modulo.IdOrcamento);
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
              FROM ORCAMENTO_MODULO WHERE ID_MODULO = @id;";

            cmd.Parameters.AddWithValue("@id", id);

            using var dr = cmd.ExecuteReader();
            if (!dr.Read()) return null;

            return Mapear(dr);
        }

        public List<Modulo> ObterPorOrcamentoId(int idOrcamento)
        {
            var lista = new List<Modulo>();

            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM ORCAMENTO_MODULO WHERE ID_ORCAMENTO = {idOrcamento};";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(Mapear(reader));
            }

            return lista;
        }

        public void RemoverPorId(
            int idModulo)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText =
                "DELETE FROM ORCAMENTO_MODULO WHERE ID_MODULO = @id";

            cmd.Parameters.AddWithValue("@id", idModulo);
            cmd.ExecuteNonQuery();
        }

        private Modulo Mapear(NpgsqlDataReader reader)
        {
            return new Modulo
            {
                Id = reader.GetInt32(reader.GetOrdinal("ID_MODULO")),
                IdOrcamento = reader.GetInt32(reader.GetOrdinal("ID_ORCAMENTO")),
                Nome = reader["NOME_MODULO"].ToString(),
                Ordem = Convert.ToInt32(reader["ORDEM"])
            };
        }

    }

}
