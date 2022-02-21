using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASA.Core.Test.Integ.Helper
{
    [TestClass]
    public class CoreTestBase
    {
        public static string ConnectionString { get; set; }
        static CoreTestBase()
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
