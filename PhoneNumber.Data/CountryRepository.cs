using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumber.Data
{
    public class CountryDetailRepository : ICountryDetailsRepository
    {
        private List<CountryDetails> countryDetails;

        public CountryDetailRepository()
        {
            // Initialize with data from Figure 2
            countryDetails = new List<CountryDetails>
        {
            new CountryDetails { Id = 1, CountryId = 1, Operator = "MTN Nigeria", OperatorCode = "MTN NG" },
            new CountryDetails { Id = 2, CountryId = 1, Operator = "Airtel Nigeria", OperatorCode = "ANG" },
            new CountryDetails { Id = 3, CountryId = 1, Operator = "9 Mobile", OperatorCode = "ETN" },
            new CountryDetails { Id = 4, CountryId = 1, Operator = "Globacom Nigeria", OperatorCode = "GLO NG" },
            new CountryDetails { Id = 5, CountryId = 2, Operator = "Vodafone Ghana", OperatorCode = "Vodafone GH" },
            new CountryDetails { Id = 6, CountryId = 2, Operator = "MTN Ghana", OperatorCode = "MTN Ghana" },
            new CountryDetails { Id = 7, CountryId = 2, Operator = "Tigo Ghana", OperatorCode = "Tigo Ghana" },
            new CountryDetails { Id = 8, CountryId = 3, Operator = "MTN Benin", OperatorCode = "MTN Benin" },
            new CountryDetails { Id = 9, CountryId = 3, Operator = "Moov Benin", OperatorCode = "Moov Benin" },
            new CountryDetails { Id = 10, CountryId = 4, Operator = "MTN Côte d'Ivoire", OperatorCode = "MTN CIV" },
        };
        }

        public List<CountryDetails> GetCountryDetailsByCountryId(int countryId)
        {
            return countryDetails.Where(cd => cd.CountryId == countryId).ToList();
        }
    }
}
