namespace Boolood.Framework.Security
{
    public interface ISecurityProvider
    {
        string Hash(string plainText, string saltedValue);

    }
}
