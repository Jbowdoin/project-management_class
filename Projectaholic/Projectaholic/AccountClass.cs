using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectaholic
{
    class AccountClass
    {
        string accountName;
        DateTime accountCreateDate;
        string accountLocation;
        string accountPassHash;
        string accountDescription;
        string accountSecurityHash;
        List<ProjectClass> accountProjects;

        public AccountClass(string username, string password, string securityAnswer)
        {
            using (SHA256 shaHash = SHA256.Create())
            {
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

        public static AccountClass Login(string username, string password)
        {
            throw new NotImplementedException();
            return null;
        }

        private static string GetHash(HashAlgorithm hashAlgo, string source)
        {
            byte[] data = hashAlgo.ComputeHash(Encoding.UTF8.GetBytes(source));
            string hash = BitConverter.ToString(data, 0);
            return hash;
        }

        private static bool VerifyHash(HashAlgorithm hashAlgo, string hash, string source)
        {
            string data = GetHash(hashAlgo, source);
            return data.Equals(hash);
        }
    }


}
