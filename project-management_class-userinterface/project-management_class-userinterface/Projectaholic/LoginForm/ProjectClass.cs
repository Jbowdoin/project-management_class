using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace Projectaholic
{
    struct ProjStrLngLimits
    {
        public ProjStrLngLimits(int min, int max)
        {
            minLimit = min;
            maxLimit = max;
        }
        int minLimit;
        int maxLimit;

        public static bool StrInLimits(string str, ProjStrLngLimits limits)
        {
            if (str.Length > limits.maxLimit || str.Length < limits.minLimit)
            {
                return false;
            }
            return true;
        }
    }

    class ProjectClass
    {
        string projectName;
        ProjStrLngLimits projNameLimit = new ProjStrLngLimits(3, 30);
        string projectDescription;
        ProjStrLngLimits projDescLimit = new ProjStrLngLimits(10, 400);
        AccountClass projectManager;
        List<AccountClass> projectMembers;
        List<RiskClass> projectRisks;
        List<RequirementsClass> projectFunctReq;
        List<RequirementsClass> projectNonFunctReq;
        List<EffortClass> projectEfforts;


        // PROPERTIES

        public string ProjectName
        {
            get
            {
                return projectName;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value) || !ProjStrLngLimits.StrInLimits(value, projNameLimit))
                {
                    return;
                }
                projectName = value;
            }
        }

        public string ProjectDescription
        {
            get
            {
                return projectDescription;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !ProjStrLngLimits.StrInLimits(value, projDescLimit))
                {
                    return;
                }
                projectDescription = value;
            }
        }


        // METHODS

        public ProjectClass(AccountClass manager, string name = "Untitled", string description = "Description is not provided.")
        {
            /*
            using (SqlConnection connection = new SqlConnection(SQLClass.GetSQLConnectionString()))
            {
                string insertQuery =
                    @"INSERT INTO dbo.Projects (manager, name, description) "
                    + @"VALUES (@manager, @name, @description)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@manager", manager);
                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@description", description);


                connection.Open();

                    int checkInsert = insertCommand.ExecuteNonQuery();
                    if (checkInsert < 0)
                    {
                        throw new DataException();
                    }
                   
    
                }*/

        }
        public void AddUserToProject(AccountClass user)
        {
            projectMembers.Add(user);
        }

        public void RemoveUserFromProject(AccountClass user)
        {
            projectMembers.Remove(user);
        }

        public void AddRequirementsToProject(RequirementsClass requirements, bool TFunctFNonFunct)
        {
            List<RequirementsClass> requirementsList = TFunctFNonFunct ? projectFunctReq : projectNonFunctReq;
            requirementsList.Add(requirements);
        }

        public void RemoveRequirementsFromProject(RequirementsClass requirements)
        {
            foreach (RequirementsClass r in projectFunctReq)
            {
                if (r.Equals(requirements))
                {
                    projectFunctReq.Remove(r);
                    return;
                }
            }
            foreach (RequirementsClass r in projectNonFunctReq)
            {
                if(r.Equals(requirements))
                {
                    projectNonFunctReq.Remove(r);
                    return;
                }
            }
        }



    }
}
