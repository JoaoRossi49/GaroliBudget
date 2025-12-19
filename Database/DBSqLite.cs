using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaroliBudget.Database
{
    public static class DBSqLite
    {
        public static string CaminhoDb { get; } =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Garoli",
                "GaroliBudget",
                "GaroliBudget.db"
            );

        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection($"Data Source={CaminhoDb}");
        }

        public static void CriarBancoSeNaoExistir()
        {
            var pastaDb = Path.GetDirectoryName(CaminhoDb);

            if (!Directory.Exists(pastaDb))
            {
                Directory.CreateDirectory(pastaDb);
            }
            if (!File.Exists(CaminhoDb))
            {
                File.Create(CaminhoDb);
            }
        }

        public static void CriarEstruturaInicial()
        {
            CriarBancoSeNaoExistir();

            using var con = GetConnection();
            con.Open();

            string sql = @"
                            CREATE TABLE IF NOT EXISTS MATERIAL (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Nome TEXT NOT NULL,
                                Preco FLOAT NOT NULL
                            );
                        ";

            using var cmd = new SqliteCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }
}
