using CASA.Core;
using CASA.Core.Contracts;
using CASA.Framework.Authentication;
using CASA.Framework.Authentication.Contracts;
using CASA.Framework.ClientRouting;
using CASA.Framework.ClientRouting.Contracts;
using CASA.Persist.PostalCode;
using CASA.Persist.PostalCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASA.Present.Desk.Console
{
    public  class PostalCodeRetriever
    {


        public IList<Domain.Models.PostalCode> GetPostalCodesForPostalCode(string postalCode, string userName, bool includeCity = false)
        {
            // TODO: Pull from Dependecy Injection
            // NOTE: This is the Presentation knowing configuartion
            //              (a different UI might do things differently)
            IPostalCodeRepository postalCodeRepository = new PostalCodeRepository();
            ICountryRepository countryRepository = new CountryRepository();
            IStateRepository stateRepository = new StateRepository();
            IClientRouter clientRouter = new ExampleClientRouter();
            IUserAuthenticator userAuthenticator = new DatabaseUserAutheticator();

            // Set connection strings for things not needing faking the client routing
            // Why not in config? Because these would not exist in the real world
            //      Client Routing would utilize another method
            string connectionString = "Server=(local);Database=PostalCode;TRUSTED_CONNECTION=True;";
            countryRepository.SetConnectionString(connectionString);
            stateRepository.SetConnectionString(connectionString);

            IPostalCodeDataPackService service = new PostalCodeDataPackService(postalCodeRepository
                , countryRepository, stateRepository, clientRouter, userAuthenticator);

            return service.GetPostalCodeListByPostalCode(postalCode, userName, includeCity);
        }
    }
}
