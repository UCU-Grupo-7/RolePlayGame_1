using System;
using Library;

namespace RolePlay
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Wizard Gandalf = new Wizard("Gandalf", 100, 50, 25);
            Wizard Harry = new Wizard("Harry", 100, 40, 20);
            Console.WriteLine("Lol");
            Harry.Magic();

            Elf Legolas = new Elf("Legolas", 100, 60, 30);
        }
    }
}
