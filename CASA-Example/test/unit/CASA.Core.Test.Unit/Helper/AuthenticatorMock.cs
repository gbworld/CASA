using CASA.Framework.Authentication.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASA.Core.Test.Unit.Helper
{
    public class AuthenticatorMock : IUserAuthenticator
    {
        public bool IsUserAuthenticated(string JWT)
        {
            string userName;
            int countryId, regionId;

            string[] keyValues = JWT.Split(';');
            if (keyValues.Length == 0)
                throw new ApplicationException("Did not supply correct JWT Format");
            else
            {
                userName = keyValues[0].Split('=')[1];
                countryId = int.Parse(keyValues[1].Split('=')[1]);
                regionId = int.Parse(keyValues[2].Split('=')[1]);
            }

            switch(userName)
            {
                case "FullAccessUS":
                    return true;
                case "NoAcccessUS":
                    //Has to be updated once more than US
                    return false;
                case "SomeStates":
                    switch(regionId)
                    {
                        case 1:
                        case 5:
                        case 12:
                        case 13:
                        case 21:
                        case 22:
                        case 37:
                        case 45:
                        case 47:
                        case 51:
                        case 54:
                            return true;
                        default:
                            return false;
                    }
                case "MostStates":
                    switch(regionId)
                    {
                        case 47:
                        case 60:
                        case 66:
                        case 69:
                        case 72:
                        case 78:
                            return false;
                        default:
                            return true;
                    }
                case "TennesseeOnly":
                    if(regionId == 47)
                        return true;
                    else
                        return false;
                default:
                   return false;
            }
        }
    }
}
