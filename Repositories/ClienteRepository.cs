using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using GaroliBudget.Models;
using Microsoft.Data.Sqlite;
using GaroliBudget.Infrastructure;
using GaroliBudget.Repositories.Interfaces;
using Npgsql;

namespace GaroliBudget.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public int Inserir(Cliente cliente)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO CLIENTE 
                (RAZAO_SOCIAL, NOME_FANTASIA, CNPJ, EMAIL, TELEFONE, ATIVO)
                VALUES 
                (@razao, @fantasia, @cnpj, @email, @telefone, 1);
                SELECT last_insert_rowid();
            ";

            cmd.Parameters.AddWithValue("@razao", cliente.RazaoSocial);
            cmd.Parameters.AddWithValue("@fantasia", cliente.NomeFantasia);
            cmd.Parameters.AddWithValue("@cnpj", cliente.Cnpj);
            cmd.Parameters.AddWithValue("@email", cliente.Email);
            cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);

            return System.Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Atualizar(Cliente cliente)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                UPDATE CLIENTE SET
                    RAZAO_SOCIAL = @razao,
                    NOME_FANTASIA = @fantasia,
                    CNPJ = @cnpj,
                    EMAIL = @email,
                    TELEFONE = @telefone,
                    ATIVO = @ativo
                WHERE ID_CLIENTE = @id;
            ";

            cmd.Parameters.AddWithValue("@razao", cliente.RazaoSocial);
            cmd.Parameters.AddWithValue("@fantasia", cliente.NomeFantasia);
            cmd.Parameters.AddWithValue("@cnpj", cliente.Cnpj);
            cmd.Parameters.AddWithValue("@email", cliente.Email);
            cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@ativo", cliente.Ativo ? 1 : 0);
            cmd.Parameters.AddWithValue("@id", cliente.IdCliente);

            cmd.ExecuteNonQuery();
        }

        public Cliente ObterPorId(int idCliente)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM CLIENTE WHERE ID_CLIENTE = @id;";
            cmd.Parameters.AddWithValue("@id", idCliente);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read()) return null;

            return Mapear(reader);
        }

        public List<Cliente> ListarAtivos()
        {
            return Listar("WHERE ATIVO = 1");
        }

        public List<Cliente> ListarTodos()
        {
            return Listar(string.Empty);
        }

        public List<Cliente> ListarWhere(string where)
        {
            return Listar(where);
        }

        public bool ExisteCnpj(string cnpj, int? ignorarId = null)
        {
            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var sql = "SELECT COUNT(1) FROM CLIENTE WHERE CNPJ = @cnpj";

            if (ignorarId.HasValue)
                sql += " AND ID_CLIENTE <> @id";

            var cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@cnpj", cnpj);

            if (ignorarId.HasValue)
                cmd.Parameters.AddWithValue("@id", ignorarId.Value);

            return System.Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        private List<Cliente> Listar(string where)
        {
            var lista = new List<Cliente>();

            using var conn = DBPostgres.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM CLIENTE {where};";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(Mapear(reader));
            }

            return lista;
        }

        private Cliente Mapear(NpgsqlDataReader reader)
        {
            return new Cliente
            {
                IdCliente = reader.GetInt32(reader.GetOrdinal("ID_CLIENTE")),
                RazaoSocial = reader["RAZAO_SOCIAL"].ToString(),
                NomeFantasia = reader["NOME_FANTASIA"].ToString(),
                Cnpj = reader["CNPJ"].ToString(),
                Email = reader["EMAIL"].ToString(),
                Telefone = reader["TELEFONE"].ToString(),
                Ativo = reader.GetInt32(reader.GetOrdinal("ATIVO")) == 1
            };
        }
    }

}
