# CheckVatNumberSpain
Check a Spanish VAT number using the VIES service

Sample Request
```
<s:Envelope xmlns:s="http://schemas.xmlsoap.org/soap/envelope/">
  <s:Body xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
    <checkVatApprox xmlns="urn:ec.europa.eu:taxud:vies:services:checkVat:types">
      <countryCode>ES</countryCode>
      <vatNumber>B83891812</vatNumber>
      <traderName>Rodrisa Automoviles</traderName>
      <traderCompanyType />
      <traderStreet>Avda. Reina Victoria</traderStreet>
      <traderPostcode>28430</traderPostcode>
      <traderCity>Madrid</traderCity>
      <requesterCountryCode />
      <requesterVatNumber />
    </checkVatApprox>
  </s:Body>
</s:Envelope>
```

Sample Response
```
<env:Envelope xmlns:env="http://schemas.xmlsoap.org/soap/envelope/">
    <env:Header/>
    <env:Body>
        <ns2:checkVatApproxResponse xmlns:ns2="urn:ec.europa.eu:taxud:vies:services:checkVat:types">
            <ns2:countryCode>ES</ns2:countryCode>
            <ns2:vatNumber>B83891812</ns2:vatNumber>
            <ns2:requestDate>2023-01-12+01:00</ns2:requestDate>
            <ns2:valid>true</ns2:valid>
            <ns2:traderName>Rodrisa Automoviles</ns2:traderName>
            <ns2:traderCompanyType></ns2:traderCompanyType>
            <ns2:traderStreet>Avda. Reina Victoria</ns2:traderStreet>
            <ns2:traderPostcode>28430</ns2:traderPostcode>
            <ns2:traderCity>Madrid</ns2:traderCity>
            <ns2:traderNameMatch>1</ns2:traderNameMatch>
            <ns2:traderCompanyTypeMatch>3</ns2:traderCompanyTypeMatch>
            <ns2:traderStreetMatch>1</ns2:traderStreetMatch>
            <ns2:traderPostcodeMatch>1</ns2:traderPostcodeMatch>
            <ns2:traderCityMatch>2</ns2:traderCityMatch>
            <ns2:requestIdentifier></ns2:requestIdentifier>
        </ns2:checkVatApproxResponse>
    </env:Body>
</env:Envelope>
```
