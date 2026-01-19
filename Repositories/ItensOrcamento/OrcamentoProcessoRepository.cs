using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaroliBudget.Infrastructure;
using GaroliBudget.Models;
using GaroliBudget.Repositories.Interfaces;
using Npgsql;

namespace GaroliBudget.Repositories.ItensOrcamento
{
    public class OrcamentoProcessoRepository
    {
        private OrcamentoModuloRepository _moduloRepository = new OrcamentoModuloRepository();

        private readonly IProcessoRepository _processoRepository = new ProcessoRepository();

        public void InserirLista(
            int idOrcamento,
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
                INSERT INTO ORCAMENTO_MAO_OBRA
                (ID_ORCAMENTO, ID_MODULO, ID_PROCESSO, DESCRICAO, HORAS, CUSTO_HORA, CUSTO_TOTAL)
                VALUES
                (@id, @mod, @idProcesso, @descricao, @qtd, @unit, @total)";

                    cmd.Parameters.AddWithValue("@id", idOrcamento);
                    cmd.Parameters.AddWithValue("@mod", p.Modulo.Id);
                    cmd.Parameters.AddWithValue("@idProcesso", p.IdProcesso);
                    cmd.Parameters.AddWithValue("@descricao", p.Descricao);
                    cmd.Parameters.AddWithValue("@qtd", p.Quantidade);
                    cmd.Parameters.AddWithValue("@unit", p.CustoHora);
                    cmd.Parameters.AddWithValue("@total", p.Total);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void RemoverPorOrcamento(
            int idOrcamento,
            NpgsqlConnection conn,
            NpgsqlTransaction tran)
        {
            var cmd = conn.CreateCommand();
            cmd.Transaction = tran;
            cmd.CommandText =
                "DELETE FROM ORCAMENTO_MAO_OBRA WHERE ID_ORCAMENTO = @id";

            cmd.Parameters.AddWithValue("@id", idOrcamento);
            cmd.ExecuteNonQuery();
        }


        public List<Processo> ListarPorOrcamentoId(int IdOrcamento, int idModulo = 0)
        {
            var lista = new List<Processo>();

            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM ORCAMENTO_MAO_OBRA WHERE ID_ORCAMENTO = {IdOrcamento} " +
                (idModulo > 0 ? $"AND ID_MODULO = {idModulo};" : ";");

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(Mapear(reader));
            }

            return lista;
        }

        private Processo Mapear(NpgsqlDataReader reader)
        {
            Processo processo = new Processo();

            var idProcesso = reader.GetInt32(reader.GetOrdinal("ID_PROCESSO"));
            processo = _processoRepository.ObterPorId(idProcesso);

            processo.Quantidade = Convert.ToInt32(reader["HORAS_PADRAO"]);

            var idModulo = reader.GetInt32(reader.GetOrdinal("ID_MODULO"));
            var modulo = _moduloRepository.ObterPorId(idModulo);

            processo.Modulo = modulo ?? new Modulo
            {
                Id = 0,
                Nome = "Módulo Não Identificado"
            };

            return processo;
        }
    }
}
