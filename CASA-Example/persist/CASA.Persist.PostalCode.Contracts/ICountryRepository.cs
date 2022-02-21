namespace CASA.Persist.PostalCode.Contracts
{
    public interface ICountryRepository
    {
        public int GetByStateId(int stateId);
        public int GetByStateAbbrev(string stateAbbrev);
        public int GetByCityId(int cityId);

        public int GetByPostalCode(string postalCode);

        // TODO: This should be replaced with dependency injection
        public void SetConnectionString(string connectionString);
    }
}
