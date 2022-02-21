using CASA.Persist.PostalCode.Contracts;
using System.Data;
using System.Data.SqlClient;

namespace CASA.Persist.PostalCode
{
    public class StateRepository : IStateRepository
    {
        public string ConnectionString { get; internal set; }

        public int GetByCityId(int cityId)
        {
            // Parameters used to avoid SQL injection
            // TODO: This should technically not be select *
            var commandString = "SELECT DISTINCT RegionId FROM vwGraphZipExample WHERE CityId = @CityId";

            var conn = new SqlConnection(this.ConnectionString);
            var cmd = new SqlCommand(commandString, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@CityId", cityId);

            int stateId = 0;

            try
            {
                conn.Open();
                // TODO: Should be adjusted for ExecuteScalar as this is a single value
                stateId = (int)cmd.ExecuteScalar();

                return stateId;

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

        public int GetByPostalCode(string postalCode)
        {
            // Parameters used to avoid SQL injection
            // TODO: This should technically not be select *
            var commandString = "SELECT DISTINCT RegionId FROM vwGraphZipExample WHERE PostalCode = @PostalCode";

            var conn = new SqlConnection(this.ConnectionString);
            var cmd = new SqlCommand(commandString, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@PostalCode", postalCode);

            int stateId = 0;

            try
            {
                conn.Open();
                // TODO: Should be adjusted for ExecuteScalar as this is a single value
                stateId = (int)cmd.ExecuteScalar();

                return stateId;

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

        public int GetByStateAbbrev(string stateAbbrev)
        {
            // Parameters used to avoid SQL injection
            // TODO: This should technically not be select *
            var commandString = "SELECT DISTINCT RegionId FROM vwGraphZipExample WHERE RegionAbbrev2 = @StateAbbrev";

            var conn = new SqlConnection(this.ConnectionString);
            var cmd = new SqlCommand(commandString, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@StateAbbrev", stateAbbrev);

            int stateId = 0;

            try
            {
                conn.Open();
                // TODO: Should be adjusted for ExecuteScalar as this is a single value
                stateId = (int)cmd.ExecuteScalar();

                return stateId;

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

        public void SetConnectionString(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
