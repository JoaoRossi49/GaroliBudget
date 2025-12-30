using GaroliBudget.Models;
using Microsoft.Data.Sqlite;
using GaroliBudget.Infrastructure;
using Npgsql;
using GaroliBudget.Repositories.Interfaces;

namespace GaroliBudget.Repositories
{
    public class MaterialRepository : IMaterialRepository
    {
        public int Inserir(Material m)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO MATERIAL 
                (CODIGO, DESCRICAO, UNIDADE, CUSTO_UNITARIO, ATIVO)
                VALUES 
                (@codigo, @descricao, @unidade, @custo, 1)
                RETURNING ID_MATERIAL";

            cmd.Parameters.AddWithValue("@codigo", m.Codigo);
            cmd.Parameters.AddWithValue("@descricao", m.Descricao);
            cmd.Parameters.AddWithValue("@unidade", m.Unidade);
            cmd.Parameters.AddWithValue("@custo", m.CustoUnitario);

            return System.Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Atualizar(Material m)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText = 
                @"UPDATE MATERIAL
              SET CODIGO = @codigo,
                  DESCRICAO = @descricao,
                  UNIDADE = @unidade,
                  CUSTO_UNITARIO = @custo
              WHERE ID_MATERIAL = @id;";

            cmd.Parameters.AddWithValue("@codigo", m.Codigo);
            cmd.Parameters.AddWithValue("@descricao", m.Descricao);
            cmd.Parameters.AddWithValue("@unidade", m.Unidade);
            cmd.Parameters.AddWithValue("@custo", m.CustoUnitario);
            cmd.Parameters.AddWithValue("@id", m.IdMaterial);

            cmd.ExecuteNonQuery();
        }

        public List<Material> ListarAtivos()
        {
            return Listar("WHERE ATIVO = 1");
        }

        public List<Material> ListarTodos()
        {
            return Listar(string.Empty);
        }

        public List<Material> ListarWhere(string where)
        {
            return Listar(where);
        }

        private List<Material> Listar(string where)
        {
            var lista = new List<Material>();

            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM MATERIAL {where};";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(Mapear(reader));
            }

            return lista;
        }

        public Material ObterPorId(int id)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText = 
            @"SELECT ID_MATERIAL, CODIGO, DESCRICAO, UNIDADE, CUSTO_UNITARIO, ATIVO
              FROM MATERIAL WHERE ID_MATERIAL = @id;";

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
                @"UPDATE MATERIAL SET ATIVO = 0 WHERE ID_MATERIAL = @id;";

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        private Material Mapear(NpgsqlDataReader reader)
        {
            return new Material
            {
                IdMaterial = reader.GetInt32(reader.GetOrdinal("ID_MATERIAL")),
                Codigo = reader["CODIGO"].ToString(),
                Descricao = reader["DESCRICAO"].ToString(),
                Unidade = reader["UNIDADE"].ToString(),
                CustoUnitario = Convert.ToInt32(reader["CUSTO_UNITARIO"]),
                Ativo = reader.GetInt32(reader.GetOrdinal("ATIVO")) == 1
            };
        }
    }

}
