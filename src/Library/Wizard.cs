
namespace Library
{
        public class Wizard : ICharacter
        {  

            public string Name { get; set; }
            public int Health { get; set; }
            public int Damage { get; set; }
            public int Defense { get; set; }
            public Inventory<Equipment> Inventory;

            public Wizard(string name, int health, int damage, int defense)
            {
                this.Name = name;
                this.Health = health;
                this.Damage = damage;
                this.Defense = defense;

                this.Inventory = new Inventory<Equipment>();

                //Magic();
            }


            public void Attack(ICharacter character)
            {
                character.Health = character.Health + character.Defense - this.Damage;
            }
            public void Heal(int heal)
            {
                this.Health = this.Health + heal;
            }
            
            //void Magic()
            //{
            //    SpellBook SpellBook = new SpellBook("Morellonomicon", 0);
            //    SpellBook.Magics();
            //    Inventory.AddItem(SpellBook);
            //}

            
        }
}