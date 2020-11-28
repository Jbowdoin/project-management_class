using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectaholic
{
    enum RequirementsStatusEnum
    {
        Unimplemented,
        Incomplete,
        Implemented
    }

    class RequirementsClass
    {
        string requirementsSimpleDesc;
        string requirementsDetailDesc;
        RequirementsStatusEnum status;
    }
}
