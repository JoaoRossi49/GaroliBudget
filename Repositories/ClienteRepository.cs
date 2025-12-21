using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using GaroliBudget.Models;
using Microsoft.Data.Sqlite;
using GaroliBudget.Infrastructure;

namespace GaroliBudget.Repositories
{ 
    public class ClienteRepository : DBSqLite
    {
        public List<Cliente> ListarAtivos()
        {
            var lista = new List<Cliente>();

            using var conn = GetConnection();
            using var cmd = new SqliteCommand(
                @"SELECT ID_CLIENTE, RAZAO_SOCIAL, NOME_FANTASIA, CNPJ, ATIVO
              FROM CLIENTE
              WHERE ATIVO = 1
              ORDER BY RAZAO_SOCIAL", conn);

            using var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente
                {
                    Id = dr.GetInt32(0),
                    RazaoSocial = dr.GetString(1),
                    NomeFantasia = dr.IsDBNull(2) ? null : dr.GetString(2),
                    Cnpj = dr.IsDBNull(3) ? null : dr.GetString(3),
                    Ativo = dr.GetInt32(4) == 1
                });
            }
            return lista;
        }

        public void Inserir(Cliente c)
        {
            using var conn = GetConnection();
            using var cmd = new SqliteCommand(
                @"INSERT INTO CLIENTE (RAZAO_SOCIAL, NOME_FANTASIA, CNPJ, ATIVO)
              VALUES (@razao, @fantasia, @cnpj, 1)", conn);

            cmd.Parameters.AddWithValue("@razao", c.RazaoSocial);
            cmd.Parameters.AddWithValue("@fantasia", c.NomeFantasia);
            cmd.Parameters.AddWithValue("@cnpj", c.Cnpj);

            cmd.ExecuteNonQuery();
        }

        public void Atualizar(Cliente c)
        {
            using var conn = GetConnection();
            using var cmd = new SqliteCommand(
                @"UPDATE CLIENTE
              SET RAZAO_SOCIAL = @razao,
                  NOME_FANTASIA = @fantasia,
                  CNPJ = @cnpj
              WHERE ID_CLIENTE = @id", conn);

            cmd.Parameters.AddWithValue("@razao", c.RazaoSocial);
            cmd.Parameters.AddWithValue("@fantasia", c.NomeFantasia);
            cmd.Parameters.AddWithValue("@cnpj", c.Cnpj);
            cmd.Parameters.AddWithValue("@id", c.Id);

            cmd.ExecuteNonQuery();
        }

        public void Inativar(int id)
        {
            using var conn = GetConnection();
            using var cmd = new SqliteCommand(
                @"UPDATE CLIENTE SET ATIVO = 0 WHERE ID_CLIENTE = @id", conn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }

}
