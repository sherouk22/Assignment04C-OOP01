using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04OOP01.Enums
{

    [Flags]
    public enum Permissions:byte
    {
        Read = 1,
        write = 2,
        Delete = 4,
        Execute = 8
    }
}
