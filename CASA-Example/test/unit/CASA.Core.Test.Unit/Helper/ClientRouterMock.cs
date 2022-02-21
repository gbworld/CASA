using CASA.Framework.ClientRouting.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASA.Core.Test.Unit.Helper
{
    public class ClientRouterMock : IClientRouter
    {
        public string GetConnectionStringForJWT(string jWT)
        {
            return "Server=(local);Database=PostalCode;Trusted_Connection=True;";
        }
    }
}
