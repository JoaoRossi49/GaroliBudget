using Microsoft.Data.Sqlite;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaroliBudget.Infrastructure
{
    public abstract class DBPostgres
    {
        private static string Host = "127.0.0.1";
        private static string Database = "garoli";
        private static string User = "postgres";
        private static string Password = "1234";

        public static string ConnectionString =>
                    $"Host={Host};Username={User};Password={Password};Database={Database};Port=5432;";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(ConnectionString);
        }

        public static void Initialize()
        {
            using var con = GetConnection();
            con.Open();

            string sql = @"
                            --------------------------------------------------
                            -- CLIENTES
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS CLIENTE (
                                ID_CLIENTE SERIAL PRIMARY KEY,
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
                                ID_MATERIAL SERIAL PRIMARY KEY,
                                CODIGO TEXT NOT NULL,
                                DESCRICAO TEXT NOT NULL,
                                UNIDADE TEXT NOT NULL,
                                CUSTO_UNITARIO REAL NOT NULL,
                                ATIVO INTEGER NOT NULL DEFAULT 1
                            );

                            --------------------------------------------------
                            -- COMPONENTES
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS COMPONENTE (
                                ID_COMPONENTE SERIAL PRIMARY KEY,
                                CODIGO TEXT NOT NULL,
                                DESCRICAO TEXT NOT NULL,
                                CUSTO_UNITARIO REAL NOT NULL,
                                ATIVO INTEGER NOT NULL DEFAULT 1
                            );

                            --------------------------------------------------
                            -- PROCESSOS / MÃO DE OBRA
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS PROCESSO (
                                ID_PROCESSO SERIAL PRIMARY KEY,
                                DESCRICAO TEXT NOT NULL,
                                CUSTO_HORA REAL NOT NULL,
                                ATIVO INTEGER NOT NULL DEFAULT 1
                            );

                            --------------------------------------------------
                            -- EQUIPAMENTOS (TEMPLATE)
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS EQUIPAMENTO (
                                ID_EQUIPAMENTO SERIAL PRIMARY KEY,
                                CODIGO TEXT NOT NULL ,
                                DESCRICAO TEXT NOT NULL,
                                OBSERVACOES TEXT,
                                ATIVO INTEGER NOT NULL DEFAULT 1
                            );

                            --------------------------------------------------
                            -- MÓDULOS DO EQUIPAMENTO (TEMPLATE)
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS EQUIPAMENTO_MODULO (
                                ID_MODULO SERIAL PRIMARY KEY,
                                ID_EQUIPAMENTO INTEGER NOT NULL,
                                NOME_MODULO TEXT NOT NULL,
                                ORDEM INTEGER DEFAULT 0,
                                FOREIGN KEY (ID_EQUIPAMENTO) REFERENCES EQUIPAMENTO(ID_EQUIPAMENTO) ON DELETE CASCADE
                            );

                            --------------------------------------------------
                            -- RECEITA DO EQUIPAMENTO - MATERIAIS
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS EQUIPAMENTO_MATERIAL (
                                ID_EQUIPAMENTO_MATERIAL SERIAL PRIMARY KEY,
                                ID_MODULO INTEGER,
                                ID_EQUIPAMENTO INTEGER NOT NULL,
                                ID_MATERIAL INTEGER NOT NULL,
                                DESCRICAO_MATERIAL TEXT,
                                QUANTIDADE_PADRAO REAL NOT NULL,
                                UNIDADE TEXT NOT NULL,

                                FOREIGN KEY (ID_MODULO) REFERENCES EQUIPAMENTO_MODULO(ID_MODULO) ON DELETE CASCADE,
                                FOREIGN KEY (ID_EQUIPAMENTO) REFERENCES EQUIPAMENTO(ID_EQUIPAMENTO) ON DELETE CASCADE,
                                FOREIGN KEY (ID_MATERIAL) REFERENCES MATERIAL(ID_MATERIAL)
                            );

                            --------------------------------------------------
                            -- RECEITA DO EQUIPAMENTO - COMPONENTES
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS EQUIPAMENTO_COMPONENTE (
                                ID_EQUIPAMENTO_COMPONENTE SERIAL PRIMARY KEY,
                                ID_MODULO INTEGER,
                                ID_EQUIPAMENTO INTEGER NOT NULL,
                                ID_COMPONENTE INTEGER NOT NULL,
                                DESCRICAO_COMPONENTE TEXT,
                                QUANTIDADE_PADRAO REAL NOT NULL,

                                FOREIGN KEY (ID_MODULO) REFERENCES EQUIPAMENTO_MODULO(ID_MODULO) ON DELETE CASCADE,
                                FOREIGN KEY (ID_EQUIPAMENTO) REFERENCES EQUIPAMENTO(ID_EQUIPAMENTO) ON DELETE CASCADE,
                                FOREIGN KEY (ID_COMPONENTE) REFERENCES COMPONENTE(ID_COMPONENTE)
                            );

                            --------------------------------------------------
                            -- RECEITA DO EQUIPAMENTO - MÃO DE OBRA
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS EQUIPAMENTO_MAO_OBRA (
                                ID_EQUIPAMENTO_MAO_OBRA SERIAL PRIMARY KEY,
                                ID_MODULO INTEGER,
                                ID_EQUIPAMENTO INTEGER NOT NULL,
                                ID_PROCESSO INTEGER NOT NULL,
                                DESCRICAO_PROCESSO TEXT,
                                HORAS_PADRAO REAL NOT NULL,

                                FOREIGN KEY (ID_MODULO) REFERENCES EQUIPAMENTO_MODULO(ID_MODULO) ON DELETE CASCADE,
                                FOREIGN KEY (ID_EQUIPAMENTO) REFERENCES EQUIPAMENTO(ID_EQUIPAMENTO) ON DELETE CASCADE,
                                FOREIGN KEY (ID_PROCESSO) REFERENCES PROCESSO(ID_PROCESSO)
                            );

                            --------------------------------------------------
                            -- ORÇAMENTO (CABECALHO)
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS ORCAMENTO (
                                ID_ORCAMENTO SERIAL PRIMARY KEY,
                                NUMERO TEXT NOT NULL ,
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
                            -- MÓDULOS DO ORÇAMENTO (Subconjuntos)
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS ORCAMENTO_MODULO (
                                ID_MODULO SERIAL PRIMARY KEY,
                                ID_ORCAMENTO INTEGER NOT NULL,
                                NOME_MODULO TEXT NOT NULL, -- Ex: 'Elétrica', 'Revestimento'
                                ORDEM INTEGER DEFAULT 0,    -- Para organizar a exibição
    
                                FOREIGN KEY (ID_ORCAMENTO) REFERENCES ORCAMENTO(ID_ORCAMENTO)
                            );

                            --------------------------------------------------
                            -- ORÇAMENTO - MATERIAIS (CÓPIA DO TEMPLATE)
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS ORCAMENTO_MATERIAL (
                                ID_ORCAMENTO_MATERIAL SERIAL PRIMARY KEY,
                                ID_MODULO INTEGER,
                                ID_ORCAMENTO INTEGER NOT NULL,
                                ID_MATERIAL INTEGER,
                                DESCRICAO TEXT NOT NULL,
                                QUANTIDADE REAL NOT NULL,
                                UNIDADE TEXT NOT NULL,
                                CUSTO_UNITARIO REAL NOT NULL,
                                CUSTO_TOTAL REAL NOT NULL,

                                FOREIGN KEY (ID_MODULO) REFERENCES ORCAMENTO_MODULO(ID_MODULO),
                                FOREIGN KEY (ID_ORCAMENTO) REFERENCES ORCAMENTO(ID_ORCAMENTO),
                                FOREIGN KEY (ID_MATERIAL) REFERENCES MATERIAL(ID_MATERIAL)
                            );

                            --------------------------------------------------
                            -- ORÇAMENTO - COMPONENTES
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS ORCAMENTO_COMPONENTE (
                                ID_ORCAMENTO_COMPONENTE SERIAL PRIMARY KEY,
                                ID_MODULO INTEGER,
                                ID_ORCAMENTO INTEGER NOT NULL,
                                ID_COMPONENTE INTEGER,
                                DESCRICAO TEXT NOT NULL,
                                QUANTIDADE REAL NOT NULL,
                                CUSTO_UNITARIO REAL NOT NULL,
                                CUSTO_TOTAL REAL NOT NULL,

                                FOREIGN KEY (ID_MODULO) REFERENCES ORCAMENTO_MODULO(ID_MODULO),
                                FOREIGN KEY (ID_ORCAMENTO) REFERENCES ORCAMENTO(ID_ORCAMENTO),
                                FOREIGN KEY (ID_COMPONENTE) REFERENCES COMPONENTE(ID_COMPONENTE)
                            );

                            --------------------------------------------------
                            -- ORÇAMENTO - MÃO DE OBRA
                            --------------------------------------------------
                            CREATE TABLE IF NOT EXISTS ORCAMENTO_MAO_OBRA (
                                ID_ORCAMENTO_MAO_OBRA SERIAL PRIMARY KEY,
                                ID_MODULO INTEGER,
                                ID_ORCAMENTO INTEGER NOT NULL,
                                ID_PROCESSO INTEGER,
                                DESCRICAO TEXT NOT NULL,
                                HORAS REAL NOT NULL,
                                CUSTO_HORA REAL NOT NULL,
                                CUSTO_TOTAL REAL NOT NULL,

                                FOREIGN KEY (ID_MODULO) REFERENCES ORCAMENTO_MODULO(ID_MODULO),
                                FOREIGN KEY (ID_ORCAMENTO) REFERENCES ORCAMENTO(ID_ORCAMENTO),
                                FOREIGN KEY (ID_PROCESSO) REFERENCES PROCESSO(ID_PROCESSO)
                            );
           ";

            using var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }
}
