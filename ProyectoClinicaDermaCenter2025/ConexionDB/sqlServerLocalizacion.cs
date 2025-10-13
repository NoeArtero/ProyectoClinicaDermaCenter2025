using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinicaDermaCenter2025.ConexionDB
{
    internal class sqlServerLocalizacion
    {
        public static string? ResolvedServer { get; private set; }
        public static string? MasterConnectionString { get; private set; }

        public static bool TryResolve(out string serverName, out string masterCs)
        {
            foreach (var server in GetCandidateServers())
            {
                var cs = BuildMasterConnectionString(server);
                if (CanOpen(cs))
                {
                    ResolvedServer = server;
                    MasterConnectionString = cs;
                    serverName = server;
                    masterCs = cs;
                    return true;
                }
            }

            serverName = string.Empty;
            masterCs = string.Empty;
            return false;
        }

        // Lista de posibles bases locales
        private static IEnumerable<string> GetCandidateServers()
        {
            var list = new List<string>
            {
                @"(localdb)\MSSQLLocalDB",
                @".\SQLEXPRESS",
                $@"{Environment.MachineName}\SQLEXPRESS",
                "localhost\\SQLEXPRESS",
                "localhost",
                ".",
                Environment.MachineName
            };

            try
            {
                var table = SqlDataSourceEnumerator.Instance.GetDataSources();
                foreach (DataRow row in table.Rows)
                {
                    var server = row["ServerName"]?.ToString() ?? "";
                    var instance = row["InstanceName"]?.ToString() ?? "";
                    var full = string.IsNullOrWhiteSpace(instance) ? server : $@"{server}\{instance}";
                    if (!string.IsNullOrWhiteSpace(full))
                        list.Add(full);
                }
            }
            catch
            {

            }

            // Quita duplicados 
            return list.Where(s => !string.IsNullOrWhiteSpace(s))
                       .Select(s => s.Trim())
                       .Distinct(StringComparer.OrdinalIgnoreCase);
        }

        private static string BuildMasterConnectionString(string server) =>
            $"Server={server};Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;Connect Timeout=3;";

        private static bool CanOpen(string connectionString)
        {
            try
            {
                using (var cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    using var cmd = new SqlCommand("SELECT 1", cn);
                    cmd.ExecuteScalar();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

