﻿using Npgsql;
using System;
using System.Data;

namespace EasyHortifruti

{
    public class ConexaoBD
    {
        private string connectionString;

        public ConexaoBD()
        {
            connectionString = "Host=localhost;Username=Admin;Password=2125071216;Database=EasyHortifruti";
        }

        public DataSet ConsultarTabela(string pNomeTabela)
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = string.Concat("SELECT * FROM ", pNomeTabela);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn))
                        adapter.Fill(dataSet);
                }
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InserirUnidades(string Abreviatura, string Descricao, string Observacao)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string sql = "INSERT INTO UNIDADES (abrev_unid, desc_unid, obs_unid) " +
                    "VALUES (@abreviatura, @Descricao, @observacao)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("abreviatura", Abreviatura);
                    cmd.Parameters.AddWithValue("Descricao", Descricao);
                    cmd.Parameters.AddWithValue("observacao", Observacao);

                    int rowsAffected = cmd.ExecuteNonQuery();
                }
            }
        }

        public void ExcluirUnidade(int pId, string pNomeTabela)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string sql = String.Format("DELETE FROM {0} WHERE id_recno=@ID", pNomeTabela);

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("ID", pId);

                    cmd.ExecuteNonQuery();
                    
                }
            }

        }
    }
}
