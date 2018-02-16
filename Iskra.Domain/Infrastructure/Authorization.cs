namespace Iskra.Infrastructure
{
    public class Authorization : IAuthorization
    {
        public int CheckPassword(string inputPassword, string hashCorrectPassword, 
            IPasswordEncryption encryption)
        {
            if (encryption.CalculateHash(inputPassword) == hashCorrectPassword) return 1;
            return -1;
        }
    }
}
