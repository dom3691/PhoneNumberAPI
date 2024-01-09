using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumber.Domain.Interfaces.Services
{
    public interface IPhoneInfoService
    {
        object GetCountryInfo(string phoneNumber);

    }
}
