using System;
using System.Collections.Generic;
using System.Text;

namespace Homework05_3
{
 public static   class Logics
    {
        public static bool IsPermutationString(string firststring, string secondString)
        {
            bool check = false;
            if (firststring.Length != secondString.Length) return false;

            for (int i = 0; i < firststring.Length; i++)
            {
                if (firststring[i] != secondString[(secondString.Length -1)- i]) return false;
                else  check =true;
            }
            return check;
        }

    }
}
