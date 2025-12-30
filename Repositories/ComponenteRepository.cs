using GaroliBudget.Models;
using Microsoft.Data.Sqlite;
using GaroliBudget.Infrastructure;
using Npgsql;
using GaroliBudget.Repositories.Interfaces;

namespace GaroliBudget.Repositories
{
    public class ComponenteRepository : IComponenteRepository
    {
        public int Inserir(Componente m)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO COMPONENTE 
                (CODIGO, DESCRICAO, CUSTO_UNITARIO, ATIVO)
                VALUES 
                (@codigo, @descricao, @custo, 1)
                RETURNING ID_COMPONENTE";

            cmd.Parameters.AddWithValue("@codigo", m.Codigo);
            cmd.Parameters.AddWithValue("@descricao", m.Descricao);
            cmd.Parameters.AddWithValue("@custo", m.CustoUnitario);

            return System.Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Atualizar(Componente m)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText = 
                @"UPDATE COMPONENTE
              SET CODIGO = @codigo,
                  DESCRICAO = @descricao,
                  CUSTO_UNITARIO = @custo,
                  ATIVO = @ativo
              WHERE ID_COMPONENTE = @id;";

            cmd.Parameters.AddWithValue("@codigo", m.Codigo);
            cmd.Parameters.AddWithValue("@descricao", m.Descricao);
            cmd.Parameters.AddWithValue("@custo", m.CustoUnitario);
            cmd.Parameters.AddWithValue("@ativo", m.Ativo ? 1 : 0);
            cmd.Parameters.AddWithValue("@id", m.IdComponente);

            cmd.ExecuteNonQuery();
        }

        public List<Componente> ListarAtivos()
        {
            return Listar("WHERE ATIVO = 1");
        }

        public List<Componente> ListarTodos()
        {
            return Listar(string.Empty);
        }

        public List<Componente> ListarWhere(string where)
        {
            return Listar(where);
        }

        private List<Componente> Listar(string where)
        {
            var lista = new List<Componente>();

            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM COMPONENTE {where};";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(Mapear(reader));
            }

            return lista;
        }

        public Componente ObterPorId(int id)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText = 
            @"SELECT ID_COMPONENTE, CODIGO, DESCRICAO, UNIDADE, CUSTO_UNITARIO, ATIVO
              FROM COMPONENTE WHERE ID_COMPONENTE = @id;";

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
                @"UPDATE COMPONENTE SET ATIVO = 0 WHERE ID_COMPONENTE = @id;";

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        private Componente Mapear(NpgsqlDataReader reader)
        {
            return new Componente
            {
                IdComponente = reader.GetInt32(reader.GetOrdinal("ID_COMPONENTE")),
                Codigo = reader["CODIGO"].ToString(),
                Descricao = reader["DESCRICAO"].ToString(),
                CustoUnitario = Convert.ToInt32(reader["CUSTO_UNITARIO"]),
                Ativo = reader.GetInt32(reader.GetOrdinal("ATIVO")) == 1
            };
        }
    }

}
