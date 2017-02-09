using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    public class LeapYearValidator
    {
        public bool LeapYear(int value)
        {
            if (value % 4 == 0)
            {
                if (value % 100 == 0)
                {
                    if (value % 400 == 0)
                    {
                        return true;
                    }

                    return false;
                }

                return true;
            }

            return false;

            //if (value % 4 == 0 && value%100 == 0 && value%400 == 0)
            //{
            //    return true;
            //}
            //if (value%4 == 0 && value%100 !=0)
            //{
            //    return true;
            //}
            //return false;
        }
    }
}
