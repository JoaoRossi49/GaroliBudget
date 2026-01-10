using GaroliBudget.Models;
using Microsoft.Data.Sqlite;
using GaroliBudget.Infrastructure;
using Npgsql;
using GaroliBudget.Repositories.Interfaces;

namespace GaroliBudget.Repositories
{
    public class ProcessoRepository : IProcessoRepository
    {
        public int Inserir(Processo m)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO PROCESSO 
                (DESCRICAO, CUSTO_HORA, ATIVO)
                VALUES 
                (@descricao, @custo, 1)
                RETURNING ID_PROCESSO";

            cmd.Parameters.AddWithValue("@descricao", m.Descricao);
            cmd.Parameters.AddWithValue("@custo", m.CustoHora);

            return System.Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Atualizar(Processo m)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText = 
                @"UPDATE PROCESSO
              SET DESCRICAO = @descricao,
                  CUSTO_HORA = @custo,
                  ATIVO = @ativo
              WHERE ID_PROCESSO = @id;";

            cmd.Parameters.AddWithValue("@descricao", m.Descricao);
            cmd.Parameters.AddWithValue("@custo", m.CustoHora);
            cmd.Parameters.AddWithValue("@ativo", m.Ativo ? 1 : 0);
            cmd.Parameters.AddWithValue("@id", m.IdProcesso);

            cmd.ExecuteNonQuery();
        }

        public List<Processo> ListarAtivos()
        {
            return Listar("WHERE ATIVO = 1");
        }

        public List<Processo> ListarTodos()
        {
            return Listar(string.Empty);
        }

        public List<Processo> ListarWhere(string where)
        {
            return Listar(where);
        }

        private List<Processo> Listar(string where)
        {
            var lista = new List<Processo>();

            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM PROCESSO {where};";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(Mapear(reader));
            }

            return lista;
        }

        public Processo ObterPorId(int id)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText = 
            @"SELECT ID_PROCESSO, DESCRICAO, CUSTO_HORA, ATIVO
              FROM PROCESSO WHERE ID_PROCESSO = @id;";

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
                @"UPDATE PROCESSO SET ATIVO = 0 WHERE ID_PROCESSO = @id;";

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        private Processo Mapear(NpgsqlDataReader reader)
        {
            return new Processo
            {
                IdProcesso = reader.GetInt32(reader.GetOrdinal("ID_PROCESSO")),
                Descricao = reader["DESCRICAO"].ToString(),
                CustoHora = Convert.ToDecimal(reader["CUSTO_HORA"]),
                Ativo = reader.GetInt32(reader.GetOrdinal("ATIVO")) == 1
            };
        }
    }

}
