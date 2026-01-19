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
    public class OrcamentoComponenteRepository : IOrcamentoComponenteRepository
    {
        private OrcamentoModuloRepository _moduloRepository = new OrcamentoModuloRepository();

        private readonly IComponenteRepository _componenteRepository = new ComponenteRepository();

        public void InserirLista(
            int idOrcamento,
            List<Componente> componentes,
            NpgsqlConnection conn,
            NpgsqlTransaction tran)
        {
            if (componentes != null)
            {
                foreach (var c in componentes)
                {
                    var cmd = conn.CreateCommand();
                    cmd.Transaction = tran;
                    cmd.CommandText = @"
                INSERT INTO ORCAMENTO_COMPONENTE
                (ID_ORCAMENTO, ID_MODULO, ID_COMPONENTE, DESCRICAO, QUANTIDADE, CUSTO_UNITARIO, CUSTO_TOTAL)
                VALUES
                (@id, @mod, @idComponente, @descricao, @qtd, @unit, @total)";

                    cmd.Parameters.AddWithValue("@id", idOrcamento);
                    cmd.Parameters.AddWithValue("@mod", c.Modulo.Id);
                    cmd.Parameters.AddWithValue("@idComponente", c.IdComponente);
                    cmd.Parameters.AddWithValue("@descricao", c.Descricao);
                    cmd.Parameters.AddWithValue("@qtd", c.Quantidade);
                    cmd.Parameters.AddWithValue("@unit", c.CustoUnitario);
                    cmd.Parameters.AddWithValue("@total", c.Total);

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
                "DELETE FROM ORCAMENTO_COMPONENTE WHERE ID_ORCAMENTO = @id";

            cmd.Parameters.AddWithValue("@id", idOrcamento);
            cmd.ExecuteNonQuery();
        }

        public List<Componente> ListarPorOrcamentoId(int idOrcamento, int idModulo = 0)
        {
            var lista = new List<Componente>();

            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM ORCAMENTO_COMPONENTE WHERE ID_ORCAMENTO = {idOrcamento} " +
                (idModulo > 0 ? $"AND ID_MODULO = {idModulo};" : ";");

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(Mapear(reader));
            }

            return lista;
        }

        private Componente Mapear(NpgsqlDataReader reader)
        {
            Componente componente = new Componente();

            var idComponente = reader.GetInt32(reader.GetOrdinal("ID_COMPONENTE"));
            componente = _componenteRepository.ObterPorId(idComponente);

            componente.Quantidade = Convert.ToInt32(reader["QUANTIDADE_PADRAO"]);

            var idModulo = reader.GetInt32(reader.GetOrdinal("ID_MODULO"));
            var modulo = _moduloRepository.ObterPorId(idModulo);

            componente.Modulo = modulo ?? new Modulo
            {
                Id = 0,
                Nome = "Módulo Não Identificado"
            };

            return componente;
        }
    }
}
