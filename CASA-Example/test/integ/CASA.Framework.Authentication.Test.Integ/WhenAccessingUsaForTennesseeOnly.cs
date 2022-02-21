using CASA.Framework.Authentication.Contracts;
using CASA.Framework.Authentication.Test.Integ.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace CASA.Framework.Authentication.Test.Integ
{
    [TestClass]
    public class WhenAccessingForTennesseeOnly : AuthenticationTestBase
    {
        public static bool _actual = false;
        public static string _userName = "TennesseeOnly";
        public static int _countryId = 840;
        public static int _regionId = 47;



        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            IUserAuthenticator authenticator = new DatabaseUserAutheticator();
            string JWT = FakeJwtTokenAsString(_userName, _countryId, _regionId);
            _actual = authenticator.IsUserAuthenticated(JWT);
        }

        private static string FakeJwtTokenAsString(string userName, int countryId, int stateId)
        {
            var builder = new StringBuilder();
            builder.Append("UserName=");
            builder.Append(userName);
            builder.Append(";CountryId=");
            builder.Append(countryId);
            builder.Append(";StateId=");
            builder.Append(stateId);

            return builder.ToString();

        }

        [TestMethod]
        public void ShouldReturnTrueForUSAAccess()
        {
            Assert.IsTrue(_actual);
        }
    }
}