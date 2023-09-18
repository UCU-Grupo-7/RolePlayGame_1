using System.Collections.Generic;

namespace Library
{
    public class Inventory<T>
    {
        private IList<T> Items = new List<T>();

        public void AddItem(T item)
        {
            this.Items.Add(item);
        }
        public void RemoveItem(T item)
        {
            this.Items.Remove(item);
        }

        public void PrintInventory(T items)
        {
            foreach (T item in Items)
            {
                Console.WriteLine("Items");
            }
        }
    }
}