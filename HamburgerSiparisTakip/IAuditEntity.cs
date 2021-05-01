using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerSiparisTakip
{
    public interface IAuditEntity<Type>
    {
        DateTime CreateTime { get; set; }
        Type CreateUser { get; set; }
    }
}
