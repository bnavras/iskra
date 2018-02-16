namespace Iskra.Infrastructure
{
    public interface IAuthorization
    {
        int CheckPassword(string inputPassword, 
            string hashCorrectPassword, IPasswordEncryption encryption);
    }
}
