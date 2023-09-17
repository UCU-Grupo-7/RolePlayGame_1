using System;
using System.Collections.Generic;

namespace Library
{
    public interface ICharacter
    {
        void Attack(ICharacter character);
        void Heal(int heal);

        //Inventory<Equipment> Inventory { get; set; }
        string Name { get; set; }
        int Health { get; set; }
        int Damage { get; set; }
        int Defense { get; set; }
    }

    
}