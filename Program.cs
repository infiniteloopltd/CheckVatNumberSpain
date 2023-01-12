using System.ServiceModel;

namespace ViesCheckSpain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vies = new vies.checkVatPortTypeClient(new BasicHttpsBinding(BasicHttpsSecurityMode.Transport), new EndpointAddress("https://ec.europa.eu/taxation_customs/vies/services/checkVatService"));
            var countryCode = "ES";
            var vatNumber = "B83891812";
            var traderName = "Rodrisa Automoviles";
            var traderCompanyType = "";
            var traderStreet = "Avda. Reina Victoria";
            var traderPostcode = "28430";
            var traderCity = "Madrid";
            var requesterCountryCode = "";
            var requesterVatNumber = "";
            bool valid;
            string traderAddress;
            vies.matchCode traderNameMatch;
            vies.matchCode traderCompanyTypeMatch;
            vies.matchCode traderStreetMatch;
            vies.matchCode traderPostcodeMatch;
            vies.matchCode traderCityMatch;
            string requestIdentifier;
            vies.Endpoint.EndpointBehaviors.Add(new MessageInspectorBehavior());
            vies.checkVatApprox(ref countryCode, ref vatNumber, ref traderName, ref traderCompanyType, ref traderStreet,
                ref traderPostcode, ref traderCity, requesterCountryCode, requesterVatNumber, out valid,
                out traderAddress, out traderNameMatch, out traderCompanyTypeMatch, out traderStreetMatch,
                out traderPostcodeMatch, out traderCityMatch, out requestIdentifier); // Spain
            //vies.checkVat(ref country, ref vat, out blnValid, out name, out address); // All other EU
        }
    }
}