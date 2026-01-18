using GaroliBudget.Models;
using Microsoft.Data.Sqlite;
using GaroliBudget.Infrastructure;
using Npgsql;
using GaroliBudget.Repositories.Interfaces;

namespace GaroliBudget.Repositories
{
    public class OrcamentoRepository : IOrcamentoRepository
    {
        public int Inserir(Orcamento m)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO ORCAMENTO 
                (NUMERO, DATA_ORCAMENTO, ID_CLIENTE, ID_EQUIPAMENTO, DESCRICAO, MARGEM_CONTRIBUICAO,
                VALOR_TOTAL, STATUS, OBSERVACOES)
                VALUES 
                (@numero, @dat, @cliente, @eq, @descricao, @margem, @total, @status, @observacao)
                RETURNING ID_EQUIPAMENTO";

            cmd.Parameters.AddWithValue("@numero", m.Numero);
            cmd.Parameters.AddWithValue("@dat", m.Data);
            cmd.Parameters.AddWithValue("@cliente", m.cliente.IdCliente);
            cmd.Parameters.AddWithValue("@eq", m.equipamento.IdEquipamento);
            cmd.Parameters.AddWithValue("@descricao", m.Descricao);
            cmd.Parameters.AddWithValue("@margem", m.MargemContribuicao);
            cmd.Parameters.AddWithValue("@total", m.ValorTotal);
            cmd.Parameters.AddWithValue("@status", m.Status);
            cmd.Parameters.AddWithValue("@observacao", m.Observacao);

            return System.Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Atualizar(Orcamento m)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText =
                @"UPDATE ORCAMENTO
                SET NUMERO = @numero,
                    DATA_ORCAMENTO = @dat,
                    ID_CLIENTE = @cliente, 
                    ID_EQUIPAMENTO = @eq, 
                    DESCRICAO = @descricao, 
                    MARGEM_CONTRIBUICAO = @margem,
                    VALOR_TOTAL = total, 
                    STATUS = @status, 
                    OBSERVACOES = @observacao
              WHERE ID_ORCAMENTO = @id;";

            cmd.Parameters.AddWithValue("@numero", m.Numero);
            cmd.Parameters.AddWithValue("@dat", m.Data);
            cmd.Parameters.AddWithValue("@cliente", m.cliente.IdCliente);
            cmd.Parameters.AddWithValue("@eq", m.equipamento.IdEquipamento);
            cmd.Parameters.AddWithValue("@descricao", m.Descricao);
            cmd.Parameters.AddWithValue("@margem", m.MargemContribuicao);
            cmd.Parameters.AddWithValue("@total", m.ValorTotal);
            cmd.Parameters.AddWithValue("@status", m.Status);
            cmd.Parameters.AddWithValue("@observacao", m.Observacao);

            cmd.Parameters.AddWithValue("@id", m.IdOrcamento);

            cmd.ExecuteNonQuery();
        }

        public List<Orcamento> ListarTodos()
        {
            return Listar(string.Empty);
        }

        public List<Orcamento> ListarWhere(string where)
        {
            return Listar(where);
        }

        private List<Orcamento> Listar(string where)
        {
            var lista = new List<Orcamento>();

            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM ORCAMENTO {where};";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(Mapear(reader));
            }

            return lista;
        }

        public Orcamento ObterPorId(int id)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText =
            @"SELECT *
              FROM ORCAMENTO WHERE ID_ORCAMENTO = @id;";

            cmd.Parameters.AddWithValue("@id", id);

            using var dr = cmd.ExecuteReader();
            if (!dr.Read()) return null;

            return Mapear(dr);
        }

        private Orcamento Mapear(NpgsqlDataReader reader)
        {
            return new Orcamento
            {
                IdOrcamento = reader.GetInt32(reader.GetOrdinal("ID_EQUIPAMENTO")),
                Numero = reader["CODIGO"].ToString(),
                //Descricao = reader["DESCRICAO"].ToString(),
                Observacao = reader["OBSERVACOES"].ToString(),
                Ativo = reader.GetInt32(reader.GetOrdinal("ATIVO")) == 1
            };
        }
    }

}
