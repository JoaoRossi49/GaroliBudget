using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaroliBudget.Infrastructure;
using GaroliBudget.Models;
using GaroliBudget.Repositories.Interfaces;
using Npgsql;

namespace GaroliBudget.Repositories
{
    public class EquipamentoProcessoRepository
    {
        private EquipamentoModuloRepository _moduloRepository = new EquipamentoModuloRepository();

        private readonly IProcessoRepository _processoRepository = new ProcessoRepository();

        public void InserirLista(
            int idEquipamento,
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
                INSERT INTO EQUIPAMENTO_MAO_OBRA
                (ID_EQUIPAMENTO, ID_MODULO, ID_PROCESSO, DESCRICAO_PROCESSO, HORAS_PADRAO)
                VALUES
                (@id, @mod, @idProcesso, @descricao, @qtd)";

                    cmd.Parameters.AddWithValue("@id", idEquipamento);
                    cmd.Parameters.AddWithValue("@mod", p.Modulo.Id);
                    cmd.Parameters.AddWithValue("@idProcesso", p.IdProcesso);
                    cmd.Parameters.AddWithValue("@descricao", p.Descricao);
                    cmd.Parameters.AddWithValue("@qtd", p.Quantidade);

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
                "DELETE FROM EQUIPAMENTO_MAO_OBRA WHERE ID_EQUIPAMENTO = @id";

            cmd.Parameters.AddWithValue("@id", idEquipamento);
            cmd.ExecuteNonQuery();
        }


        public List<Processo> ListarPorEquipamentoId(int IdEquipamento, int idModulo = 0)
        {
            var lista = new List<Processo>();

            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM EQUIPAMENTO_MAO_OBRA WHERE ID_EQUIPAMENTO = {IdEquipamento} " +
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
