using System;
using Prueba_1.Model;

namespace Prueba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Eduardo", 28, 5);
            Console.WriteLine(user.miEdad());
        }
    }
}
