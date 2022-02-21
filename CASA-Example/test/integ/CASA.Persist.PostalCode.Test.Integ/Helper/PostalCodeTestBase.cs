using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CASA.Persist.PostalCode.Test.Integ
{
    [TestClass]
    public class PostalCodeTestBase
    {
        public static string ConnectionString { get; set; }
        static PostalCodeTestBase()
        {
            Configure();
        }

        private static void Configure()
        {
            //TODO: This can be pulled from other locations, like configuration
            ConnectionString = "Server=(local);Database=PostalCode;Trusted_Connection=true;";
        }
    }
}
