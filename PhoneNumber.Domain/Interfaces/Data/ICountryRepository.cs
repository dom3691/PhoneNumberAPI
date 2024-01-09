using PhoneNumber.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumber.Domain.Interfaces.Data
{
    public interface ICountryRepository
    {
        Country GetCountryByCode(int countryCode);

    }
}
