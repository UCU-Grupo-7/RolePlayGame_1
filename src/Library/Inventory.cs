namespace Library
using System.Collections.Generic;
{
    public class Inventory
    {
        public Inventory()

        private List<IEquipment> Items = new List<IEquipment>();
        public void AddItem(IEquipment item)
        {
            this.Items.Add(item)
        }
        public void RemoveItem(IEquipment item)
        {
            this.Items.Remove(item)
        }
        public void PrintItems()
        {
            foreach (IEquipment item in Items)
            {
                Console.WriteLine($"")
            }
        }
    }
}