using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectaholic
{
    enum RiskStatusEnum
    {
        VeryLow,
        Low,
        Medium,
        High,
        Critical
    }

    class RiskClass
    {
        string riskName;
        string riskDescription;
        RiskStatusEnum riskStatus;
    }
}
