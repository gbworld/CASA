namespace CASA.Persist.PostalCode.Contracts
{
    public interface IPostalCodeRepository
    {
        // TODO: Figure why using statement not working
        /// <summary>
        /// Get full information for a postal code
        /// </summary>
        /// <param name="code"></param>
        /// <returns>Complete information about the postal code</returns>
        /// <remarks>
        /// This is similar to pulling information for a single adjustment/balance (NEW)
        /// </remarks>
        public IList<Domain.Models.PostalCode> GetByPostalCode(string code);

        /// <summary>
        /// Get full information for all postal codes in a city
        /// </summary>
        /// <param name="city"></param>
        /// <param name="stateName"></param>
        /// <returns></returns>
        /// <remarks>
        /// This is similar to getting all balances for an entity (CURRENT)
        /// </remarks>
        public IList<Domain.Models.PostalCode> GetPostalCodesByCityNameAndRegionAbbrev(string cityName, string regionAbbrev);

        //Variation by IDs
        public IList<Domain.Models.PostalCode> GetPostalCodesByCityId(int cityId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stateName"></param>
        /// <returns></returns>
        /// <remarks> 
        /// This is more akin to getting all for an engagement (NEW)
        /// </remarks>
        public IList<Domain.Models.PostalCode> GetPostalCodesByStateName(string stateName);


        // TODO: This should be replaced with dependency injection
        public void SetConnectionString(string connectionString);
    }
}