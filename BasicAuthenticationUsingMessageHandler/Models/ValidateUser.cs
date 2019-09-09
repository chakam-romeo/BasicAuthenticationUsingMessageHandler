using BasicAuthenticationUsingMessageHandler.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BasicAuthenticationUsingMessageHandler.Models
{
    public class ValidateUser
    {
        public Connexion conn = new Connexion();

        public DataEntry CheckUserCredentials(string username, string password)
        {
            SqlDataReader reader = null;
            SqlConnection myConnection = conn.openCon();
            bool res = false;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = myConnection;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select UserName, Password, Name, UserID from Users where UserName='" + username.Trim() + "' AND Password='" + password.Trim() + "'";
            Users user = new Users();
            DataEntry ResultData = new DataEntry();
            try
            {
                myConnection.Open();
                
                reader = sqlCmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user.UserID = Convert.ToInt32(reader["UserID"]);
                        user.UserName = reader["UserName"].ToString();
                        user.Password = reader["Password"].ToString();
                        user.Name = reader["Name"].ToString();

                        ResultData.CodeRequest = 0;
                        ResultData.user = user;
                    }

                }
                else
                {
                    ResultData.CodeRequest = 1;
                    ResultData.MessageResult = "Erreur elements introuvable";
                   

                }

            }
            catch (Exception e)
            {
                ResultData.CodeRequest =500;
                ResultData.MessageResult = e.Message;
            }
            finally
            {
                sqlCmd.Dispose();
                conn.closeCon(myConnection);
            }
            
            return ResultData;
        }
    }
}