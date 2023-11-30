using System;
namespace layihe_generics
{
    class GenericCustomList<T>
    {
        private T[] items;
        private int count;
        private int capacity;

        public GenericCustomList()
        {
            items = new T[0];
            count = 0;
            capacity = 4;
        }

        public int Count
        {
            get { return count; }
        }

        public int Capacity
        {
            get { return capacity; }
        }

        public void Add(T item)
        {
            if (count == capacity)
            {
                capacity *= 2;
                Array.Resize(ref items, capacity);
            }
            items[count] = item;
            count++;
        }

        public T Find(Predicate<T> match)
        {
            return Array.Find(items, match);
        }

        public GenericCustomList<T> FindAll(Predicate<T> match)
        {
            Array.FindAll<T>(items, match);

            return this;
        }


        public bool Contains(T item)
        {
            return Array.IndexOf(items, item) != -1;
        }

        public bool Exists(Predicate<T> match)
        {
            return Array.Exists(items, match);
        }

        public void Remove(T item)
        {
            int index = Array.IndexOf(items, item);
            if (index != -1)
            {
                for (int i = index; i < count - 1; i++)
                {
                    items[i] = items[i + 1];
                }
                count--;
            }
        }
    }
}
