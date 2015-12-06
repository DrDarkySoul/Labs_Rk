using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Исключения_Имя_студента
{
    class Printer
    {
        public void print(string secN, string firsN, string fathN, Int16 age, string un, string gr)
        {
            Console.WriteLine(" Вы - {0} {1} {2}", secN, firsN, fathN);
            Console.WriteLine(" Вам {0} лет ", age);
            Console.WriteLine(" Вы учитесь в {0}, в группе под номером {1} ", un, gr);
        }
    }
    class HelloWorld
    {
        public void hello()
        {
            Console.WriteLine(" Hello, World");
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Первая программа
            HelloWorld hi = new HelloWorld();
            hi.hello();
            string secondName, firstName, fathersName, university, group, ageStr;
            Int16 ageInt;
            Printer output = new Printer();
            // Вторая программа
            try
            {
                Console.WriteLine(" Enter the first int");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);

                Console.WriteLine(" Enter the second int");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);

                int k = i / j;
                Console.WriteLine("The result of dividing {}0 by {1} is {2}", i,j,k);

            }
            catch (Exception e)
            {
                Console.WriteLine("Exeption {0}", e);
            }
            //Задание 4
            try
            {
                Console.WriteLine(" Привет, студент! Заполни форму:");
                Console.WriteLine(" Введи фамилию: ");
                secondName = Console.ReadLine();
                if (secondName == string.Empty)
                    throw new FormatException();
                Console.WriteLine(" Введи имя: ");
                firstName = Console.ReadLine();
                if (firstName == string.Empty)
                    throw new FormatException();
                Console.WriteLine(" Введи отчество: ");
                fathersName = Console.ReadLine();
                if (fathersName == string.Empty)
                    throw new FormatException();
                Console.WriteLine(" Введи название университета: ");
                university = Console.ReadLine();
                if (university == string.Empty)
                    throw new FormatException();
                Console.WriteLine(" Введи номер группы: ");
                group = Console.ReadLine();
                if (group == string.Empty)
                    throw new FormatException();
                Console.WriteLine(" Введи возраст: ");
                ageStr = Console.ReadLine();
                if (ageStr == string.Empty)
                    throw new FormatException();
                try
                {
                    ageInt = Int16.Parse(ageStr);
                    output.print(secondName, firstName, fathersName, ageInt, university, group);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(" Неправильный формат ввода возраста, исключение {0}", e);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" Введена пустая строка, исключение {0}", e);
            }
           
        }
    }
}
