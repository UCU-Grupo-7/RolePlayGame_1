using System.Collections.Generic;

namespace Library
{
    public class Inventory<T>
    {
        private IList<T> items = new List<T>();

        public void AddItem(T item)
        {
            this.items.Add(item);
        }
        public void RemoveItem(T item)
        {
            this.items.Remove(item);
        }
    }
}