using System;
using System.Collections.Generic;
using System.Text;

namespace Homework05_1
{
    class MyExceptions
    {

        public class ErrorLenghtString : ApplicationException
        {
            public ErrorLenghtString()
            {
                Console.WriteLine(" длина логина должна быть в пределах от 2 до 10");
            }
        }

        public class FirstCharIsDigit : ApplicationException
        {
            public FirstCharIsDigit()
            {
                Console.WriteLine("0 не может быть первым символом");
            }
        }

        public class InputNotLatterorDigit : ApplicationException
        {
            public InputNotLatterorDigit()
            {
                Console.WriteLine("введен не верный символ");
            }
        }
    }
}
