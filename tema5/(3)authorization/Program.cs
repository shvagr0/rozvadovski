using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace authorization
{
    class Program
    {
        static void Main(string[] args)
        {
            const string login = "login";
            const string password = "password";

            Console.Write("Логiн: ");
            string ent_login = Console.ReadLine();

            Console.Write("Пароль: ");
            string ent_password = Console.ReadLine();


            if (password != ent_password && login != ent_login)
            {
                Console.WriteLine("Невiрний логiн та пароль");
            }
            else if (password != ent_password)
            {
                Console.WriteLine("Невiрний пароль");
            }
            else if (login != ent_login)
            {
                Console.WriteLine("Невiрний логiн");
            }
            else
            {
                Console.WriteLine("Ви успiшно ввiйшли");
            }



            Console.ReadKey();
        }
    }
}
