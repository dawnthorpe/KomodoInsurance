using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceProject.Data
{
    class DeveloperRepo
    {
        List<Developer> MasterDevList = new List<Developer>();


        public void AddDevelopersToMasterDevList(Developer developer)
        {
            MasterDevList.Add(developer);

        } 
        
        public Developer FindByDevID(int ID)
        {
            Developer result = null;
            foreach (Developer item in MasterDevList)
            {
                if (item.DeveloperID == ID)
                {
                    result = item;
                }
                
            }
            return result;
         }

        public List<Developer> ReturningDevList()
        {
            return MasterDevList;
        }

    }
}

