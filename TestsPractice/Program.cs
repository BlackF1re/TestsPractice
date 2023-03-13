using System;

namespace TestsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, m;
            string date = null;
            bool authorizationIsPassed, result;

            Console.WriteLine("Выберите действие. 1 - выбор большего значения");
            Console.WriteLine("2 - перевод метров в сантиметры");
            Console.WriteLine("3 - существует дата или нет");
            Console.WriteLine("4 - Метод авторизации, на входе логин и пароль пользователя, на выходе bool значение;");
            Console.WriteLine("5 - Метод регистрации, на входе логин, пароль, почта, дата рождения, на выходе bool");
            string choice = Console.ReadLine();
 
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Введите два числа:");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Bigger(a, b));
                    break;
                
                case "2":
                    Console.WriteLine("введите кол-во метров для перевода в сантиметры:");
                    m = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine(Metric(m));
                    break;
                
                case "3":
                    Console.WriteLine("введите дату для проверки:");
                    date = Console.ReadLine();
                    bool isDate = Datetime(date);
                    if (isDate is true)
                        Console.WriteLine("Это дата");
                    else
                    {
                        Console.WriteLine("Это не дата");
                    }
                    break;
                
                case "4":
                    Console.WriteLine("Ваше имя - Sam");
                    break;
                
                case "5":
                    Console.WriteLine("Ваше имя - Sam");
                    break;
            }

            Console.Read();
        }

        public static bool Bigger(float a, float b) //· Метод для нахождения наибольшего из 2 чисел, возвращает bool значение
        {
            bool result = true;
            if (a > b)
                result = true;
            if (a < b)
                result = false;
            if (a == b)
            {
                Console.WriteLine("equal");
            }
            return result;
        }

        public static float Metric(float m)
        {
            float cm = m * 100;
            return cm;
        }

        public static bool Datetime(string date)
        {
            DateTime dateTime;
            return DateTime.TryParse(date, out dateTime);
        }
    }
}