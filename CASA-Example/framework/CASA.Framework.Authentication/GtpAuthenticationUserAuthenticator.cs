using CASA.Framework.Authentication.Contracts;

namespace CASA.Framework.Authentication
{
    // This would like be in it's own project
    public class GtpAuthenticationUserAuthenticator : IUserAuthenticator
    {
        // Implementation Here Against GTP Authentication Library
        public bool IsUserAuthenticated(string JWT)
        {
            throw new NotImplementedException();
        }
    }
}
