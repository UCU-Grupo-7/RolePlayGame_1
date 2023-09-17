using System;
using System.Collections.Generic;

namespace Library
{
    public class Spell
    {
            public Spell(string name, int dmg)
            {
                this.Name = name;
                this.Damage = dmg;
            }

            public string Name { get; }

            public int Damage { get; }

        }
    public class SpellBook : Equipment
    {
            public SpellBook(string name, int weight)
            {
                this.Name = name;
                this.Weight = weight;
            }

            public string Name { get; }

            public int Weight { get; }
            public Inventory<Spell> Inventory;

            public void Magics(){
            Inventory<Spell> basicSpells = new Inventory<Spell>();
            Spell fireball = new Spell("Fireball", 50);
            basicSpells.AddItem(fireball);
            Spell electricbolt = new Spell("Electric Bolt", 50);
            basicSpells.AddItem(electricbolt); 
            this.Inventory = basicSpells;
            }

                
    }
}