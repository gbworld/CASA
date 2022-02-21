using CASA.Persist.PostalCode.Contracts;
using System.Data;
using System.Data.SqlClient;

namespace CASA.Persist.PostalCode
{
    public class PostalCodeRepository : IPostalCodeRepository
    {
        public string ConnectionString { get; internal set; }

        public IList<Domain.Models.PostalCode> GetByPostalCode(string code)
        {
            // Parameters used to avoid SQL injection
            // TODO: This should technically not be select *
            var commandString = "SELECT * FROM vwGraphZipExample WHERE PostalCode = @PostalCode";

            var conn = new SqlConnection(this.ConnectionString);
            var cmd = new SqlCommand(commandString, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@PostalCode", code);

            try
            {
                conn.Open();
                // TODO: Should be adjusted for ExecuteScalar as this is a single value
                SqlDataReader reader = cmd.ExecuteReader();

                var returnList = new List<Domain.Models.PostalCode>();

                while(reader.Read())
                {
                    // TODO: This could be automapped
                    var postalCode = new Domain.Models.PostalCode()
                    {
                        Id = (int)reader["Id"],
                        Code = reader["PostalCode"].ToString(),
                        CountryId = (int)reader["CountryId"],
                        CountryName = reader["CountryName"].ToString(),
                        CountryAbbrev2 = reader["CountryAbbrev2"].ToString(),
                        CountryAbbrev3 = reader["CountryAbbrev3"].ToString(),
                        RegionId = (int)reader["RegionId"],
                        RegionName = reader["RegionName"].ToString(),
                        RegionAbbrev2 = reader["RegionAbbrev2"].ToString(),
                        RegionTypeId = (int)reader["RegionTypeId"],
                        RegionTypeName = reader["RegionTypeName"].ToString(),
                        CountyId = (int)reader["CountyId"],
                        CountyName = reader["CountyName"].ToString(),
                        CityId = (int)reader["CityId"],
                        CityName = reader["CityName"].ToString()
                    };

                    returnList.Add(postalCode);

                }

                return returnList;



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

        public IList<Domain.Models.PostalCode> GetPostalCodesByCityId(int cityId)
        {
            // Parameters used to avoid SQL injection
            // TODO: This should technically not be select *
            var commandString = "SELECT * FROM vwGraphZipExample WHERE CityId = @CityId";

            var conn = new SqlConnection(this.ConnectionString);
            var cmd = new SqlCommand(commandString, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@CityId", cityId);

            // Set initial Value
            IList<Domain.Models.PostalCode> returnList = new List<Domain.Models.PostalCode>();

            try
            {
                conn.Open();
                // TODO: Should be adjusted for ExecuteScalar as this is a single value
                SqlDataReader reader = cmd.ExecuteReader();

                // Assumes 1 value
                while (reader.Read())
                {
                    // TODO: This could be automapped
                    var model = new Domain.Models.PostalCode()
                    {
                        Id = (int)reader["Id"],
                        Code = reader["PostalCode"].ToString(),
                        CountryId = (int)reader["CountryId"],
                        CountryName = reader["CountryName"].ToString(),
                        CountryAbbrev2 = reader["CountryAbbrev2"].ToString(),
                        CountryAbbrev3 = reader["CountryAbbrev3"].ToString(),
                        RegionId = (int)reader["RegionId"],
                        RegionName = reader["RegionName"].ToString(),
                        RegionAbbrev2 = reader["RegionAbbrev2"].ToString(),
                        RegionTypeId = (int)reader["RegionTypeId"],
                        RegionTypeName = reader["RegionTypeName"].ToString(),
                        CountyId = (int)reader["CountyId"],
                        CountyName = reader["CountyName"].ToString(),
                        CityId = (int)reader["CityId"],
                        CityName = reader["CityName"].ToString()
                    };

                    returnList.Add(model);
                }



            }
            catch (Exception ex)
            {
                string tempToTest = "";
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }


            return returnList;
        }

        public IList<Domain.Models.PostalCode> GetPostalCodesByCityNameAndRegionAbbrev(string cityName, string regionAbbrev)
        {
            // Parameters used to avoid SQL injection
            // TODO: This should technically not be select *
            var commandString = "SELECT * FROM vwGraphZipExample WHERE CityName = @CityName and RegionAbbrev2 = @RegionAbbrev2";

            var conn = new SqlConnection(this.ConnectionString);
            var cmd = new SqlCommand(commandString, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@RegionAbbrev2", regionAbbrev);
            cmd.Parameters.AddWithValue("@CityName", cityName);

            // Set initial Value
            IList<Domain.Models.PostalCode> returnList = new List<Domain.Models.PostalCode>();

            try
            {
                conn.Open();
                // TODO: Should be adjusted for ExecuteScalar as this is a single value
                SqlDataReader reader = cmd.ExecuteReader();

                // Assumes 1 value
                while (reader.Read())
                {
                    // TODO: This could be automapped
                    var model = new Domain.Models.PostalCode()
                    {
                        Id = (int)reader["Id"],
                        Code = reader["PostalCode"].ToString(),
                        CountryId = (int)reader["CountryId"],
                        CountryName = reader["CountryName"].ToString(),
                        CountryAbbrev2 = reader["CountryAbbrev2"].ToString(),
                        CountryAbbrev3 = reader["CountryAbbrev3"].ToString(),
                        RegionId = (int)reader["RegionId"],
                        RegionName = reader["RegionName"].ToString(),
                        RegionAbbrev2 = reader["RegionAbbrev2"].ToString(),
                        RegionTypeId = (int)reader["RegionTypeId"],
                        RegionTypeName = reader["RegionTypeName"].ToString(),
                        CountyId = (int)reader["CountyId"],
                        CountyName = reader["CountyName"].ToString(),
                        CityId = (int)reader["CityId"],
                        CityName = reader["CityName"].ToString()
                    };

                    returnList.Add(model);
                }



            }
            catch (Exception ex)
            {
                string tempToTest = "";
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }


            return returnList;
        }

        public IList<Domain.Models.PostalCode> GetPostalCodesByStateName(string stateName)
        {
            throw new NotImplementedException();
        }

        public void SetConnectionString(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}