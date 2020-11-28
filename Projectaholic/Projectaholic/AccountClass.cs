using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectaholic
{
    class AccountClass
    {
        string accountName;
        DateTime accountCreateDate;
        string accountLocation;
        int accountPassHash;
        string accountDescription;
        List<EffortClass> accountEfforts;
    }

    class ManagerClass : AccountClass
    {

    }
}
