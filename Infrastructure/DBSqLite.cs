using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaroliBudget.Infrastructure
{
    public abstract class DBSqLite
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

            string sql = @"PRAGMA foreign_keys = ON;

                            --------------------------------------------------
                            -- CLIENTES
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS CLIENTE (
                                ID_CLIENTE INTEGER PRIMARY KEY AUTOINCREMENT,
                                RAZAO_SOCIAL TEXT NOT NULL,
                                NOME_FANTASIA TEXT,
                                CNPJ TEXT,
                                EMAIL TEXT,
                                TELEFONE TEXT,
                                ATIVO INTEGER NOT NULL DEFAULT 1
                            );

                            --------------------------------------------------
                            -- MATERIAIS
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS MATERIAL (
                                ID_MATERIAL INTEGER PRIMARY KEY AUTOINCREMENT,
                                CODIGO TEXT NOT NULL UNIQUE,
                                DESCRICAO TEXT NOT NULL,
                                UNIDADE TEXT NOT NULL,
                                CUSTO_UNITARIO REAL NOT NULL,
                                ATIVO INTEGER NOT NULL DEFAULT 1
                            );

                            --------------------------------------------------
                            -- COMPONENTES
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS COMPONENTE (
                                ID_COMPONENTE INTEGER PRIMARY KEY AUTOINCREMENT,
                                CODIGO TEXT NOT NULL UNIQUE,
                                DESCRICAO TEXT NOT NULL,
                                CUSTO_UNITARIO REAL NOT NULL,
                                ATIVO INTEGER NOT NULL DEFAULT 1
                            );

                            --------------------------------------------------
                            -- PROCESSOS / MÃO DE OBRA
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS PROCESSO (
                                ID_PROCESSO INTEGER PRIMARY KEY AUTOINCREMENT,
                                DESCRICAO TEXT NOT NULL,
                                CUSTO_HORA REAL NOT NULL,
                                ATIVO INTEGER NOT NULL DEFAULT 1
                            );

                            --------------------------------------------------
                            -- EQUIPAMENTOS (TEMPLATE)
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS EQUIPAMENTO (
                                ID_EQUIPAMENTO INTEGER PRIMARY KEY AUTOINCREMENT,
                                CODIGO TEXT NOT NULL UNIQUE,
                                DESCRICAO TEXT NOT NULL,
                                OBSERVACOES TEXT,
                                ATIVO INTEGER NOT NULL DEFAULT 1
                            );

                            --------------------------------------------------
                            -- RECEITA DO EQUIPAMENTO - MATERIAIS
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS EQUIPAMENTO_MATERIAL (
                                ID_EQUIPAMENTO_MATERIAL INTEGER PRIMARY KEY AUTOINCREMENT,
                                ID_EQUIPAMENTO INTEGER NOT NULL,
                                ID_MATERIAL INTEGER NOT NULL,
                                DESCRICAO_MATERIAL TEXT,
                                QUANTIDADE_PADRAO REAL NOT NULL,
                                UNIDADE TEXT NOT NULL,

                                FOREIGN KEY (ID_EQUIPAMENTO) REFERENCES EQUIPAMENTO(ID_EQUIPAMENTO),
                                FOREIGN KEY (ID_MATERIAL) REFERENCES MATERIAL(ID_MATERIAL)
                            );

                            --------------------------------------------------
                            -- RECEITA DO EQUIPAMENTO - COMPONENTES
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS EQUIPAMENTO_COMPONENTE (
                                ID_EQUIPAMENTO_COMPONENTE INTEGER PRIMARY KEY AUTOINCREMENT,
                                ID_EQUIPAMENTO INTEGER NOT NULL,
                                ID_COMPONENTE INTEGER NOT NULL,
                                DESCRICAO_COMPONENTE TEXT,
                                QUANTIDADE_PADRAO REAL NOT NULL,

                                FOREIGN KEY (ID_EQUIPAMENTO) REFERENCES EQUIPAMENTO(ID_EQUIPAMENTO),
                                FOREIGN KEY (ID_COMPONENTE) REFERENCES COMPONENTE(ID_COMPONENTE)
                            );

                            --------------------------------------------------
                            -- RECEITA DO EQUIPAMENTO - MÃO DE OBRA
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS EQUIPAMENTO_MAO_OBRA (
                                ID_EQUIPAMENTO_MAO_OBRA INTEGER PRIMARY KEY AUTOINCREMENT,
                                ID_EQUIPAMENTO INTEGER NOT NULL,
                                ID_PROCESSO INTEGER NOT NULL,
                                DESCRICAO_PROCESSO TEXT,
                                HORAS_PADRAO REAL NOT NULL,

                                FOREIGN KEY (ID_EQUIPAMENTO) REFERENCES EQUIPAMENTO(ID_EQUIPAMENTO),
                                FOREIGN KEY (ID_PROCESSO) REFERENCES PROCESSO(ID_PROCESSO)
                            );

                            --------------------------------------------------
                            -- ORÇAMENTO (CABECALHO)
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS ORCAMENTO (
                                ID_ORCAMENTO INTEGER PRIMARY KEY AUTOINCREMENT,
                                NUMERO TEXT NOT NULL UNIQUE,
                                DATA_ORCAMENTO TEXT NOT NULL,
                                ID_CLIENTE INTEGER NOT NULL,
                                ID_EQUIPAMENTO INTEGER NOT NULL,
                                DESCRICAO_PROJETO TEXT,
                                MARGEM_CONTRIBUICAO REAL NOT NULL,
                                VALOR_TOTAL REAL,
                                STATUS TEXT NOT NULL,
                                OBSERVACOES TEXT,

                                FOREIGN KEY (ID_CLIENTE) REFERENCES CLIENTE(ID_CLIENTE),
                                FOREIGN KEY (ID_EQUIPAMENTO) REFERENCES EQUIPAMENTO(ID_EQUIPAMENTO)
                            );

                            --------------------------------------------------
                            -- ORÇAMENTO - MATERIAIS (CÓPIA DO TEMPLATE)
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS ORCAMENTO_MATERIAL (
                                ID_ORCAMENTO_MATERIAL INTEGER PRIMARY KEY AUTOINCREMENT,
                                ID_ORCAMENTO INTEGER NOT NULL,
                                ID_MATERIAL INTEGER,
                                DESCRICAO TEXT NOT NULL,
                                QUANTIDADE REAL NOT NULL,
                                UNIDADE TEXT NOT NULL,
                                CUSTO_UNITARIO REAL NOT NULL,
                                CUSTO_TOTAL REAL NOT NULL,

                                FOREIGN KEY (ID_ORCAMENTO) REFERENCES ORCAMENTO(ID_ORCAMENTO),
                                FOREIGN KEY (ID_MATERIAL) REFERENCES MATERIAL(ID_MATERIAL)
                            );

                            --------------------------------------------------
                            -- ORÇAMENTO - COMPONENTES
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS ORCAMENTO_COMPONENTE (
                                ID_ORCAMENTO_COMPONENTE INTEGER PRIMARY KEY AUTOINCREMENT,
                                ID_ORCAMENTO INTEGER NOT NULL,
                                ID_COMPONENTE INTEGER,
                                DESCRICAO TEXT NOT NULL,
                                QUANTIDADE REAL NOT NULL,
                                CUSTO_UNITARIO REAL NOT NULL,
                                CUSTO_TOTAL REAL NOT NULL,

                                FOREIGN KEY (ID_ORCAMENTO) REFERENCES ORCAMENTO(ID_ORCAMENTO),
                                FOREIGN KEY (ID_COMPONENTE) REFERENCES COMPONENTE(ID_COMPONENTE)
                            );

                            --------------------------------------------------
                            -- ORÇAMENTO - MÃO DE OBRA
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS ORCAMENTO_MAO_OBRA (
                                ID_ORCAMENTO_MAO_OBRA INTEGER PRIMARY KEY AUTOINCREMENT,
                                ID_ORCAMENTO INTEGER NOT NULL,
                                ID_PROCESSO INTEGER,
                                DESCRICAO TEXT NOT NULL,
                                HORAS REAL NOT NULL,
                                CUSTO_HORA REAL NOT NULL,
                                CUSTO_TOTAL REAL NOT NULL,

                                FOREIGN KEY (ID_ORCAMENTO) REFERENCES ORCAMENTO(ID_ORCAMENTO),
                                FOREIGN KEY (ID_PROCESSO) REFERENCES PROCESSO(ID_PROCESSO)
                            );
           ";

            using var cmd = new SqliteCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }
}
