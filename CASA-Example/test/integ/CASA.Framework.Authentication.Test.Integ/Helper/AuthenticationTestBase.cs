using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CASA.Framework.Authentication.Test.Integ.Helper
{
    [TestClass]
    public class AuthenticationTestBase
    {
        public static string AuthenticationConnectionString { get; set; }

        static AuthenticationTestBase()
        {
            Configure();
        }

        private static void Configure()
        {
            //TODO: This can be pulled from other locations, like configuration
            AuthenticationConnectionString = "Server=(local);Database=PostalCode;Trusted_Connection=true;";
        }
    }
}
