namespace CASA.Framework.Authentication.Contracts
{
    public interface IUserAuthenticator
    {
        public bool IsUserAuthenticated(string JWT);
    }
}