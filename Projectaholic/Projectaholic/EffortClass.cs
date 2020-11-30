using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectaholic
{
    
    class EffortClass
    {
        enum EffortTypeEnum
        {
            Requireents_Analysis,
            Designing,
            Coding,
            Testing,
            ProjectManagement
        }

        AccountClass        effortMember;
        string              effortDescription;
        DateTime            effortDate;
        int                 effortHours;
        ProjectClass        effortProject;
        RequirementsClass   effortRequirement;
        EffortTypeEnum      effortType;
    }
}
