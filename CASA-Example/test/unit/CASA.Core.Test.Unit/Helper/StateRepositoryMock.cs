using CASA.Persist.PostalCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASA.Core.Test.Unit.Helper
{
    public class StateRepositoryMock : IStateRepository
    {
        public int GetByCityId(int cityId)
        {
            // This is for the examples in this test suite
            return 47;
        }

        public int GetByPostalCode(string postalCode)
        {
            // This is for the examples in this test suite
            return 47;
        }

        public int GetByStateAbbrev(string stateAbbrev)
        {
            // This is for the examples in this test suite
            return 47;
        }

        public void SetConnectionString(string connectionString)
        {
            // Not required for Mock
        }
    }
}
