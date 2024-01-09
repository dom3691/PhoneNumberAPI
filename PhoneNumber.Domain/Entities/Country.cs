using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumber.Domain.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public int CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
    }
}
