using System;
using System.IO;
/*Сухинин М.
Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
Создайте структуру Account, содержащую Login и Password.
*/
namespace Homework04_04
{
    public struct Account
    {
        private string login;
        private string pass;

        private const string log = "root";
        private const string passW = "GeekBrains";
      
        private bool AutorisationCheck(string login, string pass)
        {
            return (login == log && pass == passW) ? true : false;
        }
        private bool AutorisationCheck(string file, out string[] res)
        {

            res = new string[2];
            try
            {
                StreamReader sr = new StreamReader($"..\\..\\{file}");

                // Считываем массив
                for (int i = 0; i < res.Length; i++)
                {
                    res[i] = (sr.ReadLine());
                }
                sr.Close();

                return (res[0] == log && res[1] == passW) ? true : false;
            }
            catch (Exception ex)
            {
                Helper.Helper.Print(ex.Message, ConsoleColor.Yellow);
                return false;
            }

        }
        /// <summary>
        /// Попытка авторизации с вводом имени пользователя и пароля 
        /// </summary>
        /// <param name="enableTryCnt">кол-во попыток</param>
        public void TryAutorisation(int enableTryCnt)
        {
            //Кол-во попыток ввода пароля
            int tryCnt = 0;
            //Количество разрешенных попыток ввода пароля
            do
            {
                string login = Helper.Helper.GetString("введите логин");
                string pass = Helper.Helper.GetString("введите пароль");
                //проверка правильности ввода
                if (AutorisationCheck(login, pass))
                {
                    Helper.Helper.Print("Добро пожаловать в GeekBrains", ConsoleColor.Green);
                    return;
                }
                else
                {
                    Helper.Helper.Print("Введен не правильный логин или пароль");
                    tryCnt++;
                }
            }
            while (tryCnt < enableTryCnt);
            Helper.Helper.Print("Ваш акаунт заблокирован, обратитесь к системному администратору", ConsoleColor.Red);
        }
        /// <summary>
        /// Попытка авторизации с указанием файла
        /// </summary>
        /// <param name="enableTryCnt"></param>
        /// <param name="res">кол-во попыток</param>
        public void TryAutorisation(int enableTryCnt, out string[] res)
        {
            //Кол-во попыток ввода пароля
            int tryCnt = 0;
            //Количество разрешенных попыток ввода пароля
            do
            {
                string filename = Helper.Helper.GetString("введите имя файла в формате name.txt");
                //проверка правильности ввода
                if (AutorisationCheck(filename, out res))
                {
                    Helper.Helper.Print("Добро пожаловать в GeekBrains", ConsoleColor.Green);
                    return;
                }
                else
                {
                    Helper.Helper.Print("Введен не правильный логин или пароль");
                    tryCnt++;
                }
            }
            while (tryCnt < enableTryCnt);
            Helper.Helper.Print("Ваш акаунт заблокирован, обратитесь к системному администратору", ConsoleColor.Red);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account ac1 = new Account();
            string[] res;
            ac1.TryAutorisation(3, out res);
            Helper.Helper.Pause($"Пользователь: {res[0]} вошел в систепму");
            return;
            ac1.TryAutorisation(3);

        }
    }
}
