using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CountryHolidays
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Holiday { get; set; }
    }
}
