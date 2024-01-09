using PhoneNumber.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumber.Services
{
    public class PhoneInfoService : IPhoneInfoService
    {
        private readonly ICountryService countryService;
        private readonly ICountryDetailService countryDetailService;

        public PhoneInfoService(ICountryService countryService, ICountryDetailService countryDetailService)
        {
            this.countryService = countryService;
            this.countryDetailService = countryDetailService;
        }

        public object GetCountryInfo(string phoneNumber)
        {
            // Extract country code from the phone number (assuming it's the first digits)
            if (int.TryParse(phoneNumber.Substring(0, 3), out int countryCode))
            {
                var country = countryService.GetCountryByCode(countryCode);

                if (country != null)
                {
                    var countryDetails = countryDetailService.GetCountryDetailsByCountryId(country.Id);

                    var result = new
                    {
                        number = phoneNumber,
                        country = new
                        {
                            countryCode = country.CountryCode,
                            name = country.Name,
                            countryIso = country.CountryIso,
                            countryDetails = countryDetails.Select(cd => new
                            {
                                operatorName = cd.Operator,
                                operatorCode = cd.OperatorCode
                            }).ToList()
                        }
                    };

                    return result;
                }
            }

            return null;
        }
    }
}
