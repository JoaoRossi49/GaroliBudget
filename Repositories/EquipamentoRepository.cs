using GaroliBudget.Models;
using Microsoft.Data.Sqlite;
using GaroliBudget.Infrastructure;
using Npgsql;
using GaroliBudget.Repositories.Interfaces;

namespace GaroliBudget.Repositories
{
    public class EquipamentoRepository : IEquipamentoRepository
    {
        public int Inserir(Equipamento m)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO EQUIPAMENTO 
                (CODIGO, DESCRICAO, OBSERVACOES, ATIVO)
                VALUES 
                (@codigo, @descricao, @observacao, 1)
                RETURNING ID_EQUIPAMENTO";

            cmd.Parameters.AddWithValue("@codigo", m.Codigo);
            cmd.Parameters.AddWithValue("@descricao", m.Descricao);
            cmd.Parameters.AddWithValue("@observacao", m.Observacao == null ? "" : m.Observacao);

            return System.Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Atualizar(Equipamento m)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText =
                @"UPDATE EQUIPAMENTO
              SET CODIGO = @codigo,
                  DESCRICAO = @descricao,
                  OBSERVACOES = @observacao,
                  ATIVO = @ativo
              WHERE ID_MATERIAL = @id;";

            cmd.Parameters.AddWithValue("@codigo", m.Codigo);
            cmd.Parameters.AddWithValue("@descricao", m.Descricao);
            cmd.Parameters.AddWithValue("@observacao", m.Observacao);
            cmd.Parameters.AddWithValue("@ativo", m.Ativo ? 1 : 0);
            cmd.Parameters.AddWithValue("@id", m.IdEquipamento);

            cmd.ExecuteNonQuery();
        }

        public List<Equipamento> ListarAtivos()
        {
            return Listar("WHERE ATIVO = 1");
        }

        public List<Equipamento> ListarTodos()
        {
            return Listar(string.Empty);
        }

        public List<Equipamento> ListarWhere(string where)
        {
            return Listar(where);
        }

        private List<Equipamento> Listar(string where)
        {
            var lista = new List<Equipamento>();

            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM EQUIPAMENTO {where};";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(Mapear(reader));
            }

            return lista;
        }

        public Equipamento ObterPorId(int id)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText =
            @"SELECT *
              FROM EQUIPAMENTO WHERE ID_EQUIPAMENTO = @id;";

            cmd.Parameters.AddWithValue("@id", id);

            using var dr = cmd.ExecuteReader();
            if (!dr.Read()) return null;

            return Mapear(dr);
        }

        public void Inativar(int id)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText =
                @"UPDATE EQUIPAMENTO SET ATIVO = 0 WHERE ID_EQUIPAMENTO = @id;";

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        private Equipamento Mapear(NpgsqlDataReader reader)
        {
            return new Equipamento
            {
                IdEquipamento = reader.GetInt32(reader.GetOrdinal("ID_EQUIPAMENTO")),
                Codigo = reader["CODIGO"].ToString(),
                Descricao = reader["DESCRICAO"].ToString(),
                Observacao = reader["OBSERVACOES"].ToString(),
                Ativo = reader.GetInt32(reader.GetOrdinal("ATIVO")) == 1
            };
        }
    }

}
