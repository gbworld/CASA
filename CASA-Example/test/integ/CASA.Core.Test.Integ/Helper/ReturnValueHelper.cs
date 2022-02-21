using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASA.Core.Test.Integ.Helper
{
    internal class ReturnValueHelper
    {
        internal static Domain.Models.PostalCode GetPostalCodeForTest(string postalCode)
        {
            switch (postalCode)
            {
                default: //37221
                    return new Domain.Models.PostalCode()
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
            }
        }
    }
}
