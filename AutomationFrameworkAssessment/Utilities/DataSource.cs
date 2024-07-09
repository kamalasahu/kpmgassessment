using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPMG.OrangeHRMAutomationFramework.Utilities
{
    public class DataSource
    {
        public static object[] InValidLoginData()
        {
            object[] dataSet1 = new object[3];
            dataSet1[0] = "John";
            dataSet1[1] = "admin123";
            dataSet1[2] = "Invalid credentials";
            object[] dataSet2 = new object[3];
            dataSet2[0] = "Peter";
            dataSet2[1] = "admin123";
            dataSet2[2] = "Invalid credentials";



            object[] allData = new object[2];
            allData[0] = dataSet1;
            allData[1] = dataSet2;

            return allData;
        }
    }
}
