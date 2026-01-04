using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaroliBudget.Models;
using Npgsql;

namespace GaroliBudget.Repositories
{
    public class EquipamentoModuloRepository
    {
        public int Inserir(
            Modulo modulo,
            NpgsqlConnection conn,
            NpgsqlTransaction tran)
        {
            var cmd = conn.CreateCommand();
            cmd.Transaction = tran;

            cmd.CommandText = @"
            INSERT INTO EQUIPAMENTO_MODULO
            (ID_EQUIPAMENTO, NOME_MODULO, ORDEM)
            VALUES
            (@equip, @nome, @ordem)
            RETURNING ID_MODULO";

            cmd.Parameters.AddWithValue("@equip", modulo.IdEquipamento);
            cmd.Parameters.AddWithValue("@nome", modulo.Nome);
            cmd.Parameters.AddWithValue("@ordem", modulo.Ordem);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }

}
