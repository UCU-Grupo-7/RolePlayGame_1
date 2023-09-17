using System;
using System.Runtime.CompilerServices;
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

            Elf Legolas = new Elf("Legolas", 100, 60, 30);

            Sword Excalibur = new Sword("Excalibur", 50, 50);


            Console.WriteLine(Harry.Health);
            Gandalf.Attack(Harry);
            Console.WriteLine(Harry.Health);
            Harry.Heal(100);
            Console.WriteLine(Harry.Health);

            Harry.Inventory.AddItem(Excalibur);
        }
    }
}
