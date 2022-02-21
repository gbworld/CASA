using CASA.Persist.PostalCode.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CASA.Persist.PostalCode.Test.Integ
{
    [TestClass]
    public class WhenRetrievingAStateIdForTN : PostalCodeTestBase
    {
        private static int _actual;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            IStateRepository repo = new StateRepository();
            // In the long term, this should be dependency injection
            repo.SetConnectionString(ConnectionString);
            _actual = repo.GetByStateAbbrev("TN");

        }

        [TestMethod]
        public void ShouldHaveARegionIdOf47()
        {
            int expected = 47;
            int actual = _actual;
            Assert.AreEqual(expected, actual);
        }
    }
}
