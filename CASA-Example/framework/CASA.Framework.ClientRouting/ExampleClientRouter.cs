using CASA.Framework.ClientRouting.Contracts;

namespace CASA.Framework.ClientRouting
{
    public class ExampleClientRouter : IClientRouter
    {
        public string GetConnectionStringForJWT(string jWT)
        {
            // This simulates for the local database
            return "Server=(local);Database=PostalCode;Trusted_Connection=true;";
        }
    }
}
