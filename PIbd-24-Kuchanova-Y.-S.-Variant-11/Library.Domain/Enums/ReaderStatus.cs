using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Enums
{
    [Flags]
    public enum ReaderStatus
    {
        None = 0,
        Active = 1,
        HasOverdue = 2,
        Blocked = 4,
        Debtor = HasOverdue | Blocked
    }
}
