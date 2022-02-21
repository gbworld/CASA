using CASA.Framework.ClientRouting.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CASA.Framework.ClientRouting.Test.Integ
{
    [TestClass]
    public class WhenRetrievingJwtForUsUser
    {
        private static string _actual;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            IClientRouter router = new ExampleClientRouter();
            _actual = router.GetConnectionStringForJWT("FakeJWT");
        }

        [TestMethod]
        public void ConnectionStringShouldBeCorrect()
        {
            string expect = "Server=(local);Database=PostalCode;Trusted_Connection=true;";
            string actual = _actual;
            Assert.AreEqual(expect, actual);
        }
    }
}