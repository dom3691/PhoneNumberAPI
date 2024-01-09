using PhoneNumber.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumber.Domain.Interfaces.Data
{
    public interface ICountryDetailsRepository
    {
        List<CountryDetails> GetCountryDetailsByCountryId(int countryId);

    }
}
