using System;

namespace Library
{
        public class Sword : Equipment
        {
            public string Name { get; }

            public int Damage { get; }

            public int Weight { get; }
            public Sword(string name, int dmg, int weight)
            {
                this.Name = name;
                this.Damage = dmg;
                this.Weight = weight;
            }

            

        }

        public class Axe
        {
            public string Name { get; }

            public int Damage { get; }

            public int Weight { get; }
            public Axe(string name, int dmg, int weight)
            {
                this.Name = name;
                this.Damage = dmg;
                this.Weight = weight;
            }
        }
}