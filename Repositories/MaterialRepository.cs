using GaroliBudget.Models;
using Microsoft.Data.Sqlite;
using GaroliBudget.Infrastructure;
using Npgsql;
using GaroliBudget.Repositories.Interfaces;

namespace GaroliBudget.Repositories
{
    public class MaterialRepository : IMaterialRepository
    {
        public List<Material> ListarAtivos()
        {
            var lista = new List<Material>();

            using var conn = DBPostgres.GetConnection();
            using var cmd = new NpgsqlCommand(
                @"SELECT ID_MATERIAL, CODIGO, DESCRICAO, UNIDADE, CUSTO_UNITARIO, ATIVO
              FROM MATERIAL
              WHERE ATIVO = 1
              ORDER BY DESCRICAO", conn);

            using var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Material
                {
                    Id = dr.GetInt32(0),
                    Codigo = dr.GetString(1),
                    Descricao = dr.GetString(2),
                    Unidade = dr.GetString(3),
                    CustoUnitario = dr.GetDecimal(4),
                    Ativo = dr.GetInt32(5) == 1
                });
            }
            return lista;
        }

        public Material ObterPorId(int id)
        {
            using var conn = DBPostgres.GetConnection();
            using var cmd = new NpgsqlCommand(
                @"SELECT ID_MATERIAL, CODIGO, DESCRICAO, UNIDADE, CUSTO_UNITARIO, ATIVO
              FROM MATERIAL WHERE ID_MATERIAL = @id", conn);

            cmd.Parameters.AddWithValue("@id", id);

            using var dr = cmd.ExecuteReader();
            if (!dr.Read()) return null;

            return new Material
            {
                Id = dr.GetInt32(0),
                Codigo = dr.GetString(1),
                Descricao = dr.GetString(2),
                Unidade = dr.GetString(3),
                CustoUnitario = dr.GetDecimal(4),
                Ativo = dr.GetInt32(5) == 1
            };
        }

        public void Inserir(Material m)
        {
            using var conn = DBPostgres.GetConnection();
            using var cmd = new NpgsqlCommand(
                @"INSERT INTO MATERIAL (CODIGO, DESCRICAO, UNIDADE, CUSTO_UNITARIO, ATIVO)
              VALUES (@codigo, @descricao, @unidade, @custo, 1)", conn);

            cmd.Parameters.AddWithValue("@codigo", m.Codigo);
            cmd.Parameters.AddWithValue("@descricao", m.Descricao);
            cmd.Parameters.AddWithValue("@unidade", m.Unidade);
            cmd.Parameters.AddWithValue("@custo", m.CustoUnitario);

            cmd.ExecuteNonQuery();
        }

        public void Atualizar(Material m)
        {
            using var conn = DBPostgres.GetConnection();
            using var cmd = new NpgsqlCommand(
                @"UPDATE MATERIAL
              SET CODIGO = @codigo,
                  DESCRICAO = @descricao,
                  UNIDADE = @unidade,
                  CUSTO_UNITARIO = @custo
              WHERE ID_MATERIAL = @id", conn);

            cmd.Parameters.AddWithValue("@codigo", m.Codigo);
            cmd.Parameters.AddWithValue("@descricao", m.Descricao);
            cmd.Parameters.AddWithValue("@unidade", m.Unidade);
            cmd.Parameters.AddWithValue("@custo", m.CustoUnitario);
            cmd.Parameters.AddWithValue("@id", m.Id);

            cmd.ExecuteNonQuery();
        }

        public void Inativar(int id)
        {
            using var conn = DBPostgres.GetConnection();
            using var cmd = new NpgsqlCommand(
                @"UPDATE MATERIAL SET ATIVO = 0 WHERE ID_MATERIAL = @id", conn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }

}
