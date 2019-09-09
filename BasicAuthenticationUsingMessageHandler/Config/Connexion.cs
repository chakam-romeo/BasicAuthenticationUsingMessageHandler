using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BasicAuthenticationUsingMessageHandler.Config
{
    public class Connexion
    {

        private static SqlConnection connectionSql;

        private static void OpenConnectionSql()
        {
            connectionSql = new SqlConnection();
            connectionSql.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnexion"].ToString();
            connectionSql.Open();
        }

        internal SqlConnection openCon()
        {
            throw new NotImplementedException();
        }

        private static void CloseConnectionSql()
        {
            connectionSql.Dispose();
            connectionSql.Close();
        }

        internal void closeCon(SqlConnection myConnection)
        {
            throw new NotImplementedException();
        }
    }
}