namespace Iskra.Infrastructure
{
    public interface IPasswordEncryption
    {
        string CalculateHash(string password);
    }
}
