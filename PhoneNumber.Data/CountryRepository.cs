using PhoneNumber.Domain.Entities;
using PhoneNumber.Domain.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumber.Data
{
    public class CountryRepository : ICountryRepository
    {
        private List<Country> countries;

        public CountryRepository()
        {
            // Initialize with data from Figure 1
            countries = new List<Country>
        {
            new Country { Id = 1, CountryCode = 234, Name = "Nigeria", CountryIso = "NG" },
            new Country { Id = 2, CountryCode = 233, Name = "Ghana", CountryIso = "GH" },
            new Country { Id = 3, CountryCode = 229, Name = "Benin Republic", CountryIso = "BN"},
            new Country { Id = 4, CountryCode = 225, Name = "Côte d'Ivoire", CountryIso = "CIV"}
        };
        }

        public Country GetCountryByCode(int countryCode)
        {
            return countries
                .FirstOrDefault(c => c.CountryCode == countryCode);
        }
    }
}
