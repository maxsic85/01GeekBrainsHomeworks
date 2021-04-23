using System;
using static Homework05_1.MyExceptions;
using System.Text.RegularExpressions;

namespace Homework05_1
{
  public static class Logics
    {
      public  static bool CheckInputLogin(string login)
        {
            bool check = false;
            try
            {
                if (login.Length > 10 || login.Length < 2) throw new ErrorLenghtString();

                for (int i = 1; i < login.Length; i++)
                {
                    if (!Char.IsLetter(login[0])) throw new FirstCharIsDigit();
                    if (!Char.IsLetterOrDigit(login[i]) || (uint)(login[i]) > 1000) throw new InputNotLatterorDigit();
                    check = true;
                }
            }
            catch (ErrorLenghtString) { return false; }
            catch (FirstCharIsDigit) { return false; }
            catch (InputNotLatterorDigit) { return false; }
            Console.WriteLine($"login {login} is {((check) ? "correct" : "not correct") }");
            return check;
        }

       public static bool CheckInputLogin(string login, Regex rv)
        {
            bool check = false;
            check = (rv.IsMatch(login)) ? true : false;
            Console.WriteLine($"login {login} is {((check) ? "correct" : "not correct") }");
            return check;
        }

    }
}
