using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyApp.Models
{
    public partial class Dynamic
    {
        public int Id { get; set; }
        public int CurrencyCode { get; set; }
        public decimal Value { get; set; }
        public DateTime DateTime { get; set; }

        public virtual Currency CurrencyCodeNavigation { get; set; }
    }
}
