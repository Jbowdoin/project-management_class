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

        // override object.Equals
        public override bool Equals(Object requirement)
        {
            if (requirement == null || GetType() != requirement.GetType())
            {
                return false;
            }
            RequirementsClass compareRequirement = requirement as RequirementsClass;
            if (compareRequirement != null && compareRequirement.requirementsSimpleDesc.Equals(this.requirementsSimpleDesc))
            {
                return true;
            }
            return false;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }
    }
}
