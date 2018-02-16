using System.Security.Cryptography;
using System.Text;

namespace Iskra.Infrastructure
{
    public class MD5PasswordEncryptor : IPasswordEncryption
    {
        public string CalculateHash(string password)
        {
            var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(password);
            var hash = md5.ComputeHash(inputBytes);
            var hashPassword = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                hashPassword.Append(hash[i].ToString("X2"));
            return hashPassword.ToString();
        }
    }
}
