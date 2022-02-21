using CASA.Domain.Models;

namespace CASA.Core.Contracts
{
    public interface IPostalCodeDataPackService
    {
        public IList<PostalCode> GetPostalCodeListByPostalCode(string postalCode, string userName, bool expandToCity = false);

        public IList<PostalCode> GetPostalCodeListByCityNameAndStateAbbreviation(int CityName, string stateAbbrev, string UserName);

        public IList<PostalCode> GetPostalCodeListByCityId(int CityId, string UserName);

    }
}