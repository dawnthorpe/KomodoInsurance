using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceProject.Data
{
    class Developer
    {
        public string DeveloperName { get; set; }

        public int DeveloperID { get; set; }

        public bool HasPluralsight { get; set; }

        public Developer(string developerName, int developerID, bool hasPluralsight)
        {
            DeveloperName = developerName;
            DeveloperID = developerID;
            HasPluralsight = hasPluralsight;




        }
        public Developer()
        {

        }
    }
}
