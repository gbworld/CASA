namespace CASA.Framework.ClientRouting.Contracts
{
    public interface IClientRouter
    {
        public string GetConnectionStringForJWT(string jWT);
    }
}