﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadasterMVC.DAO;
using System.Data.SqlClient;
using CadasterMVC.Models;

namespace CadasterMVC.DAO
{
    public class PessoaDb
    {
        public ICollection<Pessoa> ObterTodos()
        {
            var sqlConn = new Connection();

            string selectAll = $"SELECT Id, Nome, Empresa, Contato FROM [dbo].[Pessoas]";

            List<Pessoa> pessoas = new List<Pessoa>();

            using (var conn = sqlConn.ConnectionSql())
            {
                SqlCommand command = new SqlCommand(selectAll, conn);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            var pessoa = new Pessoa();

                            pessoa.Id = long.Parse(reader["Id"].ToString());
                            pessoa.Nome = reader["Nome"].ToString();
                            pessoa.Empresa = reader["Empresa"].ToString();
                            pessoa.Contato = reader["Contato"].ToString();

                            pessoas.Add(pessoa);

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            return pessoas;
        }

        public Pessoa ObterPorId(long id)
        {
            var pessoa = new Pessoa();
            var sqlConn = new Connection();
            var selectById = $"SELECT Id, Nome, Empresa, Contato FROM [dbo].[Pessoas] WHERE Id = @Id";

            using (var conn = sqlConn.ConnectionSql())
            {
                SqlCommand command = new SqlCommand(selectById, conn);
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        pessoa.Id = long.Parse(reader["Id"].ToString());
                        pessoa.Nome = reader["Nome"].ToString();
                        pessoa.Empresa = reader["Empresa"].ToString();
                        pessoa.Contato = reader["Contato"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            return pessoa;
        }

        public bool Cadastrar(Pessoa pessoa)
        {
            var success = false;
            var sqlConn = new Connection();
            using (var conn = sqlConn.ConnectionSql())
            {
                conn.Open();

                string query = $@"INSERT INTO [dbo].[Pessoas] (Nome, Empresa, Contato, DataCriacao, DataAlteracao) VALUES (@Nome, @Empresa, @Contato, @DataCriacao, @DataAlteracao)";

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@Nome", pessoa.Nome);
                command.Parameters.AddWithValue("@Empresa", pessoa.Empresa);
                command.Parameters.AddWithValue("@Contato", pessoa.Contato);
                command.Parameters.AddWithValue("@DataCriacao", DateTime.Now);
                command.Parameters.AddWithValue("@DataAlteracao", DateTime.Now);

                var linesOfExecution = command.ExecuteNonQuery();
                if (linesOfExecution > 0)
                    success = true;
            }

            return success;
        }

        public bool Atualizar(long id, Pessoa pessoa)
        {
            var success = false;
            var sqlConn = new Connection();
            using (var conn = sqlConn.ConnectionSql())
            {
                conn.Open();

                string query = $@"UPDATE [dbo].[Pessoas]
                                  SET Nome = @Nome, Empresa = @Empresa, Contato = @Contato, DataAlteracao = @DataAlteracao
                                  WHERE Id = @id";

                SqlCommand command = new SqlCommand(query, conn);


                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Nome", pessoa.Nome);
                command.Parameters.AddWithValue("@Empresa", pessoa.Empresa);
                command.Parameters.AddWithValue("@Contato", pessoa.Contato);
                command.Parameters.AddWithValue("@DataAlteracao", DateTime.Now);

                var linesOfExecution = command.ExecuteNonQuery();
                if (linesOfExecution > 0)
                    success = true;
            }

            return success;
        }

        public bool Excluir(long id)
        {
            var success = false;
            var sqlConn = new Connection();

            using (var conn = sqlConn.ConnectionSql())
            {
                conn.Open();

                string query = $@"DELETE [dbo].[Pessoas] WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, conn);


                command.Parameters.AddWithValue("@Id", id);

                var linesOfExecution = command.ExecuteNonQuery();
                if (linesOfExecution > 0)
                    success = true;
            }

            return success;
        }
    }
}

