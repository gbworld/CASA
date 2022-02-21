using CASA.Persist.PostalCode.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CASA.Persist.PostalCode.Test.Integ
{
    [TestClass]
    public class WhenGettingAllPostalCodesForNashvilleTNByCityNameAndRegionAbbrev : PostalCodeTestBase
    {
        private static IList<Domain.Models.PostalCode> _actual;


        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            IPostalCodeRepository repo = new PostalCodeRepository();
            // In the long term, this should be dependency injection
            repo.SetConnectionString(ConnectionString);

            // Pull information for 37221
            _actual = repo.GetPostalCodesByCityNameAndRegionAbbrev("Nashville", "TN");
        }

        [TestMethod]
        public void ShouldHave39PostalCodes()
        {
            int expected = 39;
            int actual = _actual.Count;
            Assert.AreEqual(expected, actual, String.Format("Count is off - Expected {0}, Actual: {1}", expected, actual));
        }
    }
}
