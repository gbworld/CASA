using CASA.Persist.PostalCode.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CASA.Persist.PostalCode.Test.Integ
{
    [TestClass]
    public class WhenGettingInformationForPostalCode37221 : PostalCodeTestBase
    {
        private static Domain.Models.PostalCode _actual;
        private static Domain.Models.PostalCode _expected;


        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            IPostalCodeRepository repo = new PostalCodeRepository();
            // In the long term, this should be dependency injection
            repo.SetConnectionString(ConnectionString);

            // Pull information for 37221 (shortcutted to get the first item)
            _actual = repo.GetByPostalCode("37221")[0];
            _expected = ReturnValueHelper.GetPostalCodeForTest("37221");
        }

        [TestMethod]
        public void ShouldHaveACountryIdOf840()
        {
            int expected = _expected.CountryId;
            int actual = _actual.CountryId;
            Assert.AreEqual(expected, actual, string.Format("CountryId is Incorrect - Expected: {0}; Actual: {0}", expected, actual));
        }

        [TestMethod]
        public void ShouldHaveCountryNameOfUnitedStatesOfAmerica()
        {
            var expected = _expected.CountryName;
            var actual = _actual.CountryName;
            Assert.AreEqual(expected, actual, string.Format("Country Name is Incorrect - Expected: {0}; Actual: {0}", expected, actual));
        }

        [TestMethod]
        public void ShouldHaveACountryAbrev2OfUS()
        {
            var expected = _expected.CountryAbbrev2;
            var actual = _actual.CountryAbbrev2;
            Assert.AreEqual(expected, actual, string.Format("Country Abbreviation 2 is Incorrect - Expected: {0}; Actual: {0}", expected, actual));
        }


        [TestMethod]
        public void ShouldHaveACountryAbrev3OfUSA()
        {
            var expected = _expected.CountryAbbrev3;
            var actual = _actual.CountryAbbrev3;
            Assert.AreEqual(expected, actual, string.Format("Country Abbreviation 3 is Incorrect - Expected: {0}; Actual: {0}", expected, actual));
        }


        [TestMethod]
        public void ShouldHaveARegionIdOf47()
        {
            int expected = _expected.RegionId;
            int actual = _actual.RegionId;
            Assert.AreEqual(expected, actual, string.Format("Region ID is Incorrect - Expected: {0}; Actual: {0}", expected, actual));
        }


        [TestMethod]
        public void ShouldHaveRegionNameOfTennessee()
        {
            var expected = _expected.RegionName;
            var actual = _actual.RegionName;
            Assert.AreEqual(expected, actual, string.Format("Region Name is Incorrect - Expected: {0}; Actual: {0}", expected, actual));
        }

        [TestMethod]
        public void ShouldHaveRegionAbbrevOfTN()
        {
            var expected = _expected.RegionAbbrev2;
            var actual = _actual.RegionAbbrev2;
            Assert.AreEqual(expected, actual, string.Format("Region Abbreviation is Incorrect - Expected: {0}; Actual: {0}", expected, actual));
        }

        [TestMethod]
        public void ShouldHaveARegionTypeIdOf1()
        {
            int expected = _expected.RegionTypeId;
            int actual = _actual.RegionTypeId;
            Assert.AreEqual(expected, actual, string.Format("Region Type ID is Incorrect - Expected: {0}; Actual: {0}", expected, actual));
        }


        [TestMethod]
        public void ShouldHaveARegionTypeNameOfState()
        {
            var expected = _expected.RegionTypeName;
            var actual = _actual.RegionTypeName;
            Assert.AreEqual(expected, actual, string.Format("Region Type Name is Incorrect - Expected: {0}; Actual: {0}", expected, actual));
        }

        [TestMethod]
        public void ShouldHaveACountyIdOf2447()
        {
            int expected = _expected.CountyId;
            int actual = _actual.CountyId;
            Assert.AreEqual(expected, actual, string.Format("County ID is Incorrect - Expected: {0}; Actual: {0}", expected, actual));
        }

        [TestMethod]
        public void CountHaveACountyNameOfDavidson()
        {
            var expected = _expected.CountyName;
            var actual = _actual.CountyName;
            Assert.AreEqual(expected, actual, string.Format("County Name is Incorrect - Expected: {0}; Actual: {0}", expected, actual));
        }

        [TestMethod]
        public void ShouldHaveACityIdOf23652()
        {
            int expected = _expected.CityId;
            int actual = _actual.CityId;
            Assert.AreEqual(expected, actual, string.Format("City ID is Incorrect - Expected: {0}; Actual: {0}", expected, actual));
        }

        [TestMethod]
        public void CountHaveACityyNameOfNashville()
        {
            var expected = _expected.CityName;
            var actual = _actual.CityName;
            Assert.AreEqual(expected, actual, string.Format("City Name is Incorrect - Expected: {0}; Actual: {0}", expected, actual));
        }

    }
}