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

            string sql = @"CREATE TABLE IF NOT EXISTS CLIENTE (
                            ID_CLIENTE        INTEGER PRIMARY KEY AUTOINCREMENT,
                            RAZAO_SOCIAL      TEXT NOT NULL,
                            NOME_FANTASIA     TEXT,
                            CNPJ              TEXT,
                            CONTATO           TEXT,
                            EMAIL             TEXT,
                            TELEFONE          TEXT,
                            ATIVO             INTEGER NOT NULL DEFAULT 1,
                            DATA_CADASTRO     DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
                        );

                        CREATE TABLE IF NOT EXISTS USUARIO (
                            ID_USUARIO        INTEGER PRIMARY KEY AUTOINCREMENT,
                            NOME              TEXT NOT NULL,
                            EMAIL             TEXT NOT NULL UNIQUE,
                            PERFIL            TEXT NOT NULL CHECK (PERFIL IN ('ADMIN','ORCAMENTISTA')),
                            ATIVO             INTEGER NOT NULL DEFAULT 1
                        );

                        CREATE TABLE IF NOT EXISTS MATERIAL (
                            ID_MATERIAL       INTEGER PRIMARY KEY AUTOINCREMENT,
                            CODIGO            TEXT NOT NULL UNIQUE,
                            DESCRICAO         TEXT NOT NULL,
                            UNIDADE           TEXT NOT NULL,
                            CUSTO_UNITARIO    REAL NOT NULL CHECK (CUSTO_UNITARIO >= 0),
                            DATA_ATUALIZACAO  DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                            ATIVO             INTEGER NOT NULL DEFAULT 1
                        );

                        CREATE TABLE IF NOT EXISTS COMPONENTE (
                            ID_COMPONENTE     INTEGER PRIMARY KEY AUTOINCREMENT,
                            CODIGO            TEXT NOT NULL UNIQUE,
                            DESCRICAO         TEXT NOT NULL,
                            TIPO              TEXT NOT NULL CHECK (TIPO IN ('FABRICADO','COMPRADO')),
                            CUSTO_UNITARIO    REAL NOT NULL CHECK (CUSTO_UNITARIO >= 0),
                            ATIVO             INTEGER NOT NULL DEFAULT 1
                        );

                        CREATE TABLE IF NOT EXISTS PROCESSO (
                            ID_PROCESSO       INTEGER PRIMARY KEY AUTOINCREMENT,
                            DESCRICAO         TEXT NOT NULL UNIQUE,
                            CUSTO_HORA        REAL NOT NULL CHECK (CUSTO_HORA >= 0),
                            ATIVO             INTEGER NOT NULL DEFAULT 1
                        );

                        CREATE TABLE IF NOT EXISTS ORCAMENTO (
                            ID_ORCAMENTO      INTEGER PRIMARY KEY AUTOINCREMENT,
                            ID_CLIENTE        INTEGER NOT NULL,
                            EQUIPAMENTO       TEXT NOT NULL,
                            DESCRICAO_TECNICA TEXT,
                            DATA_CRIACAO      DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                            ID_USUARIO        INTEGER,

                            FOREIGN KEY (ID_CLIENTE) REFERENCES CLIENTE(ID_CLIENTE),
                            FOREIGN KEY (ID_USUARIO) REFERENCES USUARIO(ID_USUARIO)
                        );

                        CREATE TABLE IF NOT EXISTS ORCAMENTO_VERSAO (
                            ID_ORCAMENTO_VERSAO   INTEGER PRIMARY KEY AUTOINCREMENT,
                            ID_ORCAMENTO          INTEGER NOT NULL,
                            NUMERO_VERSAO         INTEGER NOT NULL,
                            STATUS                TEXT NOT NULL CHECK (STATUS IN ('RASCUNHO','APROVADO','REPROVADO')),
                            DATA_VERSAO           DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                            VALIDADE_DIAS         INTEGER,

                            TOTAL_MATERIAIS       REAL NOT NULL DEFAULT 0,
                            TOTAL_COMPONENTES     REAL NOT NULL DEFAULT 0,
                            TOTAL_MAO_OBRA        REAL NOT NULL DEFAULT 0,
                            TOTAL_CUSTOS_INDIRETOS REAL NOT NULL DEFAULT 0,
                            CUSTO_TOTAL           REAL NOT NULL DEFAULT 0,

                            MARGEM_PERCENTUAL     REAL NOT NULL DEFAULT 0,
                            MARGEM_VALOR          REAL NOT NULL DEFAULT 0,
                            PRECO_VENDA           REAL NOT NULL DEFAULT 0,
                            DESCONTO              REAL NOT NULL DEFAULT 0,
                            PRECO_FINAL           REAL NOT NULL DEFAULT 0,

                            FOREIGN KEY (ID_ORCAMENTO) REFERENCES ORCAMENTO(ID_ORCAMENTO),
                            UNIQUE (ID_ORCAMENTO, NUMERO_VERSAO)
                        );

                        CREATE TABLE IF NOT EXISTS ORCAMENTO_MATERIAL (
                            ID_ORCAMENTO_MATERIAL   INTEGER PRIMARY KEY AUTOINCREMENT,
                            ID_ORCAMENTO_VERSAO     INTEGER NOT NULL,
                            ID_MATERIAL             INTEGER,

                            DESCRICAO_MATERIAL      TEXT NOT NULL,
                            QUANTIDADE              REAL NOT NULL CHECK (QUANTIDADE > 0),
                            UNIDADE                 TEXT NOT NULL,
                            CUSTO_UNITARIO          REAL NOT NULL CHECK (CUSTO_UNITARIO >= 0),
                            CUSTO_TOTAL             REAL NOT NULL CHECK (CUSTO_TOTAL >= 0),

                            FOREIGN KEY (ID_ORCAMENTO_VERSAO) REFERENCES ORCAMENTO_VERSAO(ID_ORCAMENTO_VERSAO),
                            FOREIGN KEY (ID_MATERIAL) REFERENCES MATERIAL(ID_MATERIAL)
                        );

                        CREATE TABLE IF NOT EXISTS ORCAMENTO_COMPONENTE (
                            ID_ORCAMENTO_COMPONENTE INTEGER PRIMARY KEY AUTOINCREMENT,
                            ID_ORCAMENTO_VERSAO     INTEGER NOT NULL,
                            ID_COMPONENTE           INTEGER,

                            DESCRICAO_COMPONENTE    TEXT NOT NULL,
                            QUANTIDADE              REAL NOT NULL CHECK (QUANTIDADE > 0),
                            CUSTO_UNITARIO          REAL NOT NULL CHECK (CUSTO_UNITARIO >= 0),
                            CUSTO_TOTAL             REAL NOT NULL CHECK (CUSTO_TOTAL >= 0),

                            FOREIGN KEY (ID_ORCAMENTO_VERSAO) REFERENCES ORCAMENTO_VERSAO(ID_ORCAMENTO_VERSAO),
                            FOREIGN KEY (ID_COMPONENTE) REFERENCES COMPONENTE(ID_COMPONENTE)
                        );

                        CREATE TABLE IF NOT EXISTS ORCAMENTO_MAO_OBRA (
                            ID_ORCAMENTO_MAO_OBRA   INTEGER PRIMARY KEY AUTOINCREMENT,
                            ID_ORCAMENTO_VERSAO     INTEGER NOT NULL,
                            ID_PROCESSO             INTEGER,

                            DESCRICAO_PROCESSO      TEXT NOT NULL,
                            HORAS                   REAL NOT NULL CHECK (HORAS > 0),
                            CUSTO_HORA              REAL NOT NULL CHECK (CUSTO_HORA >= 0),
                            CUSTO_TOTAL             REAL NOT NULL CHECK (CUSTO_TOTAL >= 0),

                            FOREIGN KEY (ID_ORCAMENTO_VERSAO) REFERENCES ORCAMENTO_VERSAO(ID_ORCAMENTO_VERSAO),
                            FOREIGN KEY (ID_PROCESSO) REFERENCES PROCESSO(ID_PROCESSO)
                        );

                        CREATE TABLE IF NOT EXISTS ORCAMENTO_CUSTO_INDIRETO (
                            ID_CUSTO_INDIRETO   INTEGER PRIMARY KEY AUTOINCREMENT,
                            ID_ORCAMENTO_VERSAO INTEGER NOT NULL,

                            DESCRICAO           TEXT NOT NULL,
                            TIPO                TEXT NOT NULL CHECK (TIPO IN ('FIXO','PERCENTUAL')),
                            VALOR_BASE          REAL,
                            VALOR_CALCULADO     REAL NOT NULL CHECK (VALOR_CALCULADO >= 0),

                            FOREIGN KEY (ID_ORCAMENTO_VERSAO) REFERENCES ORCAMENTO_VERSAO(ID_ORCAMENTO_VERSAO)
                        );

                        CREATE INDEX IF NOT EXISTS IDX_ORCAMENTO_CLIENTE
                            ON ORCAMENTO (ID_CLIENTE);

                        CREATE INDEX IF NOT EXISTS IDX_ORCAMENTO_VERSAO_ORCAMENTO
                            ON ORCAMENTO_VERSAO (ID_ORCAMENTO);

                        CREATE INDEX IF NOT EXISTS IDX_ORCAMENTO_STATUS
                            ON ORCAMENTO_VERSAO (STATUS);

                        ";

            using var cmd = new SqliteCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }
}
