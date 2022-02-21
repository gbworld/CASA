using CASA.Domain.Models;
using HotChocolate.Types;

namespace CASA.Domain.Graph.Models
{
    public class PostalCodeType : ObjectType<PostalCode>
    {
        protected override void Configure(IObjectTypeDescriptor<PostalCode> descriptor)
        {
            // TODO: Fix to proper types
            descriptor.Field(a => a.Id).Type<IntType>();
            descriptor.Field(a => a.Code).Type<StringType>();
            descriptor.Field(a => a.CountryId).Type<IntType>();
            descriptor.Field(a => a.CountryName).Type<StringType>();
            descriptor.Field(a => a.CountryAbbrev2).Type<StringType>();
            descriptor.Field(a => a.CountryAbbrev3).Type<StringType>();
            descriptor.Field(a => a.RegionId).Type<IntType>();
            descriptor.Field(a => a.RegionName).Type<StringType>();
            descriptor.Field(a => a.RegionAbbrev2).Type<StringType>();
            descriptor.Field(a => a.RegionTypeId).Type<IntType>();
            descriptor.Field(a => a.CountyId).Type<IntType>();
            descriptor.Field(a => a.CountyName).Type<StringType>();
            descriptor.Field(a => a.CityId).Type<IntType>();
            descriptor.Field(a => a.CityName).Type<StringType>();

            base.Configure(descriptor);
        }
    }
}