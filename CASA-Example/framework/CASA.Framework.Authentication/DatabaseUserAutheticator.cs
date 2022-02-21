using CASA.Framework.Authentication.Contracts;
using System.Data.SqlClient;

namespace CASA.Framework.Authentication
{
    public class DatabaseUserAutheticator : IUserAuthenticator
    {
        // This is only because database is not the norm in the real world
        private string ConnectionString = "Server=(local);Database=PostalCode;Trusted_Connection=true;";

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


            if (!IsCountryAuthenticated(countryId, userName))
                return false;

            if (!IsRegionAuthenticated(regionId, userName))
                return false;

            return true;

        }

        private bool IsRegionAuthenticated(int regionId, string userName)
        {
            string query = "SELECT DISTINCT * FROM vwRegionAuthentication WHERE UserName = @UserName AND RegionId = @RegionId";
            var conn = new SqlConnection(ConnectionString);
            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserName", userName);
            cmd.Parameters.AddWithValue("@RegionId", regionId);

            try
            {
                conn.Open();

                var reader = cmd.ExecuteReader();

                if (!reader.Read())
                    return false;


                return (bool)reader["HasPermission"];

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }

        private bool IsCountryAuthenticated(int countryId, string userName)
        {
            string query = "SELECT DISTINCT * FROM vwCountryAuthentication WHERE UserName = @UserName AND CountryId  = @CountryId";
            var conn = new SqlConnection(ConnectionString);
            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserName", userName);
            cmd.Parameters.AddWithValue("@CountryId", countryId);

            try
            {
                conn.Open();

                var reader = cmd.ExecuteReader();

                if (!reader.Read())
                    return false;

                return (bool)reader["HasPermission"];
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}