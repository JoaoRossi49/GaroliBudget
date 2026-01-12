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
    public class EquipamentoComponenteRepository : IEquipamentoComponenteRepository
    {
        private EquipamentoModuloRepository _moduloRepository = new EquipamentoModuloRepository();

        private readonly IComponenteRepository _componenteRepository = new ComponenteRepository();

        public void InserirLista(
            int idEquipamento,
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
                INSERT INTO EQUIPAMENTO_COMPONENTE
                (ID_EQUIPAMENTO, ID_MODULO, ID_COMPONENTE, DESCRICAO_COMPONENTE, QUANTIDADE_PADRAO)
                VALUES
                (@id, @mod, @idComponente, @descricao, @qtd)";

                    cmd.Parameters.AddWithValue("@id", idEquipamento);
                    cmd.Parameters.AddWithValue("@mod", c.Modulo.Id);
                    cmd.Parameters.AddWithValue("@idComponente", c.IdComponente);
                    cmd.Parameters.AddWithValue("@descricao", c.Descricao);
                    cmd.Parameters.AddWithValue("@qtd", c.Quantidade);

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
                "DELETE FROM EQUIPAMENTO_COMPONENTE WHERE ID_EQUIPAMENTO = @id";

            cmd.Parameters.AddWithValue("@id", idEquipamento);
            cmd.ExecuteNonQuery();
        }

        public List<Componente> ListarPorEquipamentoId(int IdEquipamento, int idModulo = 0)
        {
            var lista = new List<Componente>();

            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM EQUIPAMENTO_COMPONENTE WHERE ID_EQUIPAMENTO = {IdEquipamento} " +
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
