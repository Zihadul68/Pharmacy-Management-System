using System;
using System.Data;
using System.Data.SqlClient;

namespace PharmacyManagement
{
    internal class DataAccess : IDisposable
    {
        private readonly SqlConnection sqlcon;

        public DataAccess()
        {
            var connectionString = Environment.GetEnvironmentVariable("PHARMACY_CONNECTION_STRING");
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException(
                    "PHARMACY_CONNECTION_STRING must be set before starting Pharmacy Management.");
            }

            sqlcon = new SqlConnection(connectionString);
            sqlcon.Open();
        }

        public DataSet ExecuteQuery(string sql, params SqlParameter[] parameters)
        {
            using (var command = CreateCommand(sql, parameters))
            using (var adapter = new SqlDataAdapter(command))
            {
                var result = new DataSet();
                adapter.Fill(result);
                return result;
            }
        }

        public DataTable ExecuteQueryTable(string sql, params SqlParameter[] parameters)
        {
            var result = ExecuteQuery(sql, parameters);
            return result.Tables.Count == 0 ? new DataTable() : result.Tables[0];
        }

        public int ExecuteDMLQuery(string sql, params SqlParameter[] parameters)
        {
            using (var command = CreateCommand(sql, parameters))
            {
                return command.ExecuteNonQuery();
            }
        }

        private SqlCommand CreateCommand(string sql, SqlParameter[] parameters)
        {
            if (string.IsNullOrWhiteSpace(sql))
            {
                throw new ArgumentException("A SQL command is required.", nameof(sql));
            }

            var command = new SqlCommand(sql, sqlcon);
            if (parameters != null && parameters.Length > 0)
            {
                command.Parameters.AddRange(parameters);
            }

            return command;
        }

        public void Dispose()
        {
            sqlcon.Dispose();
        }
    }
}
