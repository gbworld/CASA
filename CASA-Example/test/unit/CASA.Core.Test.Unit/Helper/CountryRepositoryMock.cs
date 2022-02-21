using CASA.Persist.PostalCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASA.Core.Test.Unit.Helper
{
    public class CountryRepositoryMock : ICountryRepository
    {
        public int GetByCityId(int cityId)
        {

            // Only US implemented in this sample
            return 840;
        }

        public int GetByPostalCode(string postalCode)
        {
            // Only US implemented in this sample
            return 840;
        }

        public int GetByStateAbbrev(string stateAbbrev)
        {

            // Only US implemented in this sample
            return 840;
        }

        public int GetByStateId(int stateId)
        {

            // Only US implemented in this sample
            return 840;
        }

        public void SetConnectionString(string connectionString)
        {
            // Not needed for unit testing
        }
    }
}
