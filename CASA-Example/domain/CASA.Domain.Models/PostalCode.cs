namespace CASA.Domain.Models
{
    public class PostalCode
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryAbbrev2 { get; set; }
        public string CountryAbbrev3 { get; set; }
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public int RegionTypeId { get; set; }
        public string RegionTypeName { get; set; }
        public string RegionAbbrev2 { get; set; }
        public int CountyId { get; set; }
        public string CountyName { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
    }
}