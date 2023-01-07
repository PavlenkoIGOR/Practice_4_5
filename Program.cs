using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string NameOf, string SurnameOf, bool Pet, int Age, string[] FavColors, string Login) user;
            Console.Write("enter qantity of users: ");
            byte n = Convert.ToByte(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                Console.Write("enter your name: ");
                user.NameOf = Console.ReadLine();
                Console.Write("enter your surname: ");
                user.SurnameOf = Console.ReadLine();
                Console.Write("enter your age: ");
                user.Age = Convert.ToByte(Console.ReadLine());

                user.FavColors = new string[3];
                Console.Write("enter your favourite color №1: ");
                user.FavColors[0] = Console.ReadLine();
                Console.Write("enter your favourite color №2: ");
                user.FavColors[1] = Console.ReadLine();
                Console.Write("enter your favourite color №3: ");
                user.FavColors[2] = Console.ReadLine();
                Console.Write("enter your login: ");
                user.Login = Console.ReadLine();
                int a = 0;
                foreach (var item in user.Login)
                {
                    a += 1;
                }

                Console.Write("have you got a pet?(y/n): ");
                string p = Console.ReadLine();
                if (p == "y")
                {
                    user.Pet = true;
                }
                else user.Pet = false;


                Console.WriteLine("Итак, пользователь " + (i + 1) + " :");
                Console.WriteLine("имя: {0}", user.NameOf);
                Console.WriteLine("фамилия: {0}", user.SurnameOf);
                Console.WriteLine("возраст: {0}", user.Age);
                Console.WriteLine("питомец: {0}", user.Pet);
                Console.WriteLine("любимые цвета: {0}, {1}, {2}", user.FavColors[0], user.FavColors[1], user.FavColors[2]);
                Console.WriteLine("login: {0}", user.Login);
                Console.WriteLine("length of login: {0}, {1}", a, user.Login.Length);

            }

            ///////////////////////////////////////////

            Console.ReadKey();

        }
    }
}
