using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyApp.Models
{
    public partial class Currency
    {
        public Currency()
        {
            Dynamics = new HashSet<Dynamic>();
        }

        public int Code { get; set; }
        public string CharCode { get; set; }
        public int Nominal { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Dynamic> Dynamics { get; set; }
    }
}
