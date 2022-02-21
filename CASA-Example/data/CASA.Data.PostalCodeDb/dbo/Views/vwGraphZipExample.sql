Create VIEW vwGraphZipExample AS
SELECT pc.PostalCode, pc.CityId, c.CityName, pc.RegionId, r.RegionName, r.RegionAbbrev2, pc.CountyId, cty.CountyName, pc.CountryId, cnty.CountryName, cnty.CountryAbbrev2, cnty.CountryAbbrev3
FROM PostalCode pc
	INNER JOIN City c
		ON pc.CityId = c.Id
	INNER JOIN Region r
		ON pc.Regionid = r.Id
	INNER JOIN County cty
		ON pc.CountyId = cty.Id
	INNER JOIN Country cnty
		ON pc.CountryId = cnty.Id