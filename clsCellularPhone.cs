using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_ClassActiv2
{
    class clsCellularPhone
    {
        public string branch  { get; set; }
        public string version { get; set; }
        public int numbertocall { get; set; }
        public string color { get; set; }
        //public clsPerson owner { get; set; }
        public string owner { get; set; }

        // Calls another cellular phone number and returns true if everything went ok
        public bool makeAcall_to_aNumber(int numberToCall)
        {
        return true;
        }
        public void switchOnorOffthePhone(bool OnorOff)
        {
            // code goes here
        }
    }
}
