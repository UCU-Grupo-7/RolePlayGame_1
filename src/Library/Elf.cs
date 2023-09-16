using System;

namespace Library
{
    public class Elf : ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }

        public Elf(string name, int health, int damage, int defense)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.Defense = defense;


        }

        public void Attack()
        {
            
        }
        public void Heal()
        {
            
        }
    }
}