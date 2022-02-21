using CASA.Core.Contracts;
using CASA.Domain.Models;
using CASA.Framework.Authentication.Contracts;
using CASA.Framework.ClientRouting.Contracts;
using CASA.Persist.PostalCode.Contracts;
using System.Text;

namespace CASA.Core
{
    public class PostalCodeDataPackService : IPostalCodeDataPackService
    {
        public IPostalCodeRepository PostalCodeRepository { get; set; }

        // These are used as a shortcut for security trimmings (a real JWT would be sent normally)
        public IStateRepository StateRepository { get; set; }
        public ICountryRepository CountryRepository { get; set; }


        public IClientRouter Router { get; set; }
        public IUserAuthenticator Authenticator { get; set; }

        public string ConnectionString { get; set; }


        public PostalCodeDataPackService(IPostalCodeRepository postalCodeRepository
            , ICountryRepository countryRepository, IStateRepository stateRepository
            , IClientRouter clientRouter, IUserAuthenticator userAuthenticator)
        {
            // This would be done through dependency injection normally
            PostalCodeRepository = postalCodeRepository;
            CountryRepository = countryRepository;
            StateRepository = stateRepository;
            Router = clientRouter;
            Authenticator = userAuthenticator;

        }

        public IList<PostalCode> GetPostalCodeListByCityNameAndStateAbbreviation(int CityName, string stateAbbrev, string userName)
        {
            // TODO: This is a weak example of applying security trimmings
            // Need Country And State Id for authentication
            int countryId = this.RetrieveCountryIdForStateAbbrev(stateAbbrev);
            int stateId = this.RetrieveStateIdForStateAbbrev(stateAbbrev);
            string jwtFake = FakeJwtTokenAsString(userName, countryId, stateId);

            // Use Fake JWT for security
            if (!IsUserAuthenticated(jwtFake))
            {

            }

            // Fake out the Client Routing


            throw new NotImplementedException();
        }

        private bool IsUserAuthenticated(string jwtFake)
        {
            return Authenticator.IsUserAuthenticated(jwtFake);
        }

        public IList<PostalCode> GetPostalCodeListByCityId(int cityId, string userName)
        {
            // TODO: This is a weak example of applying security trimmings
            // Need Country And State Id for authentication
            int countryId = this.RetrieveCountryIdForCityId(cityId);
            int stateId = this.RetrieveStateIdForCityId(cityId);
            string jwtFake = FakeJwtTokenAsString(userName, countryId, stateId);

            throw new NotImplementedException();
        }

        public IList<PostalCode> GetPostalCodeListByPostalCode(string postalCode, string userName, bool expandToCity = false)
        {
            int countryId = this.RetrieveCountryIdForPostalCode(postalCode);
            int stateId = this.RetrieveStateIdForPostalCode(postalCode);
            string jwtFake = FakeJwtTokenAsString(userName, countryId, stateId);

            // See if user is Authenticated
            if (!this.IsUserAuthenticated(jwtFake))
                throw new AccessViolationException("Not authenticated for this country or region");

            // Get database Connection from Client Routing (FAKED HERE)
            string connectionString = Router.GetConnectionStringForJWT(jwtFake);
            PostalCodeRepository.SetConnectionString(connectionString);

            return PostalCodeRepository.GetByPostalCode(postalCode);
        }

        private int RetrieveStateIdForPostalCode(string postalCode)
        {
            
           return StateRepository.GetByPostalCode(postalCode);
        }

        private int RetrieveCountryIdForPostalCode(string postalCode)
        {
           return CountryRepository.GetByPostalCode(postalCode);
        }

        private string FakeJwtTokenAsString(string userName, int countryId, int stateId)
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

        private int RetrieveCountryIdForStateAbbrev(string stateAbbrev)
        {
            return CountryRepository.GetByStateAbbrev(stateAbbrev);
        }

        private int RetrieveStateIdForStateAbbrev(string stateAbbrev)
        {
            return StateRepository.GetByStateAbbrev(stateAbbrev);
        }

        private int RetrieveStateIdForCityId(int cityId)
        {
            return StateRepository.GetByCityId(cityId);
        }

        private int RetrieveCountryIdForCityId(int cityId)
        {
            return CountryRepository.GetByCityId(cityId);
        }


    }
}