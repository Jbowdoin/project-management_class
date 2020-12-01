using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Projectaholic
{
    class AccountClass
    {
        public enum SecurityQuestionEnum
        {

        }

        string accountName;
        DateTime accountCreateDate;
        string accountLocation;
        string accountPassHash;
        string accountDescription;
        SecurityQuestionEnum accountSecurityQuestion;
        string accountSecurityHash;
        List<ProjectClass> accountProjects;

        public AccountClass(string username, string password, SecurityQuestionEnum securityQuestion, string securityAnswer)
        {
            using (SHA256 shaHash = SHA256.Create())
            {
                if (username.Length <= 6)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (password.Length < 6 || password.Length > 28)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (securityAnswer.Length < 2 || securityAnswer.Length > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
                string passHash = GetHash(shaHash, password);
                string securityHash = GetHash(shaHash, securityAnswer);
                
                accountName = username;
                accountPassHash = passHash;
                accountSecurityHash = securityHash;
                accountDescription = "Description not given.";
                accountLocation = "N/A";
                accountCreateDate = DateTime.UtcNow;
            }
        }

        public AccountClass(string name, string password, SecurityQuestionEnum securityQuestion, string securityAnswer, string location, string description) : this(name, password, securityQuestion, securityAnswer)
        {
            if (location.Length > 3)
            {
                accountLocation = location;
            }
            if (description.Length > 1)
            {
                accountDescription = description;
            }
        }

        public static AccountClass RegisterAccount(string name, string pass, SecurityQuestionEnum question, string answer, string location, string description)
        {
            throw new NotImplementedException();
            return null;
        }

        public static AccountClass Login(string username, string password)
        {
            AccountClass loggedUser = null;
            string sqlCommand = @"SELECT accountID, username, password FROM dbo.Accounts";
            SqlConnection connection = new SqlConnection(SQLClass.GetSQLConnectionString());
            SqlCommand command = new SqlCommand(sqlCommand, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string checkUser = reader.GetString(1);
                    if (checkUser.Equals(username))
                    {
                        string checkPass = reader.GetString(2);
                        if (VerifyHash(SHA256.Create(), checkPass, password))
                        {
                            string location = reader.GetString(3);
                            SecurityQuestionEnum question = (SecurityQuestionEnum)reader.GetInt32(4);
                            string answer = reader.GetString(5);
                            string description = reader.GetString(6);
                            loggedUser = new AccountClass(checkUser, checkUser, question, answer, location, description);
                            reader.Close();
                            return loggedUser;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            return null;
        }

        private static string GetHash(HashAlgorithm hashAlgo, string source)
        {
            byte[] data = hashAlgo.ComputeHash(Encoding.UTF8.GetBytes(source));
            string hash = BitConverter.ToString(data, 0).Replace("-", "");
            return hash;
        }

        private static bool VerifyHash(HashAlgorithm hashAlgo, string hash, string source)
        {
            string data = GetHash(hashAlgo, source);
            return data.Equals(hash);
        }
    }


}
