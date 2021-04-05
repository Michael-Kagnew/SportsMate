using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsMate.Utilities
{
    public class UserInputValidator

    {
        public static Boolean ValidateDateLessThanCurrent(DateTime date)
        {
            return (DateTime.Now > date ? true : false);
        }

        public static Boolean ValidateDateGreaterThanCurrent(DateTime date)
        {
            return (date > DateTime.Now ? true : false);
        }
    }
}
