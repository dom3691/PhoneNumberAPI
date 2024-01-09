using PhoneNumber.Domain.Entities;
using PhoneNumber.Domain.Interfaces.Data;
using PhoneNumber.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumber.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }

        public Country GetCountryByCode(int countryCode)
        {
            return countryRepository.GetCountryByCode(countryCode);
        }
    }
}
