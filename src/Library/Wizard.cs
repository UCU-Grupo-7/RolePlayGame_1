namespace Library
{
    public interface IMage
        {
            void Magic();
        }

        public class Wizard : ICharacter, IMage
        {
            public void Magic()
            {
                Console.WriteLine("Add SpellBook to this wizard!");
            }

            public string Name { get; set; }
            public int Health { get; set; }
            public int Damage { get; set; }
            public int Defense { get; set; }

            public Wizard(string name, int health, int damage, int defense)
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