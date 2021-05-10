using System;
using HelperSpace;
/*
Сухинин М.
Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На
выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password:
GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь
вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью
цикла do while ограничить ввод пароля тремя попытками.
*/
namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Кол-во попыток ввода пароля
            int tryCnt = 0;
            //Количество разрешенных попыток ввода пароля
            const int enableTryCnt = 3;

            do
            {
                //ввод логина и пароля
                string login = Helper.GetString("введите логин");
                string pass = Helper.GetString("введите пароль");
                //проверка правильности ввода
                if (AutorisationCheck(login, pass))
                {
                    Helper.Print("Добро пожаловать в GeekBrains", ConsoleColor.Green);
                    return;
                }
                else
                {
                    Helper.Print("Введен не правильный логин или пароль");
                    tryCnt++;
                }
            }
            while (tryCnt < enableTryCnt);
            Helper.Print("Ваш акаунт заблокирован, обратитесь к системному администратору", ConsoleColor.Red);
        }
        /// <summary>
        /// метод проверки логина и пароля
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="pass">пароль</param>
        /// <returns></returns>
        public static bool AutorisationCheck(string login, string pass)
        {
            if (login == "root" && pass == "GeekBrains")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
