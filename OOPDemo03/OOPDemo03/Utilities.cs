using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo03
{

    //A static class prevents the creation of an object (instance) of the class
    //Console con= new Console(); this will not work with a static class.
    //Math.Round, Math.Pow
    //Console.Writeline();, Console.Readline();
    internal static class Utilities
    {
        public static bool IsNameLength(string name, int minLength)
        {
            bool isValid = false;

            if (!string.IsNullOrEmpty(name) && name.Trim().Length >= minLength)
                    {
                isValid = true;
            }
            return isValid;
        }
    }
}
