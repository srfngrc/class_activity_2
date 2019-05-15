using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_ClassActiv2
{
    class clsRestaurant
    {
        public string restaurantName { get; set; }
        public string address { get; set; }
        public int phoneNumber { get; set; }
        public string foodSpeciality { get; set; }
        public string owner { get; set; }

        // it returns the average income of the restaurant between those 2 days
        public int averageIncomePerDay (DateTime startDate, DateTime endDate)
        {
            return 590;
        }
        //this method modifies the current menu, updating it with the dishes indicated
        public void modifyTheCurrentMenu(List<string> dishes)
        {
            // code goes here
        }
        public void deleteOneMenu(string menuNumberX)
        {
            // code goes here
        }
        // it returns the number of customers inside the restaurant at a specific day and hour and minute
        public int numberOfcurrentCustomer(DateTime thismoment)
        {
            return 23;
        }
    }
}
