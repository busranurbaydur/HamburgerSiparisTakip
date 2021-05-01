using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerSiparisTakip
{
    public class Extra:IEntity<int>
    {
        public int Id { get; set; }
        public string ExtraAdi { get; set; }
        public decimal Fiyati { get; set; }

    }
}
