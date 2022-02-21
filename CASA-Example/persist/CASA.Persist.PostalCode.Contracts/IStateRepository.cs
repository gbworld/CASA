namespace CASA.Persist.PostalCode.Contracts
{
    public interface IStateRepository
    {
        public int GetByCityId(int cityId);
        public int GetByStateAbbrev(string stateAbbrev);

        public int GetByPostalCode(string postalCode);

        // TODO: This should be replaced with dependency injection
        public void SetConnectionString(string connectionString);
    }
}
