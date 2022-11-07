using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.Enum
{
    public enum PaymentStatusEnum
    {
        unitialized,
        initialized,
        pending,
        completed,
        failed
    }

    public enum DataTypeEnum { 
        numeric,
        alphanumeric,
        obj
    }
}
