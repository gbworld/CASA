using CASA.Domain.Models;
using CASA.Persist.PostalCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASA.Core.Test.Unit.Helper
{
    public class PostalCodeRepositoryMock : IPostalCodeRepository
    {
        public IList<PostalCode> GetByPostalCode(string code)
        {
            var postalCodeSingle = new Domain.Models.PostalCode()
            {
                Id = 37221,
                Code = "37221",
                CountryId = 840,
                CountryName = "United States of America",
                CountryAbbrev2 = "US",
                CountryAbbrev3 = "USA",
                RegionId = 47,
                RegionName = "Tennessee",
                RegionAbbrev2 = "TN",
                RegionTypeId = 1,
                RegionTypeName = "State",
                CountyId = 2447,
                CountyName = "DAVIDSON",
                CityId = 23652,
                CityName = "NASHVILLE"
            };

            IList<Domain.Models.PostalCode> postalCodes = new List<Domain.Models.PostalCode>();

            postalCodes.Add(postalCodeSingle);
            return postalCodes;
        }

        public IList<PostalCode> GetPostalCodesByCityId(int cityId)
        {
            throw new NotImplementedException();
        }

        public IList<PostalCode> GetPostalCodesByCityNameAndRegionAbbrev(string cityName, string regionAbbrev)
        {
            throw new NotImplementedException();
        }

        public IList<PostalCode> GetPostalCodesByStateName(string stateName)
        {
            throw new NotImplementedException();
        }

        public void SetConnectionString(string connectionString)
        {
            // Not required in a mock
        }
    }

}
