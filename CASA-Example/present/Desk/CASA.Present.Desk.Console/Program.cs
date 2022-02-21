// See https://aka.ms/new-console-template for more information
using CASA.Present.Desk.Console;

// This could be pulled from command line, but not sure how in .NET 6 yet
string postalCode = "37221";
string userName = "TennesseeOnly";

var PostalCodeRetriever = new PostalCodeRetriever();
var list = PostalCodeRetriever.GetPostalCodesForPostalCode(postalCode, userName);

foreach(var code in list)
{
    Console.WriteLine("Postal Code");
    Console.WriteLine("---------------------------");
    Console.WriteLine("Id = {0}", code.Id.ToString());
    Console.WriteLine("Postal Code = {0}", code.Code.ToString());
    Console.WriteLine("City = {0}", code.CityName.ToString());
    Console.WriteLine("County = {0}", code.CountyName.ToString());
    Console.WriteLine("State = {0}", code.RegionAbbrev2.ToString());
    Console.WriteLine("Country = {0}", code.CountryAbbrev3.ToString());

}

Console.Read();
