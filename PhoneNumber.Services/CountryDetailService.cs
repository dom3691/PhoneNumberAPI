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
    public class CountryDetailService : ICountryDetailService
    {
        private readonly ICountryDetailsRepository countryDetailRepository;

        public CountryDetailService(ICountryDetailsRepository countryDetailRepository)
        {
            this.countryDetailRepository = countryDetailRepository;
        }

        public List<CountryDetails> GetCountryDetailsByCountryId(int countryId)
        {
            return countryDetailRepository.GetCountryDetailsByCountryId(countryId);
        }
    }
}
