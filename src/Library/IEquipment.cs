using System;
using System.Collections.Generic;

namespace Library
{
    public interface IEquipment
    {
        void AddItem();
        void RemoveItem();
        void PrintItems();

        //string Name { get; set; }
        //int Health { get; set; }
        //int Damage { get; set; }
        //int Defense { get; set; }
    }

    
}